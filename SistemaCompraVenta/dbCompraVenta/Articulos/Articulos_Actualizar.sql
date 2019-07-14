-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Actualiza un Artículo de la base de datos.
-- =============================================
CREATE PROCEDURE Articulos_Actualizar
	@ArticuloID int,
	@CategoriaId int,
    @Codigo varchar(50),
    @Nombre varchar(100),
    @Precio_Venta decimal(11,2),
    @Stock int,
    @Descripcion varchar(255),
    @Imagen varchar(255)
AS
BEGIN

UPDATE [dbo].[Articulos]
   SET [CategoriaId] = @CategoriaId
      ,[Codigo] = @Codigo
      ,[Nombre] = @Nombre
      ,[Precio_Venta] = @Precio_Venta
      ,[Stock] = @Stock
      ,[Descripcion] = @Descripcion
      ,[Imagen] = @Imagen
 WHERE (Id = @ArticuloID)

--SI MODIFICÓ UNA FILA RETORNO 1, SINO RETORNO 0
IF (@@ROWCOUNT = 1)
	RETURN 1
ELSE
	RETURN 0

END