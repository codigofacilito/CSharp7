CREATE TABLE [Clientes](
	[idCliente] [int] NOT NULL,
	[NombreCompleto] [nvarchar](300) NULL,
	[Clave] [nvarchar](30) NULL,
	[RFC] [nvarchar](300) NULL,
	[Tipo] [int] NULL,
 CONSTRAINT [pk_clientes_id] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
CREATE TABLE [Productos](
	[idProducto] [int] NOT NULL,
	[Clave] [varchar](30) NOT NULL,
	[CodigoBarras] [varchar](20) NULL DEFAULT (NULL),
	[Descripcion] [varchar](200) NULL DEFAULT (NULL),
	[Precio1] [float] NULL DEFAULT (NULL),
	[Precio2] [float] NULL DEFAULT (NULL),
	[Precio3] [float] NULL DEFAULT (NULL),
	[PorcentajeIva] [float] NULL DEFAULT (NULL),
	[Ieps] [float] NULL,
	[EsMontoIeps] [int] NULL,
 CONSTRAINT [pk_Productos_id] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
CREATE TABLE [Pedidos](
	[idPedido] [int] NOT NULL,
	[idCliente] [int] NULL,
	[Fecha] [datetime] NULL,
	[Subtotal] [float] NULL,
	[MontoIva] [float] NULL,
	[MontoIeps] [float] NULL,
	[Total] [float] NULL,
 CONSTRAINT [pk_PedidosCLientes_id] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
go
CREATE TABLE [DetallePedidos](
	[idProducto] [int] NOT NULL,
	[idPedido] [int] NOT NULL,
	[NumeroFilas] [int] NULL,
	[Cantidad] [int] NULL,
	[PrecioSinIvaSinIeps] [float] NULL,
	[Subtotal] [float] NULL,
	[MontoIva] [float] NULL,
	[MontoIeps] [float] NULL,
	[Total] [float] NULL,
) ON [PRIMARY]
go
