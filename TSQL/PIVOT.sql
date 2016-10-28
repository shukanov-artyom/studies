-- готовим входные данные. 
-- Обратим внимание на данные о годе, они расположены в отдельной колонке
-- мы сгруппируем сожержимое этой колонки и превратим её в несколько столбцов

WITH d AS( -- готовим входные данные для пивота
	SELECT 
		TerritoryId,  
		YEAR(OrderDate) as OrderYear,
		TotalDue
	FROM Sales.SalesOrderHeader
)
SELECT 
	TerritoryId, 
	[2011], 
	[2012], 
	[2013], 
	[2014] 
FROM d
PIVOT (
	Sum(TotalDue) FOR OrderYear IN ([2011], [2012], [2013], [2014])
) AS Pvt -- новая таблица Pvt
ORDER BY Pvt.TerritoryID

-- простой пример из MSDN
-- таблицу, подобную данной: 
SELECT 
	DaysToManufacture,
	AVG(StandardCost) AS AvgCost
FROM Production.Product
GROUP BY DaysToManufacture;
-- можем получить с помощью оператора PIVOT

WITH src AS ( -- готовим входные данные
	SELECT
		DaysToManufacture,
		StandardCost
	FROM Production.Product
)
SELECT 'Standardc' AS AverageCost, [0], [1], [2], [3], [4] 
FROM src
PIVOT (
	AVG(StandardCost) -- даже названия колонке не даём, сверху написали абы что (Standardc) и оно подхватило!
	FOR DaysToManufacture IN ([0], [1], [2], [3], [4])
) as Pvt;

-- второй пример из MSDN
WITH src AS (
	SELECT 
	PurchaseOrderID,
	EmployeeID,
	VendorID
FROM Purchasing.PurchaseOrderHeader 
)
SELECT 
	VendorId,
	[250] as 'Emp 250',

FROM src
PIVOT 
