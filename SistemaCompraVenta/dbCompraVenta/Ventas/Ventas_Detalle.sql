CREATE TABLE [dbo].[Ventas_Detalle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VentaId] [int] NOT NULL,
	[ArticuloId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](11, 2) NOT NULL,
	[Descuento] [decimal](11, 2) NOT NULL,
 CONSTRAINT [PK_Ventas_Detalle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ventas_Detalle] ADD CONSTRAINT [FK_Ventas_Detalle_Articulos] FOREIGN KEY([ArticuloId])
REFERENCES [dbo].[Articulos] ([Id])
GO

ALTER TABLE [dbo].[Ventas_Detalle] CHECK CONSTRAINT [FK_Ventas_Detalle_Articulos]
GO

ALTER TABLE [dbo].[Ventas_Detalle] ADD  CONSTRAINT [FK_Ventas_Detalle_Ventas] FOREIGN KEY([VentaId])
REFERENCES [dbo].[Ventas] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Ventas_Detalle] CHECK CONSTRAINT [FK_Ventas_Detalle_Ventas]
GO