-- найти все колонки во всех таблицах текущей базы, тип кторых FLOAT

SELECT 
	*
FROM sys.columns 
WHERE system_type_id = (
	SELECT system_type_id FROM sys.types WHERE [Name] = 'Real'
)

