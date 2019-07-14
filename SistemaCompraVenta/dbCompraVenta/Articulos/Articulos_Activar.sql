-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Activa un Artículo de la base de datos.
-- =============================================
CREATE PROCEDURE Articulos_Activar
	@ArticuloID int
AS
BEGIN

UPDATE [dbo].[Articulos]
SET Estado = 1
WHERE Id = @ArticuloID

--SI ACTIVÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END