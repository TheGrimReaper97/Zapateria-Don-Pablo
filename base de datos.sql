USE [master]
GO
/****** Object:  Database [db_ventas]    Script Date: 26/08/2020 09:55:03 ******/
CREATE DATABASE [db_ventas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_ventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_ventas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_ventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_ventas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_ventas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_ventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_ventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_ventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_ventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_ventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_ventas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_ventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_ventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_ventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_ventas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_ventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_ventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_ventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_ventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_ventas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_ventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_ventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_ventas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_ventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_ventas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_ventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_ventas] SET RECOVERY FULL 
GO
ALTER DATABASE [db_ventas] SET  MULTI_USER 
GO
ALTER DATABASE [db_ventas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_ventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_ventas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_ventas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_ventas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_ventas', N'ON'
GO
ALTER DATABASE [db_ventas] SET QUERY_STORE = OFF
GO
USE [db_ventas]
GO
/****** Object:  Table [dbo].[detallaventa]    Script Date: 26/08/2020 09:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallaventa](
	[idProductofk] [int] NULL,
	[Cantidad] [int] NULL,
	[Costo] [float] NULL,
	[idVentasfk] [varchar](45) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 26/08/2020 09:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[id_usuario] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Nombre] VARCHAR (50) NULL,
	[Usuario] VARCHAR (50) NULL, 
	[Password] VARCHAR(50) NULL,
	[Tipo_usuario] VARCHAR(50)NULL

	)

	select * from Usuarios

	insert into Usuarios values ('Gerson Lopez', 'glopez', '123', 'Admin'),
	                            ('Katherine Vila', 'kvila', '123', 'Usuario');

CREATE TABLE [dbo].[producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](60) NULL,
	[Precio] [float] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK__producto__DC53BE3C2067706C] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 26/08/2020 09:55:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[ventas](
	[idventas] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [varchar](45) NULL,
	[Costo] [float] NULL,
 CONSTRAINT [PK__ventas__54AB6C8A769930E1] PRIMARY KEY CLUSTERED 
(
	[idventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detallaventa] ADD  DEFAULT (NULL) FOR [idVentasfk]
GO
USE [master]
GO
ALTER DATABASE [db_ventas] SET  READ_WRITE 
GO
