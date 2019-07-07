-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description: Elimina una Categoría de la Base de Datos.
-- =============================================
CREATE PROCEDURE Categorias_Eliminar
	@Id INT
AS
BEGIN

DELETE FROM [dbo].[Categorias]
      WHERE (Id = @Id)

--SI ELIMINÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END