-- простой OUTPUT на удалении
-- выводит все только что удалёные кортежи.

DELETE dbo.Products 
OUTPUT DELETED.*
WHERE ProductId = 3 

-- вывод идентификаторов только что обновлённых значений
-- защита от фантомных строк, вставленных между двумя твоими запросами, идущими подряд!
UPDATE dbo.Products
	SET [Name] = '_addition'
	OUTPUT 
		INSERTED.ProductId,
		INSERTED.[Name]
WHERE productId = 4