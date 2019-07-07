-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description: Modifica los datos de una nueva Categoría.
-- =============================================
CREATE PROCEDURE Categorias_Actualizar
	@Id INT,
	@Nombre VARCHAR(50),
	@Descripcion VARCHAR(255)
AS
BEGIN

UPDATE [dbo].[Categorias]
   SET [Nombre] = @Nombre
      ,[Descripcion] = @Descripcion      
 WHERE (Id = @Id)

--SI MODIFICÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END