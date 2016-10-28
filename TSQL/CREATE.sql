-- создаём таблицу только с Primary Key
IF EXISTS (SELECT * FROM sys.tables WHERE name='TrainingTable')
	DROP TABLE dbo.TrainingTable;
GO
CREATE TABLE dbo.TrainingTable
(
	MyKey BIGINT PRIMARY KEY CLUSTERED IDENTITY
);
GO

-- создаём таблицу со столбцами различных типов
IF EXISTS (SELECT * FROM sys.tables WHERE name='TrainingTable')
	DROP TABLE dbo.TrainingTable;
GO
CREATE TABLE dbo.TrainingTable
(
	Id BIGINT IDENTITY(1,1),
	[Weight] FLOAT NULL,
	ItemName NVARCHAR(120) NOT NULL,
	ExternalIdentifier BIGINT NOT NULL /*UNIQUE*/, -- would create nonclus index by default!
	CONSTRAINT UQ_Training_ExternalIdentifier UNIQUE (ExternalIdentifier),
	CONSTRAINT PK_Training_Id PRIMARY KEY CLUSTERED (Id) 
);

INSERT INTO dbo.TrainingTable 
	(Weight, ItemName, ExternalIdentifier) 
VALUES 
	(11, 'Barrel', 40002), 
	(7.4, 'Munition', 40004),
	(22.4, 'Canister', 40001)

SELECT * FROM dbo.TrainingTable
GO

-- NONCLUSTERED INDEX
IF EXISTS (SELECT name FROM sys.indexes  
            WHERE name = N'IX_TrainingTable_ItemName')   
    DROP INDEX IX_TrainingTable_ItemName ON dbo.TrainingTable;   
GO    
CREATE NONCLUSTERED INDEX IX_TrainingTable_ItemName   
    ON dbo.TrainingTable(ItemName);   
GO

-- задаём ограничения

-- используем оператор CHECK  для валидации данных

-- Создаём триггер