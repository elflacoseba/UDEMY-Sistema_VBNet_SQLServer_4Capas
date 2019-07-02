CREATE TABLE [dbo].[Ventas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Tipo_Comprobante] [tinyint] NOT NULL,
	[Serie_Comprobante] [varchar](7) NULL,
	[Numero_Comprobante] [varchar](10) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Impuesto] [decimal](4, 2) NOT NULL,
	[Total] [decimal](11, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [DF_Ventas_Serie_Comprobante]  DEFAULT ('') FOR [Serie_Comprobante]
GO

ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [DF_Ventas_Estado]  DEFAULT ((1)) FOR [Estado]
GO

ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [FK_Ventas_Personas] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas] ([Id])
GO

ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Personas]
GO

ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([Id])
GO