CREATE VIEW Sales.Largest10Orders AS
	SELECT TOP(10) 
		*
	FROM Sales.SalesOrderHeader
	ORDER BY TotalDue


Select * from Sales.Largest10Orders

SELECT * FROM HumanResources.vEmployee