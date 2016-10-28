-- TRY .. CATCH
-- сразу скажем, что не все ошибки могут быть пойманы!

-- Бросается объект типа ERROR
/* Его свойства:
	Number ERROR_NUMBER()
	Message ERROR_MESSAGE()
	Severity ERROR_SEVERITY
	Procedure Name ERROR_PROCEDURE()
	Line number ERROR_LINE()
*/

-- примеры использования
BEGIN TRY
	SELECT 1 / 0;
END TRY
BEGIN CATCH
	SELECT 
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH;
GO


