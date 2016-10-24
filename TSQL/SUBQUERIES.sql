SELECT 
    SalesOrderId,
    *
FROM Sales.SalesOrderDetail
WHERE SalesOrderId = 
(
    SELECT MAX(SalesOrderId) AS LastOrder
    FROM Sales.SalesOrderDetail 
);