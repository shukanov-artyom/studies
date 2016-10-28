-- рассмотрим следующий запрос: 
-- хочу получить суммарные продажи на клиента и территорию

SELECT 
	c.CustomerId, 
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.CustomerID, c.TerritoryID

-- но пришёл заказчик, и сказал добавить в этот вывод данные по кастомеру независимо от территории!
-- Это отдельный запрос, поэтому мы реализуем его с помощью UNION ALL
-- недостающие поля забиваем NULL

SELECT 
	c.CustomerId, 
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.CustomerID, c.TerritoryID
UNION ALL 
SELECT 
	c.CustomerId, 
	NULL,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.CustomerID
ORDER BY TerritoryId

--аналогично - добавить данные по территории независимо от клиента
SELECT 
	c.CustomerId, 
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.CustomerID, c.TerritoryID
UNION ALL 
SELECT 
	NULL, 
	c.TerritoryId,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.TerritoryID
ORDER BY CustomerId, TerritoryID

-- и давайте ещё добавим глобальный тотал
SELECT 
	c.CustomerId, 
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.CustomerID, c.TerritoryID
UNION ALL 
SELECT 
	NULL, 
	c.TerritoryId,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY c.TerritoryID
UNION ALL
SELECT 
	NULL, 
	NULL,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
ORDER BY CustomerId, TerritoryID

-- полученный запрос поризводит группировку одних и тех же данных по трём разным критериям
-- результаты объединяются с помощью UNNION ALL
-- есть сокращённый синтаксис для решения тех же задач: GROUP BY GROUPING SETS

SELECT 
	c.CustomerId, 
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY GROUPING SETS (
	(c.CustomerID, c.TerritoryID),	-- для клиента по территории
	(c.TerritoryId),				-- для территории независимо от клиента
	()								-- независимо ни от территории, ни от клиента
)
ORDER BY CustomerId, TerritoryId;

-- А что, если есть CustomerId == NULL?
-- как понять, что NULL в выводе сгенерирован, а не выселекчен из реальной таблицы?
-- для этого существует специальная функция, возвращающая {0, 1}
-- Пример (НЕ РАБОТАЕТ ИЗ-ЗА ТИПИЗАЦИИ, НО ПОКАЗЫВАЕТ ПАТТЕРН):

SELECT 
	ISNULL(c.CustomerId, CASE WHEN GROUPING(c.CustomerId) = 0 THEN 'UNKNOWN' ELSE 'ALL' END) AS CustomerId,
	ISNULL(c.TerritoryID, CASE WHEN GROUPING(c.TerritoryId) = 0 THEN 'UNKNOWN' ELSE 'ALL' END) AS TerritoryId,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY GROUPING SETS (
	(c.CustomerID, c.TerritoryID),	
	(c.TerritoryId),				
	()								
)
ORDER BY CustomerId, TerritoryId

-- GROUPING() выдаёт 1, если значение NULL вставлено как заглушка оператором GROUP BY GROUPING SETS
-- в противном случае выдаёт 0 для данной колонки - встречен реальный NULL в исходной таблице.
-- вверху описно типичное применение функции GROUPING() совместно с ISNULL и CASE

-----------------------------------

-- Другие расширения GROUP BY
-- ROLLUP
SELECT 
	c.CustomerId,
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY ROLLUP (c.CustomerID, c.TerritoryID)
ORDER BY TerritoryId, CustomerID
-- разворачивает заданное сочетание группирующих столбцов во все возможные аналогично GROUPING SETS выше
-- НО СОХРЯНЯЕТ ИЕРАРХИЮ!

-- CUBE
SELECT 
	c.CustomerId,
	c.TerritoryID,
	SUM(sod.LineTotal) AS TotalSales
FROM Sales.Customer AS c
INNER JOIN Sales.SalesOrderHeader soh ON soh.CustomerID = c.CustomerID
INNER JOIN Sales.SalesOrderDetail sod ON sod.SalesOrderID = soh.SalesOrderID
GROUP BY CUBE (c.CustomerID, c.TerritoryID)
ORDER BY TerritoryId, CustomerID
-- CUBE не сохраняет иерархию, просто перебирает все возможные сочетания.

