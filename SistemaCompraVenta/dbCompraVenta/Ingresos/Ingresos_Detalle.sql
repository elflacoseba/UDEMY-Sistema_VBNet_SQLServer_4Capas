CREATE TABLE [dbo].[Ingresos_Detalle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IngresoId] [int] NOT NULL,
	[ArticuloId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](11, 2) NOT NULL,
 CONSTRAINT [PK_Ingresos_Detalle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ingresos_Detalle] ADD  CONSTRAINT [FK_Ingresos_Detalle_Articulos] FOREIGN KEY([ArticuloId])
REFERENCES [dbo].[Articulos] ([Id])
GO

ALTER TABLE [dbo].[Ingresos_Detalle] CHECK CONSTRAINT [FK_Ingresos_Detalle_Articulos]
GO

ALTER TABLE [dbo].[Ingresos_Detalle] ADD  CONSTRAINT [FK_Ingresos_Detalle_Ingresos] FOREIGN KEY([IngresoId])
REFERENCES [dbo].[Ingresos] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Ingresos_Detalle] CHECK CONSTRAINT [FK_Ingresos_Detalle_Ingresos]
GO