-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description: Inserta una nueva Categoría en la base de datos.
-- =============================================
CREATE PROCEDURE Categorias_Insertar
	@Nombre VARCHAR(50),
	@Descripcion VARCHAR(255)
AS
BEGIN

INSERT INTO [dbo].[Categorias]
           ([Nombre]
           ,[Descripcion])
     VALUES
           (@Nombre
           ,@Descripcion)

--SI INSTERTÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END