USE AdventureWorks2016CTP3;

------- Distinct ------------------------------

select distinct StoreId from Sales.Customer 
where StoreId > 300
order by storeId 

select count(*) from Sales.Customer

------------- Column aliases -----------------------

-- 1. Using AS

select SalesOrderId, UnitPrice, OrderQty as Quantity 
from Sales.SalesOrderDetail

-- 2. Using = 

select SalesOrderId, UnitPrice, Quantity = OrderQty
from Sales.SalesOrderDetail

-- 3. Accidental
Select SalesOrderId, UnitPrice Quantity
from Sales.SalesOrderDetail

-- or it is by my design 

Select SalesOrderId, UnitPrice, OrderQty Quantity
from Sales.SalesOrderDetail

----------- Table aliases ---------------------------

-- 1. With AS 
Select SOD.SalesOrderId, SOD.UnitPrice
from Sales.SalesOrderDetail as SOD

-- 2. Without AS
SELECT SOD.SalesOrderID, SOD.OrderQty
FROM Sales.SalesOrderDetail SOD

--------------- CASE Statement --------------------- 
-- 1. Simple CASE expression
SELECT ProductId, [Name], ProductSubcategoryID,
	CASE ProductSubcategoryID 
		WHEN 1 THEN 'Mountain Bikes'
		WHEN 2 THEN 'Road Bikes'
		WHEN 3 THEN 'Touring Bikes'
		ELSE 'Non-bike'
	END 
	AS 'String Category'
FROM Production.Product

-- 2. Searched CASE expression
SELECT ProductId, [Name], ProductSubcategoryID,
	CASE  
		WHEN ProductSubcategoryID = 1 THEN 'Mountain Bikes'
		WHEN ProductSubcategoryID = 2 THEN 'Road Bikes'
		WHEN ProductSubcategoryID = 3 THEN 'Touring Bikes'
		ELSE 'Non-bike'
	END 
	AS 'String Category'
FROM Production.Product

--------- ORDER BY ----------------------------------

-- cортировать необязательно по одному из выбираемых столбцов!
-- можно и по столбцу, не входящему в выборку
SELECT SalesOrderId, OrderDate 
FROM Sales.SalesOrderHeader 
ORDER BY OrderDate

-- сортировка по алиасу
SELECT YEAR(OrderDate) as OrderYear 
FROM Sales.SalesOrderHeader 
ORDER BY OrderYear ASC 
-- ASC is default

-- сортировка по убыванию
SELECT YEAR(OrderDate) as OrderYear 
FROM Sales.SalesOrderHeader 
ORDER BY OrderYear DESC

-------------------- TOP ------------------------------

-- TOP(N) показывает сколько строк выбирать после прохождения всех остальных условий
-- 1. Простой TOP
SELECT TOP(20) 
	SalesOrderID, 
	CustomerID, 
	TotalDue
FROM Sales.SalesOrderHeader 
ORDER BY TotalDue DESC

-- 2. WITH TIES -----------------------------------
-- покажем как WITH TIES делает недетерминированный запрос детерминированным
-- полезно для упорядочивания по неуникальному полю.
-- (Вообще, ORDER BY по неуникальному полю таит в себе некоторые трудности)

-- 2.1 Недетерминированный запрос (возвращает точно 21 запись)
--  однако, за рамками вывода остаются записи с точно такой же датой!
--  а состав выведенных записей зависит от физического расположения записей на диске!
SELECT TOP(21) 
	SalesOrderId, 
	OrderDate, 
	[Status] 
FROM Sales.SalesOrderHeader
ORDER BY OrderDate DESC

-- 2.2 WITH TIES выводит 40 записей, несмотря на TOP(21)
--  запрос детерминирован, выводит все связанные строки за текущую дату
SELECT TOP(21) WITH TIES
	SalesOrderId, 
	OrderDate, 
	[Status] 
FROM Sales.SalesOrderHeader
ORDER BY OrderDate DESC

-- 2.3 Если выйдем за границу выведенных 40 запросов, то число строк вывода 
-- увеличится ещё на некоторый набор, и станет равно 63
SELECT TOP(41) WITH TIES
	SalesOrderId, 
	OrderDate, 
	[Status] 
FROM Sales.SalesOrderHeader
ORDER BY OrderDate DESC

-- 3. PERCENT - можем выбрать определённое число процентов сверху
-- комбинируется с WITH TIES 
SELECT TOP(5) PERCENT --WITH TIES
	SalesOrderId, 
	OrderDate, 
	[Status] 
FROM Sales.SalesOrderHeader
ORDER BY OrderDate DESC

-- 4. OFFSET / FETCH - may be useful for paging
-- 31465 rows in total, we have to get the third page where page size is 400 elements.
SELECT 
	SalesOrderId, 
	OrderDate, 
	[Status] 
FROM Sales.SalesOrderHeader
ORDER BY SalesOrderId ASC
OFFSET 2*400 ROWS 
FETCH NEXT 400 ROWS ONLY;
    