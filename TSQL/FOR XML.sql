SELECT	
	ProductId
	,Name
INTO Products 
FROM Production.Product

GO

SELECT 
	*
FROM Products
WHERE [Name] LIKE 'A%'
FOR XML 
	PATH('product')		-- for each row i want to generate element 'product'
	,ROOT('products')	-- root element must be called 'products'

GO

DROP TABLE Products