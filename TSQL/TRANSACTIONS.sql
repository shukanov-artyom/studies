-- BEGIN TRAN
-- COMMIT TRAN;
-- ROLLBACK TRAN

-- Eror handling alone cannot fix partial success when only full batch success is acceptable.
BEGIN TRY
	BEGIN TRAN;
		DECLARE @myInt INT = 5 / 0;
		SELECT @myInt * 20;
	COMMIT TRAN; -- persists changes and frees resources (locks)
END TRY
BEGIN CATCH 
	SELECT ERROR_NUMBER(); -- 8134 is division by zero
	ROLLBACK TRAN; -- also frees resources, reverts all changes
	-- ROLLBACK is not executed by default! Unless SET XACT_ABORT ON;
END CATCH

-- демо от Тобиаса про транзакции
CREATE TABLE Accounts(
	AccountId INT NOT NULL
	,Balance INT NOT NULL
);

INSERT INTO Accounts (AccountId, Balance)
VALUES (1231231, 500);
-- UPDATE Accounts set Balance = 500 WHERE AccountId=1231231

SELECT 
	*
FROM Accounts;

-- Connection 1: Tobias in the bank
BEGIN TRANSACTION
	-- проверяем достаточно ли денег на счету
	IF NOT EXISTS (
		SELECT * FROM Accounts
		WHERE AccountId = 1231231 AND Balance >= 400)
	BEGIN
		ROLLBACK TRANSACTION;
		THROW 50000, 'Tobias is to poor', 1;
	END
	-- at this point we are OK with account
	UPDATE Accounts SET
		Balance -= 400
	WHERE AccountId = 1231231
COMMIT TRANSACTION

-- sp_lock -- проверить локи можно так!

-- Connection 2: Brian at ATM
BEGIN TRANSACTION
	-- проверяем достаточно ли денег на счету
	IF NOT EXISTS (
		SELECT * FROM Accounts
		WHERE AccountId = 1231231 AND Balance >= 400)
	BEGIN
		ROLLBACK TRANSACTION;
		THROW 50000, 'Tobias is to poor', 1;
	END
	-- at this point we are OK with account
	UPDATE Accounts SET
		Balance -= 400
	WHERE AccountId = 1231231
COMMIT TRANSACTION

-- Есть более эффективный способ обеспечения целостности - используем WITH(UPDLOCK)
-- напишем реентерабельную транзакцию
BEGIN TRANSACTION
	IF NOT EXISTS (
		SELECT * FROM Accounts WITH (UPDLOCK) -- декларируем, что читаем, 
		-- но собираемся скоро писать и хотим обеспечить целостность между 
		-- операциями чтения и записи
		WHERE AccountId = 1231231 AND Balance >= 400)
	BEGIN
		ROLLBACK TRANSACTION;
		THROW 50000, 'Tobias is to poor', 1;
	END
	UPDATE Accounts SET
		Balance -= 400
	WHERE AccountId = 1231231
COMMIT TRANSACTION
 