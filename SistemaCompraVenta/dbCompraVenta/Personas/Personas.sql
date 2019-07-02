CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Persona] [tinyint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Tipo_Documento] [tinyint] NULL,
	[Numero_Documento] [varchar](20) NULL,
	[Direccion] [varchar](255) NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_Tipo_Documento]  DEFAULT ((0)) FOR [Tipo_Documento]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_Numero_Documento]  DEFAULT ('') FOR [Numero_Documento]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_Direccion]  DEFAULT ('') FOR [Direccion]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_Telefono]  DEFAULT ('') FOR [Telefono]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_Email]  DEFAULT ('') FOR [Email]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [CK_Personas_Tipo_Documento] CHECK  (([Tipo_Documento]=(2) OR [Tipo_Documento]=(1) OR [Tipo_Documento]=(0)))
GO

ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [CK_Personas_Tipo_Documento]
GO

ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [CK_Personas_Tipo_Persona] CHECK  (([Tipo_Persona]=(1) OR [Tipo_Persona]=(0)))
GO

ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [CK_Personas_Tipo_Persona]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CLIENTES - PROVEEDORES' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'Nombre'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valida los posibles valores del campo Tipo_Documento:
No_especifíca = 0
DNI = 1
Pasaporte = 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'CONSTRAINT',@level2name=N'CK_Personas_Tipo_Documento'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valida los valores para el Tipo_Persona:
Cliente = 0
Proveedor = 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'CONSTRAINT',@level2name=N'CK_Personas_Tipo_Persona'
GO