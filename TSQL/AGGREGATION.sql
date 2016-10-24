-- Агрегация по всей таблице
SELECT 
	COUNT(Distinct SalesOrderId) AS 'Unique Orders',
	AVG(UnitPrice) AS 'Average unit price',
	MIN(OrderQty) AS 'Minimal order quantity',
	AVG(OrderQty) AS 'Average order quantity',
	MAX(OrderQty) AS 'Maximum order quantity',
	MAX(LineTotal) AS 'Maximal position price'
FROM Sales.SalesOrderDetail

-- Агрегация по таблице с группировками
SELECT 
	DATEPART(YEAR, OrderDate) as 'Year',
	COUNT(*) AS 'Orders count',
	SUM(TaxAmt) AS 'Total taxes' 
FROM Sales.SalesOrderHeader
GROUP BY DATEPART(YEAR, OrderDate);

-- ещё пример
SELECT * FROM Sales.SalesOrderHeader

SELECT COUNT(DISTINCT CustomerId) FROM Sales.SalesOrderHeader

-- агрегацию прекрасно можно делать с помощью оконных функций!
-- рассчитаем сколько в среднем с заказа заплатил налога каждый из клиентов
SELECT DISTINCT
	customerId, 
	AVG(TaxAmt) OVER (PARTITION BY CustomerId) AS tx
FROM Sales.SalesOrderHeader
ORDER BY tx

--------------- HAVING ----------------------------
SELECT 
	CustomerId, 
	COUNT(*) as ts
FROM Sales.SalesOrderHeader
WHERE TerritoryID = 6
GROUP BY CustomerID 
HAVING COUNT(*) > 10
ORDER BY ts

-- выберем количества пользователей, изменённых за последние годы, начиная с 2012
SELECT 
	YEAR(p.ModifiedDate) AS 'Year Modified',
	COUNT(*) AS 'Registered users count'
FROM Person.Person AS p
GROUP BY YEAR(p.ModifiedDate)
HAVING YEAR(p.ModifiedDate) > 2011

-- выберем все заказы самого активного покупателя (у которого больше всех заказов)
-- у самого активного 28 заказов, выберется 28 строк
SELECT 
	*
FROM Sales.SalesOrderHeader 
WHERE CustomerId = -- тут используется скаларный подзапрос 
(
	SELECT TOP(1)
		CustomerId
	FROM Sales.SalesOrderHeader
	GROUP BY CustomerId
	ORDER BY COUNT(*) DESC
)

-- выберем сумму заказов трёх самых активных покупателей
SELECT 
	CustomerId,
	SUM(TotalDue) as 'Money Sum'
FROM Sales.SalesOrderHeader 
WHERE CustomerId IN -- тут используется multi-valued подзапрос 
(
	SELECT TOP(3)
		CustomerId
	FROM Sales.SalesOrderHeader
	GROUP BY CustomerId
	ORDER BY COUNT(*) DESC
)
GROUP BY CustomerId
ORDER BY 'Money Sum' DESC

-- выберем все данные о клиентах, которые не делали заказов
SELECT 
	*
FROM Sales.Customer as cs
WHERE CustomerId NOT IN
(
	SELECT DISTINCT
		CustomerID 
	FROM Sales.SalesOrderHeader 
);

-- коррелированный подзапрос (замыкание)
-- выберем всех покупателей, которые не покупали товары дороже 100, но вообще что-то покупали
SELECT 
	CustomerId
FROM Sales.Customer sc
WHERE NOT EXISTS -- скореллированный подзапрос
(
	SELECT * FROM Sales.SalesOrderHeader
	WHERE CustomerID = sc.CustomerID
	AND TotalDue > 100
)
AND EXISTS -- скореллированный подзапрос
(
	SELECT * FROM Sales.SalesOrderHeader
	WHERE CustomerID = sc.CustomerID
);

-- информация по последнему заказу (заказ с максимальным айдишником)
SELECT 
	*
FROM Sales.SalesOrderDetail
WHERE SalesOrderID = 
(
	SELECT 
		MAX(SalesOrderID)
	FROM Sales.SalesOrderHeader
);
