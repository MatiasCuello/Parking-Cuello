USE [ParkingCuello]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](30) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](12) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentasCorrientes]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentasCorrientes](
	[CtaCteId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Debe] [decimal](18, 2) NOT NULL,
	[Haber] [decimal](18, 2) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_CuentasCorrientes] PRIMARY KEY CLUSTERED 
(
	[CtaCteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVehiculos]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVehiculos](
	[DetalleVehiculoId] [int] NOT NULL,
	[VehiculoId] [int] NOT NULL,
	[TarifaId] [int] NOT NULL,
	[TiempoId] [int] NOT NULL,
	[FechaHoraEgreso] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugares]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugares](
	[LugarId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](5) NOT NULL,
	[SectorId] [int] NULL,
	[Disponible] [bit] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Lugares] PRIMARY KEY CLUSTERED 
(
	[LugarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[MarcaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](30) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[MarcaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectores]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectores](
	[SectorId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NOT NULL,
	[LugaresDisponibles] [int] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Sectores] PRIMARY KEY CLUSTERED 
(
	[SectorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifas]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifas](
	[TarifaId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](100) NOT NULL,
	[TipoVehiculoId] [int] NOT NULL,
	[TiempoId] [int] NOT NULL,
	[Importe] [decimal](18, 2) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Tarifas] PRIMARY KEY CLUSTERED 
(
	[TarifaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tiempos]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiempos](
	[TiempoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](30) NOT NULL,
	[Detalle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tiempo] PRIMARY KEY CLUSTERED 
(
	[TiempoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposVehiculos]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposVehiculos](
	[TipoVehiculoId] [int] NOT NULL,
	[Descripcion] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Auto] PRIMARY KEY CLUSTERED 
(
	[TipoVehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[VehiculoId] [int] IDENTITY(1,1) NOT NULL,
	[FechaHoraIngreso] [datetime] NOT NULL,
	[Patente] [nvarchar](10) NOT NULL,
	[TipoVehiculoId] [int] NOT NULL,
	[SectorId] [int] NOT NULL,
	[LugarId] [int] NOT NULL,
	[Estacionado] [bit] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[VehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehiculosAbonados]    Script Date: 23/11/2022 18:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiculosAbonados](
	[VehiculoAbonadoId] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[TipoVehiculoId] [int] NOT NULL,
	[MarcaId] [int] NOT NULL,
	[Modelo] [nvarchar](20) NOT NULL,
	[Patente] [nvarchar](10) NOT NULL,
	[SectorId] [int] NOT NULL,
	[TarifaId] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_ClientesAsociados] PRIMARY KEY CLUSTERED 
(
	[VehiculoAbonadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lugares] ADD  CONSTRAINT [DF_Lugares_Disponible]  DEFAULT ((1)) FOR [Disponible]
GO
ALTER TABLE [dbo].[Tarifas] ADD  CONSTRAINT [DF_Tarifas_Importe]  DEFAULT ((0)) FOR [Importe]
GO
ALTER TABLE [dbo].[CuentasCorrientes]  WITH CHECK ADD  CONSTRAINT [FK_CuentasCorrientes_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[CuentasCorrientes] CHECK CONSTRAINT [FK_CuentasCorrientes_Clientes]
GO
ALTER TABLE [dbo].[DetalleVehiculos]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVehiculos_Tarifas] FOREIGN KEY([TarifaId])
REFERENCES [dbo].[Tarifas] ([TarifaId])
GO
ALTER TABLE [dbo].[DetalleVehiculos] CHECK CONSTRAINT [FK_DetalleVehiculos_Tarifas]
GO
ALTER TABLE [dbo].[DetalleVehiculos]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVehiculos_Tiempos] FOREIGN KEY([TiempoId])
REFERENCES [dbo].[Tiempos] ([TiempoId])
GO
ALTER TABLE [dbo].[DetalleVehiculos] CHECK CONSTRAINT [FK_DetalleVehiculos_Tiempos]
GO
ALTER TABLE [dbo].[DetalleVehiculos]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVehiculos_Vehiculos] FOREIGN KEY([VehiculoId])
REFERENCES [dbo].[Vehiculos] ([VehiculoId])
GO
ALTER TABLE [dbo].[DetalleVehiculos] CHECK CONSTRAINT [FK_DetalleVehiculos_Vehiculos]
GO
ALTER TABLE [dbo].[Lugares]  WITH CHECK ADD  CONSTRAINT [FK_Lugares_Sectores] FOREIGN KEY([SectorId])
REFERENCES [dbo].[Sectores] ([SectorId])
GO
ALTER TABLE [dbo].[Lugares] CHECK CONSTRAINT [FK_Lugares_Sectores]
GO
ALTER TABLE [dbo].[Tarifas]  WITH CHECK ADD  CONSTRAINT [FK_Tarifas_Tiempo] FOREIGN KEY([TiempoId])
REFERENCES [dbo].[Tiempos] ([TiempoId])
GO
ALTER TABLE [dbo].[Tarifas] CHECK CONSTRAINT [FK_Tarifas_Tiempo]
GO
ALTER TABLE [dbo].[Tarifas]  WITH CHECK ADD  CONSTRAINT [FK_Tarifas_TiposVehiculos] FOREIGN KEY([TipoVehiculoId])
REFERENCES [dbo].[TiposVehiculos] ([TipoVehiculoId])
GO
ALTER TABLE [dbo].[Tarifas] CHECK CONSTRAINT [FK_Tarifas_TiposVehiculos]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Lugares] FOREIGN KEY([LugarId])
REFERENCES [dbo].[Lugares] ([LugarId])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Lugares]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Sectores] FOREIGN KEY([SectorId])
REFERENCES [dbo].[Sectores] ([SectorId])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Sectores]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_TiposVehiculos] FOREIGN KEY([TipoVehiculoId])
REFERENCES [dbo].[TiposVehiculos] ([TipoVehiculoId])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_TiposVehiculos]
GO
ALTER TABLE [dbo].[VehiculosAbonados]  WITH CHECK ADD  CONSTRAINT [FK_ClientesAsociados_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[VehiculosAbonados] CHECK CONSTRAINT [FK_ClientesAsociados_Clientes]
GO
ALTER TABLE [dbo].[VehiculosAbonados]  WITH CHECK ADD  CONSTRAINT [FK_ClientesAsociados_Sectores] FOREIGN KEY([SectorId])
REFERENCES [dbo].[Sectores] ([SectorId])
GO
ALTER TABLE [dbo].[VehiculosAbonados] CHECK CONSTRAINT [FK_ClientesAsociados_Sectores]
GO
ALTER TABLE [dbo].[VehiculosAbonados]  WITH CHECK ADD  CONSTRAINT [FK_ClientesAsociados_Tarifas] FOREIGN KEY([TarifaId])
REFERENCES [dbo].[Tarifas] ([TarifaId])
GO
ALTER TABLE [dbo].[VehiculosAbonados] CHECK CONSTRAINT [FK_ClientesAsociados_Tarifas]
GO
ALTER TABLE [dbo].[VehiculosAbonados]  WITH CHECK ADD  CONSTRAINT [FK_ClientesAsociados_Vehiculos] FOREIGN KEY([TipoVehiculoId])
REFERENCES [dbo].[TiposVehiculos] ([TipoVehiculoId])
GO
ALTER TABLE [dbo].[VehiculosAbonados] CHECK CONSTRAINT [FK_ClientesAsociados_Vehiculos]
GO
ALTER TABLE [dbo].[VehiculosAbonados]  WITH CHECK ADD  CONSTRAINT [FK_VehiculosRegistrados_Marcas] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marcas] ([MarcaId])
GO
ALTER TABLE [dbo].[VehiculosAbonados] CHECK CONSTRAINT [FK_VehiculosRegistrados_Marcas]
GO
