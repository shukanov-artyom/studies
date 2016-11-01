-- CAST / CONVERT operator

SELECT
	CAST(ProductId AS VARCHAR(5)) +	': ' + [Name] AS ProductIdName
FROM SalesLT.Product

SELECT
	CONVERT(VARCHAR(5), ProductId) + ': ' + [Name] AS ProductIdName
FROM SalesLT.Product

-- У CONVERT немного другой синтаксис: параметры переставлены местами
-- CONVERT позволяет задать стиль конверсии

-- Конверсия дат - самое большое дело при использовании CONVERT
-- стили описаны на MSDN https://msdn.microsoft.com/en-us/library/ms187928.aspx#Anchor_4
SELECT DISTINCT TOP(1)
	SellStartDate AS UnconvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate) AS DefaultConvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate, 126) AS ISO8601ConvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate, 101) AS USConvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate, 102) AS ANSIConvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate, 103) AS BritishFrenchConvertedDate
	,CONVERT(NVARCHAR(30), SellStartDate, 104) AS GermanConvertedDate
FROM SalesLT.Product

-- CAST vs TRY_CAST -- встроенные функции
SELECT 
	[Name]
	-- ,CAST(Size AS INT) AS IntegerSizeCast -- не сработает, там есть строковые размеры!
	,TRY_CAST(Size AS INT) AS IntegerSizeTryCast -- вернёт NULL где не сможет
FROM SalesLT.Product
WHERE Size IS NOT NULL

-- пример паттерна с использованием TRY_CAST + ISNULL
SELECT 
	[Name]
	,ISNULL(TRY_CAST(Size AS INT), 0) AS NumericSize
FROM SalesLT.Product

-- Использование NULLIF
-- Выводит NULL для товаров, цвет которых не задан однозначно
SELECT 
	[Name]
	,NULLIF(Color, 'Multi') as SingularColor
FROM SalesLT.Product
