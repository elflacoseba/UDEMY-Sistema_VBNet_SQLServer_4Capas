-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description:	Lista las categorías
-- =============================================
CREATE PROCEDURE Categorias_Listar
AS
BEGIN

  SELECT [Id]
        ,[Nombre]
        ,[Descripcion]
        ,[Estado]
  FROM [dbo].[Categorias]
  ORDER BY Nombre

  RETURN 0
END