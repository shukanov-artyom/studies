-- using stored procedures
EXEC sys.sp_databases
EXEC sys.sp_tables
	@table_name = 'Accounts'
-- however this all is legacy

-- help may be useful
USE AdventureWorks2016CTP3;
EXEC sys.sp_help @objname = N'Sales.Customer'
GO

-- Получить все сторед процедуры для базы
SELECT * FROM INFORMATION_SCHEMA.ROUTINES
SELECT * FROM sys.procedures

-- создание процедуры

IF OBJECT_ID('dbo.sp_Training', 'P' ) IS NOT NULL 
BEGIN
	DROP PROCEDURE dbo.sp_Training
END
GO

CREATE PROCEDURE dbo.sp_Training
	(@qty INT)
AS 
BEGIN
	SELECT TOP(@qty) * FROM dbo.TrainingTable;
END
GO

EXEC dbo.sp_Training @qty = 2

-- внутри сторед процедуры можно создавать таблицы

SELECT * FROM TrainingTable

INSERT INTO TrainingTable
(MyKey)
VALUES
(1)

drop proc dbo.sp1, dbo.sp2
