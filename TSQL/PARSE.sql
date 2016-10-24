USE AdventureWorks2016CTP3;

-- Parses correct
SELECT PARSE('01-02-2013' AS DATETIME USING('en-US'));

-- Parses incorrect!!
SELECT PARSE('01-02-2013' AS DATETIME USING('be-BY')); 

-- Parses correct
SELECT PARSE('2013-01-02' AS DATETIME USING('ru-RU'));

-- Parses correct
SELECT PARSE('2013-01-02' AS DATETIME USING('be-BY'));

-- Throws exception
SELECT PARSE('UserName' AS DATETIME USING('be-BY'));

-- Returns NULL instead of throwing
SELECT TRY_PARSE('UserName' AS DATETIME USING('sv-SE'));

-- Usage example
-- Nothing will be selected
SELECT  emp.Name FROM Production.Culture AS emp 
WHERE TRY_PARSE(emp.Name AS DATETIME USING 'en-US') IS NOT NULL;

-- Using FORMAT for backwards transformation