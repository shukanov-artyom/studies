USE AdventureWorks2016CTP3;

-- Derived Table это очень удобная и уникальная в T-SQL штука. Её фичи: 
    -- существует только внутри запроса
	-- не reusable ни внутри запроса, ни вне него
    -- нельзя выставить на неё ссылку
	-- имеет имя
	-- обеспечивает некоторую изоляцию

-- базовый синтаксис

SELECT * FROM (
	SELECT * FROM Production.Culture
) AS Derived; -- тут обязательно дать ей имя, 
-- наследованная таблица не анонимна!

-- можем пользоваться наследованной таблицей как обычной таблицей, 
-- накатывать на неё любые запросы.
SELECT Derived.CultureID, Derived.Name FROM (
	SELECT TOP(20) WITH TIES
	*
	FROM Production.Culture
	ORDER BY CultureId
) AS Derived
WHERE CultureId <> '';

-- Пример на AdventureWorks
GO
SELECT TOP 10 FirstName, LastName
FROM
(SELECT * FROM Person.Person) AS PersonDerivedTable
WHERE LastName = 'Smith';

-- Ещё одно упражнение на AdventureWorks
/* the following query aggregates total sales orders by year as one query 
	and combines the results of the total sales orders per sales rep, per year of the second query. 
	The purpose is to get the percentage of sales orders by sales rep for each year.
*/
SELECT YearTotalsBySalesPerson.*
, YearTotals.TotalOrdersForYear
, CONVERT(DECIMAL(10,2), 100 * CONVERT(DECIMAL(10,2), YearTotalsBySalesPerson.SalesPersonTotalOrders)
/ CONVERT(DECIMAL(10,2), YearTotals.TotalOrdersForYear)) AS PercentageOfSalesForYear
FROM
--total sales orders per year
(SELECT 
	YEAR(OrderDate) AS [Year],
	COUNT(SalesOrderID) AS TotalOrdersForYear
FROM Sales.SalesOrderHeader SOH
WHERE SalesPersonID IS NOT NULL
GROUP BY YEAR(OrderDate)) AS YearTotals
JOIN
--total sales orders by sales rep per year
(SELECT YEAR(OrderDate) AS [Year]
, SalesPersonID
, COUNT(SalesOrderID) AS SalesPersonTotalOrders
FROM Sales.SalesOrderHeader
WHERE SalesPersonID IS NOT NULL
GROUP BY YEAR(OrderDate), SalesPersonID) AS YearTotalsBySalesPerson
ON YearTotals.[Year] = YearTotalsBySalesPerson.[Year]

-- используем выражение WITH в начале
WITH dd AS 
(
	SELECT 
		RANK() OVER(PARTITION BY CustomerId ORDER BY OrderDate DESC) AS MyRank,
		*
	FROM Sales.SalesOrderHeader
)
SELECT 
	* 
FROM dd 
WHERE MyRank = 1

-- выберем количество сделанных заказов для каждого клиента
SELECT 
	CustomerId,
	COUNT(*) AS OrdersCnt
FROM Sales.SalesOrderHeader
GROUP BY CustomerId;

-- рассмотрим применение Common Table Expressions
WITH cte AS (
	SELECT 
		CASE 
			WHEN RevisionNumber=8 THEN 'Ok'
			ELSE 'Not Ok'
		END AS Mark 
	FROM Sales.SalesOrderHeader
)
SELECT Mark, COUNT(*) FROM cte
GROUP BY Mark