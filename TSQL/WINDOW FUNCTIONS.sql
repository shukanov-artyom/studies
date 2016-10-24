-- window functions 
-- Крайне удобные! от них невозможно отвязаться потом 
-- ROW_NUMBER - window function
GO  
SELECT
	/* надо выполнить оконную функцию ROW_NUMBER над окнами, определёнными выражением OVER */
	/* выражение OVER разделяет весь вывод запроса на окна по полю PostalCode*/
	/* оконная функция ROW_NUMBER требует, чтобы окна, предоставленные OVER, были упорядочены, то есть обязателен ORDER BY */
	ROW_NUMBER() OVER(PARTITION BY PostalCode ORDER BY SalesYTD DESC) AS "Row Number",
    p.LastName, 
	s.SalesYTD, 
	a.PostalCode  
FROM Sales.SalesPerson AS s   
    INNER JOIN Person.Person AS p   
        ON s.BusinessEntityID = p.BusinessEntityID  
    INNER JOIN Person.Address AS a   
        ON a.AddressID = p.BusinessEntityID  
WHERE 
	TerritoryID IS NOT NULL   
    AND SalesYTD <> 0 
ORDER BY PostalCode;  
GO  

-- несколько других оконных функций

-- ROW_NUMBER ранжирующая функция (или как сказать про Ranking Function)
SELECT 
	ROW_NUMBER() OVER (PARTITION BY OrderQty ORDER BY OrderQty) AS RowN,
	* 
FROM Sales.SalesOrderDetail as t 
ORDER BY OrderQty;

-- агрегирующая оконная функция SUM
-- допустим, хочу для каждого заказанного предмета хочу увидеть суммарную стоимость корзины заказа, в которую он входил.

select * from Sales.SalesOrderDetail

SELECT
	sod.SalesorderId, 
	sod.OrderQty,
	sod.UnitPrice,
	pp.Name,
	SUM(sod.LineTotal) OVER (PARTITION BY SalesOrderID) as 'Total in Bucket with item',
	SUM(sod.LineTotal) OVER () as 'Total total' -- пустой OVER работает!
from Sales.SalesOrderDetail sod INNER JOIN 
Production.Product pp on pp.ProductID = sod.ProductID
ORDER BY SUM(sod.LineTotal) OVER (PARTITION BY SalesOrderID) DESC

----------



