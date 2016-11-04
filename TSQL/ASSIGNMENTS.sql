---- SECTION 1 ----
--- Challenge 1 --- 
-- 1.
SELECT 
	Title + ' ' + 
	FirstName + ' ' + 
	ISNULL(MiddleName, '') + ' ' +
	LastName + ' ' +
	ISNULL(Suffix, '')
	-- SELECT *
FROM SalesLT.Customer;

-- 2. 
SELECT 
	SalesPerson
	,ISNULL(Title, '') + 
		CASE WHEN Title IS NOT NULL THEN ' ' ELSE '' END + 
		ISNULL(LastName, '') 
		AS CustomerName
	,Phone
FROM SalesLT.Customer;

--- Challenge 2 --- 
-- 1. 
SELECT 
	CAST(CustomerId AS NVARCHAR(20)) + 
	': ' 
	+ CAST(CompanyName AS NVARCHAR(100))
FROM SalesLT.Customer;

-- 2.
SELECT 
	CAST(SalesOrderNumber AS NVARCHAR(20)) + 
	' (' + 
	CAST(RevisionNumber AS NVARCHAR(20)) +
	')'
	,CONVERT(NVARCHAR(100), OrderDate, 102)
	--SELECT * 
FROM SalesLT.SalesOrderHeader

--- Challenge 3 ---
-- 1.
SELECT 
	CASE
		WHEN MiddleName IS NOT NULL 
			THEN FirstName + ' ' + MiddleName + ' ' + LastName 
		ELSE 
			FirstName + ' ' + LastName 
	END
FROM SalesLT.Customer;

-- 2.
SELECT 
	CustomerId
	,COALESCE(EmailAddress, phone) AS PrimaryContact
	-- select *
FROM SalesLT.Customer;

-- 3.
SELECT 	SalesOrderId	,OrderDate	,CASE 		WHEN ShipDate IS NULL THEN 'Awaiting Shipment'		ELSE 'Shipped'	END AS ShippingStatusFROM SalesLT.SalesOrderHeader