-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Desactiva un Artículo de la base de datos.
-- =============================================
CREATE PROCEDURE Articulos_Desactivar
	@ArticuloID int
AS
BEGIN

UPDATE [dbo].[Articulos]
SET Estado = 0
WHERE Id = @ArticuloID

--SI DESACTIVÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END