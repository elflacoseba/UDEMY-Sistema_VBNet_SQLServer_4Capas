CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RolId] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Tipo_Documento] [tinyint] NULL,
	[Numero_Documento] [varchar](20) NULL,
	[Direccion] [varchar](255) NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Clave] [varbinary](max) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Tipo_Documento]  DEFAULT ((0)) FOR [Tipo_Documento]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Numero_Documento]  DEFAULT ('') FOR [Numero_Documento]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Direccion]  DEFAULT ('') FOR [Direccion]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Telefono]  DEFAULT ('') FOR [Telefono]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Email]  DEFAULT ('') FOR [Email]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_Estado]  DEFAULT ((1)) FOR [Estado]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [FK_Usuarios_Roles] FOREIGN KEY([RolId])
REFERENCES [dbo].[Roles] ([Id])
GO

ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Roles]
GO

ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [CK_Usuarios_Tipo_Documento] CHECK  (([Tipo_Documento]=(2) OR [Tipo_Documento]=(1) OR [Tipo_Documento]=(0)))
GO

ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CK_Usuarios_Tipo_Documento]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valida los valores para el campo Tipo_Documento:
No especifíca = 0
DNI = 1
Pasaporte = 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios', @level2type=N'CONSTRAINT',@level2name=N'CK_Usuarios_Tipo_Documento'
GO