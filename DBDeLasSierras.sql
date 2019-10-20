CREATE DATABASE DeLasSierras
GO

USE DeLasSierras
GO

/****** Object:  Table [dbo].[Factura]    Script Date: 11/10/2019 17:30:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Factura](
	[NumeroFactura] [int] NOT NULL,
	[Fecha] [date] NULL,
	[CuitProveedor] [int] NULL,
	[NombreProveedor] [nvarchar](50) NOT NULL,
	[TotalImporte] [float] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[NumeroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Sabor](
	[IDSabor] [int] NOT NULL,
	[NombreSabor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sabor] PRIMARY KEY CLUSTERED 
(
	[IDSabor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Tipo](
	[IDTipo] [int] NULL,
	[NombreTipo] [nvarchar](50) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Rubro](
	[IDRubro] [int] NOT NULL,
	[NombreRubro] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[IDRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Proveedor](
	[NombreEmpresa] [nvarchar](50) NULL,
	[NumeroProveedor] [nvarchar](50) NULL,
	[Rubro] [nvarchar](50) NULL,
	[TelefonoVendedor] [int] NULL,
	[TelefonoRepartidor] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Producto](
	[IDProducto] [int] NOT NULL,
	[Rubro] [nvarchar](50) NULL,
	[Tipo] [nvarchar](50) NULL,
	[Marca] [nvarchar](50) NULL,
	[Detalle] [nvarchar](50) NULL,
	[Sabor] [nvarchar](50) NULL,
	[Envase] [nvarchar](50) NULL,
	[Medicion] [nvarchar](50) NULL,
	[Tamaño] [nvarchar](50) NULL,
	[PrecioCosto] [float] NULL,
	[PrecioVenta] [float] NULL,
	[StockMinimo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Marca](
	[IDMarca] [int] NULL,
	[NombreMarca] [nvarchar](50) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ItemFactura](
	[IdProducto] [int] NOT NULL,
	[NombreProducto] [nvarchar](100) NOT NULL,
	[Cantidad] [int] NULL,
	[PrecioCosto] [float] NULL,
	[Monto] [float] NOT NULL,
	[NumeroFactura] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ItemFactura]  WITH CHECK ADD FOREIGN KEY([NumeroFactura])
REFERENCES [dbo].[Factura] ([NumeroFactura])
GO

CREATE TABLE [dbo].[Envase](
	[IDEnvase] [int] NOT NULL,
	[NombreEnvase] [nvarchar](50) NULL,
 CONSTRAINT [PK_Envase] PRIMARY KEY CLUSTERED 
(
	[IDEnvase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Empleado](
	[Nombre] [nvarchar](30) NOT NULL,
	[Apellido] [nvarchar](30) NOT NULL,
	[DNI] [int] NOT NULL,
	[FechaNacimiento] [date] NULL,
	[TelefonoCelular] [nvarchar](30) NULL,
	[TelefonoFijo] [nvarchar](30) NULL,
	[Mail] [nvarchar](100) NULL,
	[FechaIngreso] [date] NULL,
	[Seccion] [nvarchar](20) NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [nvarchar](6) NULL,
	[Piso] [nvarchar](6) NULL,
	[Depto] [nvarchar](3) NULL,
	[Barrio] [nvarchar](50) NULL,
	[Localidad] [nvarchar](50) NULL,
	[Provincia] [nvarchar](30) NULL,
	[CodigoPostal] [nvarchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




CREATE TABLE [dbo].[Detalle](
	[IDDetalle] [int] NULL,
	[NombreDetalle] [nvarchar](50) NULL
) ON [PRIMARY]
GO


GO
