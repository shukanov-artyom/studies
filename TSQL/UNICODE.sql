
-- varchar string literal
SELECT 'Hej';

-- varchar string literal
SELECT 'Дej';

-- nvarchar string literal
SELECT N'Дej';

-- конкатенация c помощью +
SELECT 
	BusinessEntityId, 
	FirstName, 
	LastName,
	FirstName + N' ' + LastName AS 'FullName'
FROM Person.Person

-- конкатенация с помощью CONCAT
SELECT 
	BusinessEntityId, 
	FirstName, 
	LastName,
	CONCAT(FirstName, ' ', LastName) AS 'FullName'
FROM Person.Person

------- LIKE predicate -------------

-- 1. с помощью % выберем все гайки
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE '% nut %'

-- 2. с помощью _ выберем все Thin-Jam Hex Nut <с маркировкой от 0 до 10>
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE 'Thin-Jam Hex Nut _'

-- 3. с помощью списка символов выберем все Thin-Jam Hex Nut [1-4]
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE 'Thin-Jam Hex Nut [1,2,3,4]'

-- 3. и все остальные используя range
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE 'Thin-Jam Hex Nut [1-4]%'

-- 4. Могу заэскейпить символы таким вот образом:
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE 'Thin-Jam Hex Nut %' ESCAPE('%')
-- не выводит ничего, потому что я заэскейпил вайлдкард, и он ищет буквально знаки процента

-- 5. PERFORMANCE OVERHEAD
-- когда wildcard в начале строки, то движок не может использовать индекс на этой колонке!
SELECT 
	ProductId, 
	[Name], 
	ProductNumber, 
	ListPrice 
FROM Production.Product 
WHERE [Name] LIKE '%Jam Hex Nut' -- низкая производительность!



