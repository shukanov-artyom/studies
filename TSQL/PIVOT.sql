SELECT * FROM
(SELECT  -- готовим входные данные. 
-- Обратим внимание на данные о годе, они расположены в отдельной колонке
-- мы сгруппируем сожержимое этйо колонки и превратим её в несколько столбцов
	TerritoryId,  
	YEAR(OrderDate) as OrderYear,
	TotalDue
FROM Sales.SalesOrderHeader) AS D
