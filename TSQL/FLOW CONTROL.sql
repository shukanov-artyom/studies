-- простой IF...ELSE
IF OBJECT_ID('Production.Product', 'U') IS NOT NULL 
	PRINT 'Product table is here'
ELSE
	PRINT 'Product table is not present'

-- простой WHILE 
-- используем BREAK, CONTINUE
GO
DECLARE @i AS BIGINT = 0
WHILE @i < 100
	BEGIN
		IF @i = 13
			BREAK;
		SET @i += 1;
		IF @i = 11
			CONTINUE
		PRINT @i;
	END;
GO