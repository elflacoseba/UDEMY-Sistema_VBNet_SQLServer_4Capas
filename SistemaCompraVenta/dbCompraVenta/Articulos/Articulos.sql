CREATE TABLE [dbo].[Articulos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Precio_Venta] [decimal](11, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[Descripcion] [varchar](255) NULL,
	[Imagen] [varchar](255) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Articulos] ADD  CONSTRAINT [DF_Articulos_Codigo]  DEFAULT ('') FOR [Codigo]
GO

ALTER TABLE [dbo].[Articulos] ADD  CONSTRAINT [DF_Articulos_Descripcion]  DEFAULT ('') FOR [Descripcion]
GO

ALTER TABLE [dbo].[Articulos] ADD  CONSTRAINT [DF_Articulos_Imagen]  DEFAULT ('') FOR [Imagen]
GO

ALTER TABLE [dbo].[Articulos] ADD  CONSTRAINT [DF_Articulos_Estado]  DEFAULT ((1)) FOR [Estado]
GO

ALTER TABLE [dbo].[Articulos] ADD  CONSTRAINT [FK_Articulos_Categorias] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categorias] ([Id])
GO

ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Categorias]
GO