-- вертикальное объединение таблиц, в противовес горизонтальному объединению с помощью JOIN
SELECT * FROM (
	SELECT TOP(2) WITH TIES 
		[Name], 
		Color,
		ListPrice
	FROM Production.Product 
	WHERE Color = 'Black'
	ORDER BY ListPrice DESC)
AS TA -- первый компонент
UNION ALL -- включая дубликаты (в этом примере их нет)
SELECT * FROM (
	SELECT TOP(2) WITH TIES 
		[Name], 
		Color,
		ListPrice
	FROM Production.Product 
	WHERE Color = 'Red'
	ORDER BY ListPrice DESC) 
AS TB -- второй компонент
--ORDER BY Name;
-- тут мы использовали промужуточную временную таблицу (TA, TB) - Derived Table

---------- второй пример ------------
-- Выбрать два самых дорогих чёрных товара и 20 каких-нибудь товаров, которые дороже 3000
SELECT * FROM (
	SELECT TOP(2)
		[Name], 
		Color,
		ListPrice
	FROM Production.Product 
	WHERE Color = 'Black'
	ORDER BY ListPrice DESC)
AS TB
UNION -- ALL -- исключая дубликаты. Тут есть два дубликата
SELECT * FROM (
SELECT TOP(20)
		[Name], 
		Color,
		ListPrice
	FROM Production.Product 
	WHERE ListPrice > 3000
	ORDER BY ListPrice DESC
) 
AS TB

------ пример из MSDN -------------

IF OBJECT_ID ('dbo.Gloves', 'U') IS NOT NULL  
DROP TABLE dbo.Gloves;  
GO  
-- Create Gloves table.  
SELECT ProductModelID, Name  
INTO dbo.Gloves  
FROM Production.ProductModel  
WHERE ProductModelID IN (3, 4);  
GO 

SELECT ProductModelID, Name  
FROM Production.ProductModel  
WHERE ProductModelID NOT IN (3, 4)  
UNION  
SELECT ProductModelID, Name  
FROM dbo.Gloves  
ORDER BY Name;  
GO 

-------- Второй пример из MSDN --------
IF OBJECT_ID ('dbo.ProductResults', 'U') IS NOT NULL  
DROP TABLE dbo.ProductResults;  
GO  
IF OBJECT_ID ('dbo.Gloves', 'U') IS NOT NULL  
DROP TABLE dbo.Gloves;  
GO  
-- Create Gloves table.  
SELECT ProductModelID, Name  
INTO dbo.Gloves  
FROM Production.ProductModel  
WHERE ProductModelID IN (3, 4);  
GO  
  
SELECT ProductModelID, Name  
INTO dbo.ProductResults  
FROM Production.ProductModel  
WHERE ProductModelID NOT IN (3, 4)  
UNION  
SELECT ProductModelID, Name  
FROM dbo.Gloves;  
GO  
  
SELECT ProductModelID, Name   
FROM dbo.ProductResults;  

---------------- Упражнение: делаем Union таблицы с самой собой, чтоб убрать дубликаты ----------
-- например, покупателю важны только Цвет, Цена и Класс велосипеда. 
-- Дубликатами сочтём все велосипеды, имеющие одинаковый цвет, цену и класс
Select Color, ListPrice, Class from Production.Product
UNION -- ALL -- ALL даёт 1008, без ALL получаем 128 записей
Select Color, ListPrice, Class from Production.Product

-- Однако, более удобным способом добиться того же будет использование DISTINCT
Select DISTINCT Color, ListPrice, Class from Production.Product


------------------------- INTERSECT -----------------------------

-- выберем номера клиентов, у которых есть более 10 заказов, 
-- но в то же время таких, которые делали заказ более, чем на 20000
	SELECT DISTINCT
		CustomerId 
	FROM Sales.SalesOrderHeader
	GROUP BY CustomerId
	HAVING COUNT(*) > 10
INTERSECT
	SELECT DISTINCT 
		CustomerId 
		-- select * 
	FROM Sales.SalesOrderHeader
	WHERE TotalDue > 20000
-- таких клиентов 56

----------------------- EXCEPT ----------------------------------

-- "A кроме B"
-- все клиенты, сделавшие более 10 заказов, кроме тех, которые 
-- делали в том числе и малые заказы на сумму 20000
	SELECT DISTINCT
		CustomerId 
	FROM Sales.SalesOrderHeader
	GROUP BY CustomerId
	HAVING COUNT(*) > 10
EXCEPT
	SELECT DISTINCT 
		CustomerId 
		-- select * 
	FROM Sales.SalesOrderHeader
	WHERE TotalDue < 20000

---------------------- APPLY ------------------------------------

-- показать пять последних заказов для каждого из клиентов
-- реализация без APPLY на основе Derived Query и Window Function 

SELECT 
	t.CustomerId,
	t.SalesOrderId
FROM (
	SELECT 
		CustomerId,
		SalesOrderId,
		CAST(OrderDate AS DATE) as orderdate,
		ROW_NUMBER() OVER (PARTITION BY CustomerID ORDER BY OrderDate DESC) as myOrder
		-- select *
	FROM Sales.SalesOrderHeader 
) as t 
WHERE t. myOrder <= 5

-- Реализация на основе APPLY
SELECT 
	c.CustomerID,
	o.*
FROM Sales.Customer AS c
OUTER APPLY (
	SELECT TOP(5) 
		soh.SalesOrderID,
		soh.OrderDate
	FROM Sales.SalesOrderHeader as soh
	WHERE soh.CustomerId = c.CustomerID -- замыкание!
	ORDER BY soh.OrderDate DESC
) AS o
WHERE 1 = 1


