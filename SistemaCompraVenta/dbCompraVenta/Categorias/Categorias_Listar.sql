-- =============================================
-- Author:		Sebastián Serrisuela
-- Create date: 07/07/2019
-- Description:	Lista las categorías
-- =============================================
CREATE PROCEDURE Categorias_Listar
@TipoEstado CHAR(1)
AS
BEGIN

  SELECT [Id]
        ,[Nombre]
        ,[Descripcion]
        ,[Estado]
  FROM [dbo].[Categorias]
  WHERE (Estado <>  CASE @TipoEstado
						WHEN 'A' THEN 0
						WHEN 'I' THEN 1
						ELSE -1
					END)							
  ORDER BY Nombre

  RETURN 0
END