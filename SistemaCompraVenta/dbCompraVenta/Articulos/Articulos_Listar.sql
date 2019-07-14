-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 14/07/2019
-- Description:	Muestra un listado de los Artículos.
-- =============================================
CREATE PROCEDURE Articulos_Listar
AS
BEGIN

SELECT	 A.Id AS ArticuloID, C.Id AS CategoriaID, C.Nombre AS CategoriaNombre
		,A.Codigo AS ArticuloCodigo, A.Nombre AS ArticuloNombre, a.Precio_Venta AS ArticuloPrecioVenta
		,A.Stock AS ArticuloStock, A.Descripcion AS ArticuloDescripcion, A.Estado AS ArticuloEstado
  FROM [dbo].[Articulos] AS A INNER JOIN
  [dbo].[Categorias] AS C ON C.Id = A.CategoriaId 
  ORDER BY A.Nombre ASC

  RETURN 0
END