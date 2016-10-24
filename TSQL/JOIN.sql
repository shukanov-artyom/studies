USE AdventureWorks2016CTP3;

-- 1. Cross join (Cartesian product)
-- число строк равно произведению чисел строк соединяемых таблиц
-- соединение проходит не по равному столбцу, а прямым декатовым произведением (т.е. без условия)
SELECT * FROM Production.Product AS pp 
CROSS JOIN Production.ProductSubcategory AS psc 

-- дополнительный синтаксис для CROSS JOIN
-- выведет 18648 строк как обычный кросс-джойн
SELECT * FROM Production.Product, Production.ProductSubcategory

-- ещё пример
SELECT p.BusinessEntityID, t.Name AS Territory
FROM Sales.SalesPerson p
CROSS JOIN Sales.SalesTerritory t
ORDER BY p.BusinessEntityID;

----------------------------------
-- 2. INNER JOIN (или просто Join)
select * from production.Product
select * from production.ProductCategory

select pp.Name, psc.Name from production.Product pp
INNER JOIN Production.ProductSubcategory psc
ON pp.ProductSubcategoryID = psc.ProductSubcategoryID
-- ON 1=1 -- вырождается в простой CROSS JOIN

-----------------------------------------
--3. OUTER JOIN 
-- выводит полностью одну из таблиц, подхватывая возможные соответствия из другой
Select * from production.Product pp 
INNER JOIN production.ProductSubcategory psc
ON psc.ProductSubcategoryID = pp.ProductSubcategoryID
-- вывел 295 строк, что соответствует количеству продуктов, у которых есть подкатегория.
-- select * from Production.Product where ProductSubcategoryID IS NOT NULL

-- LEFT OUTER JOIN выведет как минимум столько строк, сколько есть строк в левой таблице, 
-- а где сможет - объединит со строками правой таблицы
Select * from production.Product pp 
LEFT OUTER JOIN production.ProductSubcategory psc
ON psc.ProductSubcategoryID = pp.ProductSubcategoryID

-- ещё пример левого: показать клиентов, которые не делали заказы
SELECT cust.CustomerID, cust.AccountNumber, cust.CustomerID from sales.customer as cust 
left outer join sales.salesOrderHeader as ord
on cust.CustomerID = ord.CustomerID
WHERE ord.SalesOrderID IS NULL;
--FOR JSON AUTO;

-- RIGHT OUTER JOIN выведет как минимум столько строк, сколько есть строк в правой таблице, 
-- а где сможет - объединит со строками левой таблицы
-- вывел 295 строк - левая таблица больше, и результирующих строк больше, чем просто в правой таблице
SELECT * FROM production.ProductSubcategory psc 
RIGHT OUTER JOIN production.Product pp
ON psc.ProductSubcategoryID = pp.ProductSubcategoryID

-- FULL OUTER JOIN 
SELECT * FROM production.ProductSubcategory psc 
FULL OUTER JOIN production.Product pp
ON psc.ProductSubcategoryID = pp.ProductSubcategoryID


