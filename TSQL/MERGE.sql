/*SELECT	
	ProductId
	,Name
INTO Products 
FROM Production.Product

GO

SELECT 
	ProductID as '@id',
	[Name] AS '@name' 
FROM Products
WHERE [Name] LIKE 'A%'
FOR XML 
	PATH('product')		-- for each row i want to generate element 'product'
	,ROOT('products')	-- root element must be called 'products'*/

DECLARE @myXml XML = N'<products>
  <product id="1" name="Adjustable Race!" />
  <product id="879" name="All-Purpose Bike Stand!" />
  <product id="712" name="AWC Logo Cap!" />
  <product name="New added element" /> 
</products>'; -- new element added here without an idedtity column value

WITH src AS (
	SELECT 
		xt.xc.value('@id', 'INT') AS ProductId,
		xt.xc.value('@name', 'NVARCHAR(100)') AS [Name]
	FROM @myXml.nodes('products/product') as xt(xc) -- xpath syntax!
)
MERGE INTO Products AS dest
	USING src ON src.ProductId = dest.ProductId
WHEN NOT MATCHED THEN 
	INSERT ([Name]) VALUES (src.[Name])
WHEN MATCHED THEN 
	UPDATE SET [NAme] = src.Name;


SELECT 
	ProductID as '@id',
	[Name] AS '@name' 
FROM Products
WHERE [Name] LIKE 'A%' OR [Name] LIKE 'new%'
--DROP TABLE Products