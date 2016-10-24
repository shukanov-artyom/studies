
-- выдаст 2013-09-14 00:00:00.000
-- потому что округляет до ближайшего кратного 3 миллисекундам
SELECT CAST('2013-09-13 23:59:59.999' AS DATETIME); 

-- выдаёт 2013-09-13 23:59:59.997
-- тоже округление до ближайших кратных 3 мс, но уже вниз
SELECT CAST('2013-09-13 23:59:59.998' AS DATETIME); 

-- Даты вводятся с помощью строковых литералов
DECLARE @DateVariable DATETIME = CAST('2013-09-13 23:59:59.998' AS DATETIME);
SELECT @DateVariable;

DECLARE @AnotherDateVariable DATETIME = '20200213 17:00';
SELECT @AnotherDateVariable;

DECLARE @JustDateVariable DATETIME = '20161020';
SELECT @JustDateVariable; -- время забивается нулями

DECLARE @JustTimeVariable DATETIME = '21:20:11';
SELECT @JustTimeVariable; -- дата ставится в 01.01.1900

------------------- Получение текущего времени ------------------------

-- Время в текущем поясе по ANSI, DATETIME
SELECT CURRENT_TIMESTAMP;

-- текущее время в моём поясе без явного указания смещения от UTC, DATETIME
SELECT GETDATE(); 

-- время UTC DATETIME
SELECT GETUTCDATE();

-- время в моём поясе в DATETIME2, без явного указания смещения от UTC
SELECT SYSDATETIME();

-- время UTC в DATETIME2 без смещения
SELECT SYSUTCDATETIME();

-- время в текущем поясе с явным указанием смещения от UTC, DATETIME2
SELECT SYSDATETIMEOFFSET();

------------ Корректное разделение даты на части -----------------------
GO
DECLARE @myDate DATETIME = '19860204 22:22:22';
SELECT @myDate;

SELECT -- пытается дать строковое представлени
	DATENAME(DAY, @myDate),
	DATENAME(MONTH, @myDate),
	DATENAME(YEAR, @myDate);

SELECT -- простое числовое представление частей
	DATEPART(DAY, @myDate),
	DATEPART(MONTH, @myDate),
	DATEPART(YEAR, @myDate);

SELECT 
	DAY(@myDate),
	MONTH(@myDate),
	YEAR(@myDate);
GO

-------- Восстановление времени из кусков ---------------
-- демонтрируем разные способы восстановления времени из кусков, 
-- результаты, которые выводит каждое выражение, и тип результатов
	SELECT 
		'DATEFROMPARTS', 
		DATEFROMPARTS(2007, 05, 22), 
		SQL_VARIANT_PROPERTY(DATEFROMPARTS(2007, 05, 22), 'BaseType')
	UNION ALL 
	SELECT 
		'DATETIMEFROMPARTS', 
		DATETIMEFROMPARTS(2008, 07, 28, 22, 39, 07, 999), 
		SQL_VARIANT_PROPERTY(DATETIMEFROMPARTS(2008, 07, 28, 22, 39, 07, 999), 'BaseType')
	UNION ALL 
	SELECT 
		'DATETIME2FROMPARTS', 
		DATETIME2FROMPARTS(2009, 08, 28, 22, 39, 07, 50, 2),
		SQL_VARIANT_PROPERTY(DATETIME2FROMPARTS(2009, 08, 28, 22, 39, 07, 50, 2), 'BaseType')
	UNION ALL 
	SELECT 
		'DATETIMEOFFSETFROMPARTS', 
		DATETIMEOFFSETFROMPARTS(2009, 08, 28, 22, 39, 07, 50, 10, 30, 2),
		SQL_VARIANT_PROPERTY(DATETIMEOFFSETFROMPARTS(2009, 08, 28, 22, 39, 07, 50, 10, 30, 2), 'BaseType')
	UNION ALL 
	SELECT 
		'SMALLDATETIMEFROMPARTS', 
		SMALLDATETIMEFROMPARTS(2009, 08, 28, 22, 39),
		SQL_VARIANT_PROPERTY(SMALLDATETIMEFROMPARTS(2009, 08, 28, 22, 39), 'BaseType')
	UNION ALL 
	SELECT 
		'TIMEFROMPARTS', 
		TIMEFROMPARTS(10, 8, 28, 50, 2),
		SQL_VARIANT_PROPERTY(TIMEFROMPARTS(10, 8, 28, 50, 2), 'BaseType')

-----------------------------

SELECT DB_NAME() as CURRENT_DATABASE;
SELECT CAST(SYSDATETIME() as DATE);
SELECT ABS(-22.2);