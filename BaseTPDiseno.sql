
/****** Object:  Table [dbo].[DetalleExposicion]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleExposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdExposicion] [int] NOT NULL,
	[IdObra] [int] NULL,
 CONSTRAINT [PK_DetalleExposicion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaVenta] [smalldatetime] NULL,
	[HoraVenta] [varchar](250) NULL,
	[Monto] [decimal](18, 2) NULL,
	[Numero] [nvarchar](250) NULL,
 CONSTRAINT [PK_Entrada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exposicion]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaFin] [smalldatetime] NULL,
	[FechaFinReplanificacion] [smalldatetime] NULL,
	[FechaInicio] [smalldatetime] NULL,
	[FechaInicioReplanificacion] [smalldatetime] NULL,
	[HoraApertura] [varchar](50) NULL,
	[HoraCierra] [varchar](50) NULL,
	[Nombre] [varchar](250) NULL,
	[IdSede] [int] NULL,
 CONSTRAINT [PK_Exposicion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obra]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Alto] [decimal](18, 2) NULL,
	[Ancho] [decimal](18, 2) NULL,
	[CodigoSensor] [nvarchar](250) NULL,
	[Descripcion] [nvarchar](250) NULL,
	[DuracionExtendida] [int] NULL,
	[DuracionResumida] [int] NULL,
	[FechaCreacion] [smalldatetime] NULL,
	[FechaPrimeroIngreso] [smalldatetime] NULL,
	[NombreObra] [nvarchar](250) NULL,
	[Peso] [decimal](18, 2) NULL,
	[Valuacion] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Obra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservaVisita]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservaVisita](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CantidadDeAlumnos] [int] NULL,
	[CantidadDeAlumnosAConfirmar] [int] NULL,
	[DuracionEstimada] [nvarchar](250) NULL,
	[FechaHoraCreacion] [smalldatetime] NULL,
	[FechaHoraReserva] [smalldatetime] NULL,
	[HoraFinReal] [nvarchar](50) NULL,
	[HoraInicioReal] [nvarchar](50) NULL,
	[NumeroReserva] [nvarchar](50) NULL,
 CONSTRAINT [PK_ReservaVisita] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[CantMaxPorGuia] [int] NULL,
	[CantMaximaVisitantes] [int] NULL,
 CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifa]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [smalldatetime] NULL,
	[FechaInicioVigencia] [smalldatetime] NULL,
	[Monto] [decimal](18, 2) NULL,
	[MontoAdicionalGuia] [decimal](18, 2) NULL,
	[IdSede] [int] NULL,
	[IdTipoEntrada] [int] NULL,
	[IdTipoVisita] [int] NULL,
 CONSTRAINT [PK_Tarifa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEntrada]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEntrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
 CONSTRAINT [PK_TipoEntrada] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoVisita]    Script Date: 15/6/2021 17:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVisita](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
 CONSTRAINT [PK_TipoVisita] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleExposicion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleExposicion_] FOREIGN KEY([IdObra])
REFERENCES [dbo].[Obra] ([Id])
GO
ALTER TABLE [dbo].[DetalleExposicion] CHECK CONSTRAINT [FK_DetalleExposicion_]
GO
ALTER TABLE [dbo].[DetalleExposicion]  WITH CHECK ADD  CONSTRAINT [FK_DetalleExposicion_DetalleExposicion] FOREIGN KEY([Id])
REFERENCES [dbo].[DetalleExposicion] ([Id])
GO
ALTER TABLE [dbo].[DetalleExposicion] CHECK CONSTRAINT [FK_DetalleExposicion_DetalleExposicion]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [FK_Exposicion_Sede] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [FK_Exposicion_Sede]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_Sede] FOREIGN KEY([IdSede])
REFERENCES [dbo].[Sede] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_Sede]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_TipoEntrada] FOREIGN KEY([IdTipoEntrada])
REFERENCES [dbo].[TipoEntrada] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_TipoEntrada]
GO
ALTER TABLE [dbo].[Tarifa]  WITH CHECK ADD  CONSTRAINT [FK_Tarifa_TipoVisita] FOREIGN KEY([IdTipoVisita])
REFERENCES [dbo].[TipoVisita] ([Id])
GO
ALTER TABLE [dbo].[Tarifa] CHECK CONSTRAINT [FK_Tarifa_TipoVisita]
GO
