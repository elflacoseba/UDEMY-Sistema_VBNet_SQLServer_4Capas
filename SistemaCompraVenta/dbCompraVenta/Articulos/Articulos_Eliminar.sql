-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Elimina un Artículo de la base de datos.
-- =============================================
CREATE PROCEDURE Articulos_Eliminar
	@ArticuloID int
AS
BEGIN

DELETE FROM [dbo].[Articulos]
      WHERE Id = @ArticuloID

--SI ELIMINÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END