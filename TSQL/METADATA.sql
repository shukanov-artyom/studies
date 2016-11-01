-- retrieving SQL Server metadata

-- System catalog views - modern and recommended way of retrieving data
-- all start with sys.
use training;
SELECT * FROM sys.tables
SELECT * FROM SYS.objects
SELECT * FROM sys.procedures

-- INFORMATION_SCHEMA views
SELECT * FROM information_schema.tables
SELECT * FROM INFORMATION_SCHEMA.ROUTINES --stored procedures

-- system metadata functions - server properties
SELECT @@VERSION
UNION ALL
SELECT SERVERPROPERTY('Collation')
UNION ALL 
SELECT SERVERPROPERTY('ProductVersion')

GO 

-- современные способы получения метаданных:
-- SELECT SERVERPROPERTY
-- SELECT DATABASEPROPERTYEX
-- SELECT DATABASEPROPERTY

-- Остальное в основном для обратной совместимости

-- Dynamic Management Views and Functions:
-- DMV / DMF
select * from sys.dm_exec_connections