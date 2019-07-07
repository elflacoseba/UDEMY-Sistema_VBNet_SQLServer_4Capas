-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description:	Busca en el nombre y en la descripción de las categorías
-- =============================================
CREATE PROCEDURE Categorias_Buscar
	@Valor VARCHAR(50)
AS
BEGIN

SELECT [Id]
      ,[Nombre]
      ,[Descripcion]
      ,[Estado]
  FROM [dbo].[Categorias]
  WHERE (Nombre LIKE '%' + @Valor + '%') OR (Descripcion LIKE '%' + @Valor + '%')
  ORDER BY Nombre

  RETURN 0
END