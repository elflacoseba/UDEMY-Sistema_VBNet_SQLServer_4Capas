-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Inserta un nuevo Artículo en la base de datos.
-- =============================================
CREATE PROCEDURE Articulos_Insertar
	@CategoriaId int,
    @Codigo varchar(50),
    @Nombre varchar(100),
    @Precio_Venta decimal(11,2),
    @Stock int,
    @Descripcion varchar(255),
    @Imagen varchar(255)
AS
BEGIN

INSERT INTO [dbo].[Articulos]
           ([CategoriaId]
           ,[Codigo]
           ,[Nombre]
           ,[Precio_Venta]
           ,[Stock]
           ,[Descripcion]
           ,[Imagen])
     VALUES
           (@CategoriaID
           ,@Codigo
           ,@Nombre
           ,@Precio_Venta
           ,@Stock
           ,@Descripcion
           ,@Imagen)

  RETURN @@ERROR
END