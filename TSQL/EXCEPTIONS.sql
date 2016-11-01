-- TRY .. CATCH
-- сразу скажем, что не все ошибки могут быть пойманы!

-- Бросается объект типа ERROR
/* Его свойства:
	Number ERROR_NUMBER()
	Message ERROR_MESSAGE()
	Severity ERROR_SEVERITY
	Procedure Name ERROR_PROCEDURE()
	Line number ERROR_LINE()
*/

-- примеры использования
BEGIN TRY
	SELECT 1 / 0;
END TRY
BEGIN CATCH
	SELECT 
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH;
GO

-- Syntax, Compilation and Name Resolution errors cannot be catched!
-- because we have not started execution yet!!
BEGIN TRY
	SELECT COUNT(*) FROM dbo.NonexistentTable
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE() as ErrorMessage;
END CATCH;
GO

-- THROW statement - throws exception
-- добавлен в SQL Server 2012
BEGIN TRY	
	BEGIN TRY 
		SELECT 100/0 AS 'Problem'
	END TRY
	BEGIN CATCH
			PRINT 'CODE INSIDE CATCH'
			PRINT 'ERROR IS ' + CAST(ERROR_NUMBER() AS VARCHAR(255));
			THROW;
	END CATCH
END TRY
BEGIN CATCH
	PRINT 'INSIDE OUTER CATCH'
	PRINT ERROR_MESSAGE(); 
	-- THROW;  -- покажет ошибку в выводе вместе с результатом блока TRY
	-- THROW -- with parameters -- not throw original error
END CATCH
GO

-- примеры от Тобиаса
BEGIN TRY
	-- SELECT 1/0;
	SELECT 1; -- will be executed!
	EXEC ('BEGIN scoobidoo'); -- incorrect syntax error
	SELECT 2; -- will not be executed!
END TRY
BEGIN CATCH
	THROW;
END CATCH;

-- эксепшен не прерывает выполнение, если вне блока TRY
SELECT 3;
RAISERROR(
	'Error',	-- error message
	16,			-- Severity (0-25), below 11 ODBC will not raise error! USe 16
	1);			-- 
SELECT 4; -- We continue processing!
GO;

-- проброс из процедуры:
CREATE PROC sp1 -- создаём сторедку используя RAISERROR
AS 
RAISERROR('Error', 16, 1);
GO

CREATE PROC sp2 -- используем THROW
AS 
THROW 51000, 'THROWn error', 1;

BEGIN TRAN;
	EXEC sp1;
	SELECT 1; -- будет выполнено, так как мы не внутри блока TRY и бросается RAISERROR
COMMIT TRAN;

-- попробуем то же самое, но уже в блоке TRY
BEGIN TRY
	BEGIN TRAN;
	EXEC sp1;
	PRINT 'I am not executed!'; -- не будет выполнено, так как мы внутри блока TRY
COMMIT TRAN;
END TRY
BEGIN CATCH
	SELECT 'Got here inside this CATCH';
	SELECT ERROR_MESSAGE();
END CATCH;

-- попробуем всё то же самое со второй сторедкой
BEGIN TRY
	EXEC sp2;
	SELECT 'Called sp2, will not be executed!'
END TRY
BEGIN CATCH
	THROW;
END CATCH

GO
EXEC sp2;
SELECT 'Called sp2, will not be executed!'

-- Вывод: при использовании THROW батч прерывается в любом случае,
-- независимо от того выброс был в блоке TRY или вне его.
-- THROW - рекомендуемый способ проброса исключений.

