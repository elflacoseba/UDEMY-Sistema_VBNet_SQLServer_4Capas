-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description: Desactiva una Categoría de la Base de Datos.
-- =============================================
CREATE PROCEDURE Categorias_Desactivar
	@Id INT
AS
BEGIN

UPDATE [dbo].[Categorias]
   SET [Estado] = 0
 WHERE (Id = @Id)

--SI MODIFICÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END