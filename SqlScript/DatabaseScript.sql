USE [master]
GO
/****** Object:  Database [ProductionDB]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE DATABASE [ProductionDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductionDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProductionDB.mdf' , SIZE = 5312KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductionDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ProductionDB_log.ldf' , SIZE = 3520KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductionDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductionDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductionDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductionDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductionDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductionDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductionDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductionDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductionDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductionDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductionDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductionDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductionDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProductionDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductionDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductionDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductionDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductionDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductionDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProductionDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductionDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProductionDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProductionDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductionDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductionDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductionDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProductionDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductionDB', N'ON'
GO
USE [ProductionDB]
GO
/****** Object:  User [PPB\Comp-05]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE USER [PPB\Comp-05] FOR LOGIN [PPB\Comp-05] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Mostafa Elsaeed]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE USER [Mostafa Elsaeed] FOR LOGIN [PPB\Mostafa Elsaeed] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [PPB\Comp-05]
GO
ALTER ROLE [db_owner] ADD MEMBER [Mostafa Elsaeed]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[DegreeId] [int] NOT NULL,
	[ClientName] [nvarchar](max) NOT NULL,
	[UnitId] [int] NULL,
	[ClientPhoneNumber] [nvarchar](11) NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Degree]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Degree](
	[DegreeId] [int] IDENTITY(1,1) NOT NULL,
	[DegreeName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Degree] PRIMARY KEY CLUSTERED 
(
	[DegreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Material]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialCategory]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialCategory](
	[MaterialCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialCategory] PRIMARY KEY CLUSTERED 
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialReceiveOrder]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialReceiveOrder](
	[MaterialReceiveOrderId] [int] IDENTITY(1,1) NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MaterialReceiveOrder] PRIMARY KEY CLUSTERED 
(
	[MaterialReceiveOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialReceiveOrderDetails]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialReceiveOrderDetails](
	[MaterialReceiveOrderId] [int] NOT NULL,
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[MaterialTypeId] [int] NOT NULL,
	[MaterialSizeId] [int] NOT NULL,
	[UnitCostPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MaterialReceiveOrderDetails] PRIMARY KEY CLUSTERED 
(
	[MaterialReceiveOrderId] ASC,
	[MaterialCategoryId] ASC,
	[MaterialId] ASC,
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialRelease]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialRelease](
	[MaterialReleaseId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductCombinedId] [int] NULL,
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[MaterialTypeId] [int] NULL,
	[MaterialReleaseSizeId] [int] NULL,
	[OriginalQuantity] [decimal](18, 2) NOT NULL,
	[WastQuantity] [decimal](18, 2) NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[ReasonId] [int] NOT NULL,
	[ByOrderOfLeaderId] [int] NULL,
	[DepartmentId] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
	[IsAutoGenerated] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
	[ReleaseQuantity] [int] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_MaterialRelease] PRIMARY KEY CLUSTERED 
(
	[MaterialReleaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialReleaseReasons]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialReleaseReasons](
	[MaterialReleaseReasonId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialReleaseReason] [nvarchar](max) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
	[OrderRequired] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
	[IsChoosable] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
 CONSTRAINT [PK_MaterialReleaseReasons] PRIMARY KEY CLUSTERED 
(
	[MaterialReleaseReasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialSize]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialSize](
	[MaterialSizeId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialSizeName] [nvarchar](450) NOT NULL,
	[Width] [float] NOT NULL,
	[Height] [float] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialSize] PRIMARY KEY CLUSTERED 
(
	[MaterialSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialSizeAssigned]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialSizeAssigned](
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[MaterialSizeId] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialSizeAssigned] PRIMARY KEY CLUSTERED 
(
	[MaterialCategoryId] ASC,
	[MaterialId] ASC,
	[MaterialSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialSizeConversion]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialSizeConversion](
	[MaterialSizeConversionId] [int] IDENTITY(1,1) NOT NULL,
	[SmallSizeId] [int] NOT NULL,
	[BigSizeId] [int] NOT NULL,
	[NoSSizeInBSize] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialSizeConversion] PRIMARY KEY CLUSTERED 
(
	[MaterialSizeConversionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialType]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialType](
	[MaterialTypeId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialTypeName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialType] PRIMARY KEY CLUSTERED 
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MaterialTypeAssigned]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialTypeAssigned](
	[MaterialCategoryId] [int] NOT NULL,
	[MaterialId] [int] NOT NULL,
	[MaterialTypeId] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_MaterialTypeAssigned] PRIMARY KEY CLUSTERED 
(
	[MaterialCategoryId] ASC,
	[MaterialId] ASC,
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderCategoryId] [int] NOT NULL,
	[OrderNo] [int] NOT NULL,
	[UnitId] [int] NULL,
	[SpecialOrderNo] [int] NULL,
	[ClientId] [int] NULL,
	[Notes] [nvarchar](max) NULL,
	[IsReceived] [bit] NOT NULL,
	[OrderReceivedByClientId] [int] NULL,
	[OrderTotalPrice] [decimal](18, 2) NOT NULL,
	[OrderPaymentAmount] [decimal](18, 2) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderCategory]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderCategory](
	[OrderCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[OrderCategoryName] [nvarchar](450) NULL,
	[IsSpecial] [bit] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_OrderCategory] PRIMARY KEY CLUSTERED 
(
	[OrderCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderMaterialRelease]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderMaterialRelease](
	[OrderMaterialReleaseId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[MaterialReleaseId] [int] NOT NULL,
	[ProductId] [int] NULL,
	[ProductCombinedId] [int] NULL,
	[Quantity] [decimal](18, 2) NOT NULL,
	[WastQuantity] [decimal](18, 2) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderMaterialRelease] PRIMARY KEY CLUSTERED 
(
	[OrderMaterialReleaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderPayment]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPayment](
	[OrderId] [int] NOT NULL,
	[PaymentNo] [int] NOT NULL,
	[ClientId] [int] NULL,
	[PaymentAmount] [money] NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_OrderPayment] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[PaymentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[productionCycleNo] [int] NOT NULL,
	[UnitOriginalSellPrice] [money] NOT NULL,
	[UnitActualSellPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderProductCombined]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProductCombined](
	[OrderId] [int] NOT NULL,
	[ProductCombinedId] [int] NOT NULL,
	[UnitSellPriceOriginal] [money] NULL,
	[UnitSellPriceActual] [money] NULL,
	[Quantity] [int] NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_OrderProductCombined] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderProductCombinedDetails]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProductCombinedDetails](
	[OrderId] [int] NOT NULL,
	[ProductCombinedId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitSellPriceOriginal] [money] NOT NULL,
	[UnitSellPriceActual] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_OrderProductCombinedDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductCombinedId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderProductTracking]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProductTracking](
	[OrderProductTrackingId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductID] [int] NULL,
	[CombinedProductId] [int] NULL,
	[ProductProcessNo] [int] NOT NULL,
	[ProductProcessState] [nvarchar](10) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderProductTracking] PRIMARY KEY CLUSTERED 
(
	[OrderProductTrackingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderRelease]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderRelease](
	[OrderId] [int] NOT NULL,
	[OrderReleaseNo] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderRelease] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[OrderReleaseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderReleaseProduct]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderReleaseProduct](
	[OrderId] [int] NOT NULL,
	[OrderReleaseNo] [int] NOT NULL,
	[ProductId] [int] NULL,
	[CombinedProductId] [int] NULL,
	[Quantity] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderReleaseProduct] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[OrderReleaseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](450) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ProductionProcessId] [int] NOT NULL,
	[MaterialCategoryId] [int] NULL,
	[MaterialId] [int] NULL,
	[MaterialTypeId] [int] NULL,
	[MaterialSizeId] [int] NULL,
	[ReleaseSizeId] [int] NULL,
	[MaterialWastRatio] [decimal](18, 2) NULL,
	[ProductSellPrice] [money] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductCombined]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCombined](
	[ProductCombinedId] [int] IDENTITY(1,1) NOT NULL,
	[ProductCombinedName] [nvarchar](max) NOT NULL,
	[IsDetailed] [bit] NOT NULL,
	[TotalPrice] [money] NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_ProductCombined] PRIMARY KEY CLUSTERED 
(
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductCombinedDetails]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCombinedDetails](
	[ProductCombinedId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProcessNo] [int] NOT NULL,
	[Isprocess] [bit] NOT NULL,
	[IsPaid] [bit] NOT NULL,
	[IsRelease] [bit] NOT NULL,
	[UnitSellPrice] [money] NOT NULL,
	[UnitReleaseQuantity] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_ProductCombinedDetails] PRIMARY KEY CLUSTERED 
(
	[ProductCombinedId] ASC,
	[ProductId] ASC,
	[ProcessNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductionProcess]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionProcess](
	[ProductionProcessId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ProductionProcessName] [nvarchar](450) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_ProductionProcess] PRIMARY KEY CLUSTERED 
(
	[ProductionProcessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitId] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](450) NOT NULL,
	[IsSpecial] [bit] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[DegreeId] [int] NOT NULL,
	[UserDescriptiveName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](450) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
	[IsLeader] [bit] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL DEFAULT ((1)),
	[IsDeleted] [bit] NOT NULL DEFAULT ((0)),
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroupAssigned]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroupAssigned](
	[GroupId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserGroupAssigned] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserWindowsFormPermission]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserWindowsFormPermission](
	[WindowsFormId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[AddPermission] [bit] NOT NULL,
	[EditPermission] [bit] NOT NULL,
	[RemovePermission] [bit] NOT NULL,
	[PrintPermission] [bit] NOT NULL,
	[ShowPermission] [bit] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserWindowsFormPermission] PRIMARY KEY CLUSTERED 
(
	[WindowsFormId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WindowsForm]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WindowsForm](
	[WindowsFormId] [int] IDENTITY(1,1) NOT NULL,
	[WindowsFormName] [nvarchar](max) NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_WindowsForm] PRIMARY KEY CLUSTERED 
(
	[WindowsFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WindowsFormGroupAssigned]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WindowsFormGroupAssigned](
	[GroupId] [int] NOT NULL,
	[WindowsFormId] [int] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_WindowsFormGroupAssigned] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[WindowsFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WindowsFormPermissionGroup]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WindowsFormPermissionGroup](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](max) NOT NULL,
	[AddPermission] [bit] NOT NULL,
	[EditPermission] [bit] NOT NULL,
	[RemovePermission] [bit] NOT NULL,
	[PrintPermission] [bit] NOT NULL,
	[ShowPermission] [bit] NOT NULL,
	[SortNo] [int] NOT NULL,
	[IsEnabled] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedUserId] [int] NOT NULL,
	[AdditionTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_WindowsFormPermissionGroup] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Client_ClientPhoneNumber]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Client_ClientPhoneNumber] ON [dbo].[Client]
(
	[ClientPhoneNumber] ASC
)
WHERE ([ClientPhoneNumber] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Client_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Client_CreatedUserId] ON [dbo].[Client]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Client_DegreeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Client_DegreeId] ON [dbo].[Client]
(
	[DegreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Client_UnitId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Client_UnitId] ON [dbo].[Client]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Degree_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Degree_CreatedUserId] ON [dbo].[Degree]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Degree_DegreeName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Degree_DegreeName] ON [dbo].[Degree]
(
	[DegreeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Department_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Department_CreatedUserId] ON [dbo].[Department]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Department_DepartmentName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Department_DepartmentName] ON [dbo].[Department]
(
	[DepartmentName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Material_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Material_CreatedUserId] ON [dbo].[Material]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Material_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Material_MaterialCategoryId] ON [dbo].[Material]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Material_MaterialName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Material_MaterialName] ON [dbo].[Material]
(
	[MaterialName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MaterialCategory_CategoryName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MaterialCategory_CategoryName] ON [dbo].[MaterialCategory]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialCategory_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialCategory_CreatedUserId] ON [dbo].[MaterialCategory]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrder_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrder_CreatedUserId] ON [dbo].[MaterialReceiveOrder]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrderDetails_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrderDetails_CreatedUserId] ON [dbo].[MaterialReceiveOrderDetails]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrderDetails_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrderDetails_MaterialCategoryId] ON [dbo].[MaterialReceiveOrderDetails]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrderDetails_MaterialId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrderDetails_MaterialId] ON [dbo].[MaterialReceiveOrderDetails]
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrderDetails_MaterialSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrderDetails_MaterialSizeId] ON [dbo].[MaterialReceiveOrderDetails]
(
	[MaterialSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReceiveOrderDetails_MaterialTypeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReceiveOrderDetails_MaterialTypeId] ON [dbo].[MaterialReceiveOrderDetails]
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_ByOrderOfLeaderId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_ByOrderOfLeaderId] ON [dbo].[MaterialRelease]
(
	[ByOrderOfLeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_CreatedUserId] ON [dbo].[MaterialRelease]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_DepartmentId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_DepartmentId] ON [dbo].[MaterialRelease]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_MaterialCategoryId] ON [dbo].[MaterialRelease]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_MaterialId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_MaterialId] ON [dbo].[MaterialRelease]
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_MaterialReleaseSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_MaterialReleaseSizeId] ON [dbo].[MaterialRelease]
(
	[MaterialReleaseSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_MaterialTypeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_MaterialTypeId] ON [dbo].[MaterialRelease]
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_OrderId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_OrderId] ON [dbo].[MaterialRelease]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_ProductCombinedId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_ProductCombinedId] ON [dbo].[MaterialRelease]
(
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_ProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_ProductId] ON [dbo].[MaterialRelease]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialRelease_ReasonId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialRelease_ReasonId] ON [dbo].[MaterialRelease]
(
	[ReasonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialReleaseReasons_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialReleaseReasons_CreatedUserId] ON [dbo].[MaterialReleaseReasons]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSize_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSize_CreatedUserId] ON [dbo].[MaterialSize]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSize_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSize_MaterialCategoryId] ON [dbo].[MaterialSize]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MaterialSize_MaterialSizeName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MaterialSize_MaterialSizeName] ON [dbo].[MaterialSize]
(
	[MaterialSizeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSizeAssigned_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSizeAssigned_CreatedUserId] ON [dbo].[MaterialSizeAssigned]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSizeAssigned_MaterialId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSizeAssigned_MaterialId] ON [dbo].[MaterialSizeAssigned]
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSizeAssigned_MaterialSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSizeAssigned_MaterialSizeId] ON [dbo].[MaterialSizeAssigned]
(
	[MaterialSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSizeConversion_BigSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSizeConversion_BigSizeId] ON [dbo].[MaterialSizeConversion]
(
	[BigSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialSizeConversion_SmallSizeId_BigSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialSizeConversion_SmallSizeId_BigSizeId] ON [dbo].[MaterialSizeConversion]
(
	[SmallSizeId] ASC,
	[BigSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialType_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialType_CreatedUserId] ON [dbo].[MaterialType]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialType_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialType_MaterialCategoryId] ON [dbo].[MaterialType]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MaterialType_MaterialTypeName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MaterialType_MaterialTypeName] ON [dbo].[MaterialType]
(
	[MaterialTypeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialTypeAssigned_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialTypeAssigned_CreatedUserId] ON [dbo].[MaterialTypeAssigned]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialTypeAssigned_MaterialId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialTypeAssigned_MaterialId] ON [dbo].[MaterialTypeAssigned]
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MaterialTypeAssigned_MaterialTypeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_MaterialTypeAssigned_MaterialTypeId] ON [dbo].[MaterialTypeAssigned]
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_ClientId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Order_ClientId] ON [dbo].[Order]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Order_CreatedUserId] ON [dbo].[Order]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_OrderCategoryId_OrderNo]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Order_OrderCategoryId_OrderNo] ON [dbo].[Order]
(
	[OrderCategoryId] ASC,
	[OrderNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_OrderReceivedByClientId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Order_OrderReceivedByClientId] ON [dbo].[Order]
(
	[OrderReceivedByClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_UnitId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Order_UnitId] ON [dbo].[Order]
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_OrderCategory_OrderCategoryName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OrderCategory_OrderCategoryName] ON [dbo].[OrderCategory]
(
	[OrderCategoryName] ASC
)
WHERE ([OrderCategoryName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderMaterialRelease_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderMaterialRelease_CreatedUserId] ON [dbo].[OrderMaterialRelease]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderMaterialRelease_MaterialReleaseId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderMaterialRelease_MaterialReleaseId] ON [dbo].[OrderMaterialRelease]
(
	[MaterialReleaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderMaterialRelease_OrderId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OrderMaterialRelease_OrderId] ON [dbo].[OrderMaterialRelease]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderMaterialRelease_ProductCombinedId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderMaterialRelease_ProductCombinedId] ON [dbo].[OrderMaterialRelease]
(
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderMaterialRelease_ProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderMaterialRelease_ProductId] ON [dbo].[OrderMaterialRelease]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderPayment_ClientId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderPayment_ClientId] ON [dbo].[OrderPayment]
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderPayment_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderPayment_CreatedUserId] ON [dbo].[OrderPayment]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProduct_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProduct_CreatedUserId] ON [dbo].[OrderProduct]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProduct_ProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProduct_ProductId] ON [dbo].[OrderProduct]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductCombined_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductCombined_CreatedUserId] ON [dbo].[OrderProductCombined]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductCombined_ProductCombinedId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductCombined_ProductCombinedId] ON [dbo].[OrderProductCombined]
(
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductCombinedDetails_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductCombinedDetails_CreatedUserId] ON [dbo].[OrderProductCombinedDetails]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductCombinedDetails_ProductCombinedId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductCombinedDetails_ProductCombinedId] ON [dbo].[OrderProductCombinedDetails]
(
	[ProductCombinedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductCombinedDetails_ProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductCombinedDetails_ProductId] ON [dbo].[OrderProductCombinedDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductTracking_CombinedProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductTracking_CombinedProductId] ON [dbo].[OrderProductTracking]
(
	[CombinedProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductTracking_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductTracking_CreatedUserId] ON [dbo].[OrderProductTracking]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductTracking_OrderId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductTracking_OrderId] ON [dbo].[OrderProductTracking]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderProductTracking_ProductID]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderProductTracking_ProductID] ON [dbo].[OrderProductTracking]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderRelease_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderRelease_CreatedUserId] ON [dbo].[OrderRelease]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderReleaseProduct_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_OrderReleaseProduct_CreatedUserId] ON [dbo].[OrderReleaseProduct]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_DepartmentId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_DepartmentId] ON [dbo].[Product]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_MaterialCategoryId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_MaterialCategoryId] ON [dbo].[Product]
(
	[MaterialCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_MaterialId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_MaterialId] ON [dbo].[Product]
(
	[MaterialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_MaterialSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_MaterialSizeId] ON [dbo].[Product]
(
	[MaterialSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_MaterialTypeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_MaterialTypeId] ON [dbo].[Product]
(
	[MaterialTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_ProductionProcessId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_ProductionProcessId] ON [dbo].[Product]
(
	[ProductionProcessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Product_ProductName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Product_ProductName] ON [dbo].[Product]
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_ReleaseSizeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Product_ReleaseSizeId] ON [dbo].[Product]
(
	[ReleaseSizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCombined_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductCombined_CreatedUserId] ON [dbo].[ProductCombined]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCombinedDetails_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductCombinedDetails_CreatedUserId] ON [dbo].[ProductCombinedDetails]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCombinedDetails_ProductId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductCombinedDetails_ProductId] ON [dbo].[ProductCombinedDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductionProcess_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductionProcess_CreatedUserId] ON [dbo].[ProductionProcess]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductionProcess_DepartmentId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_ProductionProcess_DepartmentId] ON [dbo].[ProductionProcess]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_ProductionProcess_ProductionProcessName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_ProductionProcess_ProductionProcessName] ON [dbo].[ProductionProcess]
(
	[ProductionProcessName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Unit_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_Unit_CreatedUserId] ON [dbo].[Unit]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Unit_UnitName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Unit_UnitName] ON [dbo].[Unit]
(
	[UnitName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_DegreeId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_User_DegreeId] ON [dbo].[User]
(
	[DegreeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_User_UserName]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_User_UserName] ON [dbo].[User]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroupAssigned_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_UserGroupAssigned_CreatedUserId] ON [dbo].[UserGroupAssigned]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroupAssigned_UserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_UserGroupAssigned_UserId] ON [dbo].[UserGroupAssigned]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserWindowsFormPermission_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_UserWindowsFormPermission_CreatedUserId] ON [dbo].[UserWindowsFormPermission]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserWindowsFormPermission_UserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_UserWindowsFormPermission_UserId] ON [dbo].[UserWindowsFormPermission]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_WindowsFormGroupAssigned_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_WindowsFormGroupAssigned_CreatedUserId] ON [dbo].[WindowsFormGroupAssigned]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_WindowsFormGroupAssigned_WindowsFormId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_WindowsFormGroupAssigned_WindowsFormId] ON [dbo].[WindowsFormGroupAssigned]
(
	[WindowsFormId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_WindowsFormPermissionGroup_CreatedUserId]    Script Date: 16/07/2021 11:37:01 ص ******/
CREATE NONCLUSTERED INDEX [IX_WindowsFormPermissionGroup_CreatedUserId] ON [dbo].[WindowsFormPermissionGroup]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaterialReceiveOrder] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[MaterialReceiveOrder] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[MaterialReceiveOrder] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[OrderMaterialRelease] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[OrderMaterialRelease] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[OrderMaterialRelease] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[OrderProductTracking] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[OrderProductTracking] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[OrderProductTracking] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[OrderRelease] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[OrderRelease] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[OrderRelease] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[OrderReleaseProduct] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[OrderReleaseProduct] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[OrderReleaseProduct] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[UserGroupAssigned] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[UserGroupAssigned] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UserGroupAssigned] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[WindowsForm] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[WindowsForm] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[WindowsForm] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[WindowsFormPermissionGroup] ADD  DEFAULT ((1)) FOR [IsEnabled]
GO
ALTER TABLE [dbo].[WindowsFormPermissionGroup] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[WindowsFormPermissionGroup] ADD  DEFAULT (getdate()) FOR [AdditionTime]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Degree_DegreeId] FOREIGN KEY([DegreeId])
REFERENCES [dbo].[Degree] ([DegreeId])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Degree_DegreeId]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Unit_UnitId] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([UnitId])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Unit_UnitId]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Degree]  WITH CHECK ADD  CONSTRAINT [FK_Degree_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Degree] CHECK CONSTRAINT [FK_Degree_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialCategory]  WITH CHECK ADD  CONSTRAINT [FK_MaterialCategory_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialCategory] CHECK CONSTRAINT [FK_MaterialCategory_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrder]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrder_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrder] CHECK CONSTRAINT [FK_MaterialReceiveOrder_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_Material_MaterialId] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_Material_MaterialId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialReceiveOrder_MaterialReceiveOrderId] FOREIGN KEY([MaterialReceiveOrderId])
REFERENCES [dbo].[MaterialReceiveOrder] ([MaterialReceiveOrderId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialReceiveOrder_MaterialReceiveOrderId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialSize_MaterialSizeId] FOREIGN KEY([MaterialSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialSize_MaterialSizeId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialType_MaterialTypeId] FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialType] ([MaterialTypeId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_MaterialType_MaterialTypeId]
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReceiveOrderDetails_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialReceiveOrderDetails] CHECK CONSTRAINT [FK_MaterialReceiveOrderDetails_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_Department_DepartmentId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_Material_MaterialId] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_Material_MaterialId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_MaterialReleaseReasons_ReasonId] FOREIGN KEY([ReasonId])
REFERENCES [dbo].[MaterialReleaseReasons] ([MaterialReleaseReasonId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_MaterialReleaseReasons_ReasonId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_MaterialSize_MaterialReleaseSizeId] FOREIGN KEY([MaterialReleaseSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_MaterialSize_MaterialReleaseSizeId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_MaterialType_MaterialTypeId] FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialType] ([MaterialTypeId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_MaterialType_MaterialTypeId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_Order_OrderId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_Product_ProductId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_ProductCombined_ProductCombinedId] FOREIGN KEY([ProductCombinedId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_ProductCombined_ProductCombinedId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_User_ByOrderOfLeaderId] FOREIGN KEY([ByOrderOfLeaderId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_User_ByOrderOfLeaderId]
GO
ALTER TABLE [dbo].[MaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRelease_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialRelease] CHECK CONSTRAINT [FK_MaterialRelease_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialReleaseReasons]  WITH CHECK ADD  CONSTRAINT [FK_MaterialReleaseReasons_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialReleaseReasons] CHECK CONSTRAINT [FK_MaterialReleaseReasons_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialSize]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSize_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialSize] CHECK CONSTRAINT [FK_MaterialSize_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialSize]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSize_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialSize] CHECK CONSTRAINT [FK_MaterialSize_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialSizeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeAssigned_Material_MaterialId] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[MaterialSizeAssigned] CHECK CONSTRAINT [FK_MaterialSizeAssigned_Material_MaterialId]
GO
ALTER TABLE [dbo].[MaterialSizeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeAssigned_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialSizeAssigned] CHECK CONSTRAINT [FK_MaterialSizeAssigned_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialSizeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeAssigned_MaterialSize_MaterialSizeId] FOREIGN KEY([MaterialSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[MaterialSizeAssigned] CHECK CONSTRAINT [FK_MaterialSizeAssigned_MaterialSize_MaterialSizeId]
GO
ALTER TABLE [dbo].[MaterialSizeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeAssigned_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialSizeAssigned] CHECK CONSTRAINT [FK_MaterialSizeAssigned_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialSizeConversion]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeConversion_MaterialSize_BigSizeId] FOREIGN KEY([BigSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[MaterialSizeConversion] CHECK CONSTRAINT [FK_MaterialSizeConversion_MaterialSize_BigSizeId]
GO
ALTER TABLE [dbo].[MaterialSizeConversion]  WITH CHECK ADD  CONSTRAINT [FK_MaterialSizeConversion_MaterialSize_SmallSizeId] FOREIGN KEY([SmallSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[MaterialSizeConversion] CHECK CONSTRAINT [FK_MaterialSizeConversion_MaterialSize_SmallSizeId]
GO
ALTER TABLE [dbo].[MaterialType]  WITH CHECK ADD  CONSTRAINT [FK_MaterialType_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialType] CHECK CONSTRAINT [FK_MaterialType_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialType]  WITH CHECK ADD  CONSTRAINT [FK_MaterialType_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialType] CHECK CONSTRAINT [FK_MaterialType_User_CreatedUserId]
GO
ALTER TABLE [dbo].[MaterialTypeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTypeAssigned_Material_MaterialId] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[MaterialTypeAssigned] CHECK CONSTRAINT [FK_MaterialTypeAssigned_Material_MaterialId]
GO
ALTER TABLE [dbo].[MaterialTypeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTypeAssigned_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[MaterialTypeAssigned] CHECK CONSTRAINT [FK_MaterialTypeAssigned_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[MaterialTypeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTypeAssigned_MaterialType_MaterialTypeId] FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialType] ([MaterialTypeId])
GO
ALTER TABLE [dbo].[MaterialTypeAssigned] CHECK CONSTRAINT [FK_MaterialTypeAssigned_MaterialType_MaterialTypeId]
GO
ALTER TABLE [dbo].[MaterialTypeAssigned]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTypeAssigned_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[MaterialTypeAssigned] CHECK CONSTRAINT [FK_MaterialTypeAssigned_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client_ClientId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client_OrderReceivedByClientId] FOREIGN KEY([OrderReceivedByClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client_OrderReceivedByClientId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_OrderCategory_OrderCategoryId] FOREIGN KEY([OrderCategoryId])
REFERENCES [dbo].[OrderCategory] ([OrderCategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_OrderCategory_OrderCategoryId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Unit_UnitId] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([UnitId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Unit_UnitId]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderMaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaterialRelease_MaterialRelease_MaterialReleaseId] FOREIGN KEY([MaterialReleaseId])
REFERENCES [dbo].[MaterialRelease] ([MaterialReleaseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderMaterialRelease] CHECK CONSTRAINT [FK_OrderMaterialRelease_MaterialRelease_MaterialReleaseId]
GO
ALTER TABLE [dbo].[OrderMaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaterialRelease_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderMaterialRelease] CHECK CONSTRAINT [FK_OrderMaterialRelease_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderMaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaterialRelease_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderMaterialRelease] CHECK CONSTRAINT [FK_OrderMaterialRelease_Product_ProductId]
GO
ALTER TABLE [dbo].[OrderMaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaterialRelease_ProductCombined_ProductCombinedId] FOREIGN KEY([ProductCombinedId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
GO
ALTER TABLE [dbo].[OrderMaterialRelease] CHECK CONSTRAINT [FK_OrderMaterialRelease_ProductCombined_ProductCombinedId]
GO
ALTER TABLE [dbo].[OrderMaterialRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaterialRelease_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderMaterialRelease] CHECK CONSTRAINT [FK_OrderMaterialRelease_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderPayment]  WITH CHECK ADD  CONSTRAINT [FK_OrderPayment_Client_ClientId] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([ClientId])
GO
ALTER TABLE [dbo].[OrderPayment] CHECK CONSTRAINT [FK_OrderPayment_Client_ClientId]
GO
ALTER TABLE [dbo].[OrderPayment]  WITH CHECK ADD  CONSTRAINT [FK_OrderPayment_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderPayment] CHECK CONSTRAINT [FK_OrderPayment_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderPayment]  WITH CHECK ADD  CONSTRAINT [FK_OrderPayment_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderPayment] CHECK CONSTRAINT [FK_OrderPayment_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Product_ProductId]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderProductCombined]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombined_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProductCombined] CHECK CONSTRAINT [FK_OrderProductCombined_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderProductCombined]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombined_ProductCombined_ProductCombinedId] FOREIGN KEY([ProductCombinedId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderProductCombined] CHECK CONSTRAINT [FK_OrderProductCombined_ProductCombined_ProductCombinedId]
GO
ALTER TABLE [dbo].[OrderProductCombined]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombined_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderProductCombined] CHECK CONSTRAINT [FK_OrderProductCombined_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombinedDetails_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails] CHECK CONSTRAINT [FK_OrderProductCombinedDetails_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombinedDetails_OrderProductCombined_OrderId_ProductCombinedId] FOREIGN KEY([OrderId], [ProductCombinedId])
REFERENCES [dbo].[OrderProductCombined] ([OrderId], [ProductCombinedId])
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails] CHECK CONSTRAINT [FK_OrderProductCombinedDetails_OrderProductCombined_OrderId_ProductCombinedId]
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombinedDetails_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails] CHECK CONSTRAINT [FK_OrderProductCombinedDetails_Product_ProductId]
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombinedDetails_ProductCombined_ProductCombinedId] FOREIGN KEY([ProductCombinedId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails] CHECK CONSTRAINT [FK_OrderProductCombinedDetails_ProductCombined_ProductCombinedId]
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductCombinedDetails_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderProductCombinedDetails] CHECK CONSTRAINT [FK_OrderProductCombinedDetails_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderProductTracking]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductTracking_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProductTracking] CHECK CONSTRAINT [FK_OrderProductTracking_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderProductTracking]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductTracking_Product_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderProductTracking] CHECK CONSTRAINT [FK_OrderProductTracking_Product_ProductID]
GO
ALTER TABLE [dbo].[OrderProductTracking]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductTracking_ProductCombined_CombinedProductId] FOREIGN KEY([CombinedProductId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
GO
ALTER TABLE [dbo].[OrderProductTracking] CHECK CONSTRAINT [FK_OrderProductTracking_ProductCombined_CombinedProductId]
GO
ALTER TABLE [dbo].[OrderProductTracking]  WITH CHECK ADD  CONSTRAINT [FK_OrderProductTracking_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderProductTracking] CHECK CONSTRAINT [FK_OrderProductTracking_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderRelease_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderRelease] CHECK CONSTRAINT [FK_OrderRelease_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderRelease]  WITH CHECK ADD  CONSTRAINT [FK_OrderRelease_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderRelease] CHECK CONSTRAINT [FK_OrderRelease_User_CreatedUserId]
GO
ALTER TABLE [dbo].[OrderReleaseProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderReleaseProduct_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderReleaseProduct] CHECK CONSTRAINT [FK_OrderReleaseProduct_Order_OrderId]
GO
ALTER TABLE [dbo].[OrderReleaseProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderReleaseProduct_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[OrderReleaseProduct] CHECK CONSTRAINT [FK_OrderReleaseProduct_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Department_DepartmentId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Material_MaterialId] FOREIGN KEY([MaterialId])
REFERENCES [dbo].[Material] ([MaterialId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Material_MaterialId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_MaterialCategory_MaterialCategoryId] FOREIGN KEY([MaterialCategoryId])
REFERENCES [dbo].[MaterialCategory] ([MaterialCategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_MaterialCategory_MaterialCategoryId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_MaterialSize_MaterialSizeId] FOREIGN KEY([MaterialSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_MaterialSize_MaterialSizeId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_MaterialSize_ReleaseSizeId] FOREIGN KEY([ReleaseSizeId])
REFERENCES [dbo].[MaterialSize] ([MaterialSizeId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_MaterialSize_ReleaseSizeId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_MaterialType_MaterialTypeId] FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialType] ([MaterialTypeId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_MaterialType_MaterialTypeId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductionProcess_ProductionProcessId] FOREIGN KEY([ProductionProcessId])
REFERENCES [dbo].[ProductionProcess] ([ProductionProcessId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductionProcess_ProductionProcessId]
GO
ALTER TABLE [dbo].[ProductCombined]  WITH CHECK ADD  CONSTRAINT [FK_ProductCombined_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ProductCombined] CHECK CONSTRAINT [FK_ProductCombined_User_CreatedUserId]
GO
ALTER TABLE [dbo].[ProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductCombinedDetails_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductCombinedDetails] CHECK CONSTRAINT [FK_ProductCombinedDetails_Product_ProductId]
GO
ALTER TABLE [dbo].[ProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductCombinedDetails_ProductCombined_ProductCombinedId] FOREIGN KEY([ProductCombinedId])
REFERENCES [dbo].[ProductCombined] ([ProductCombinedId])
GO
ALTER TABLE [dbo].[ProductCombinedDetails] CHECK CONSTRAINT [FK_ProductCombinedDetails_ProductCombined_ProductCombinedId]
GO
ALTER TABLE [dbo].[ProductCombinedDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductCombinedDetails_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ProductCombinedDetails] CHECK CONSTRAINT [FK_ProductCombinedDetails_User_CreatedUserId]
GO
ALTER TABLE [dbo].[ProductionProcess]  WITH CHECK ADD  CONSTRAINT [FK_ProductionProcess_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[ProductionProcess] CHECK CONSTRAINT [FK_ProductionProcess_Department_DepartmentId]
GO
ALTER TABLE [dbo].[ProductionProcess]  WITH CHECK ADD  CONSTRAINT [FK_ProductionProcess_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ProductionProcess] CHECK CONSTRAINT [FK_ProductionProcess_User_CreatedUserId]
GO
ALTER TABLE [dbo].[Unit]  WITH CHECK ADD  CONSTRAINT [FK_Unit_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Unit] CHECK CONSTRAINT [FK_Unit_User_CreatedUserId]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Degree_DegreeId] FOREIGN KEY([DegreeId])
REFERENCES [dbo].[Degree] ([DegreeId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Degree_DegreeId]
GO
ALTER TABLE [dbo].[UserGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupAssigned_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserGroupAssigned] CHECK CONSTRAINT [FK_UserGroupAssigned_User_CreatedUserId]
GO
ALTER TABLE [dbo].[UserGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupAssigned_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserGroupAssigned] CHECK CONSTRAINT [FK_UserGroupAssigned_User_UserId]
GO
ALTER TABLE [dbo].[UserGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupAssigned_WindowsFormPermissionGroup_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[WindowsFormPermissionGroup] ([GroupId])
GO
ALTER TABLE [dbo].[UserGroupAssigned] CHECK CONSTRAINT [FK_UserGroupAssigned_WindowsFormPermissionGroup_GroupId]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission]  WITH CHECK ADD  CONSTRAINT [FK_UserWindowsFormPermission_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] CHECK CONSTRAINT [FK_UserWindowsFormPermission_User_CreatedUserId]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission]  WITH CHECK ADD  CONSTRAINT [FK_UserWindowsFormPermission_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] CHECK CONSTRAINT [FK_UserWindowsFormPermission_User_UserId]
GO
ALTER TABLE [dbo].[UserWindowsFormPermission]  WITH CHECK ADD  CONSTRAINT [FK_UserWindowsFormPermission_WindowsForm_WindowsFormId] FOREIGN KEY([WindowsFormId])
REFERENCES [dbo].[WindowsForm] ([WindowsFormId])
GO
ALTER TABLE [dbo].[UserWindowsFormPermission] CHECK CONSTRAINT [FK_UserWindowsFormPermission_WindowsForm_WindowsFormId]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_WindowsFormGroupAssigned_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] CHECK CONSTRAINT [FK_WindowsFormGroupAssigned_User_CreatedUserId]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_WindowsFormGroupAssigned_WindowsForm_WindowsFormId] FOREIGN KEY([WindowsFormId])
REFERENCES [dbo].[WindowsForm] ([WindowsFormId])
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] CHECK CONSTRAINT [FK_WindowsFormGroupAssigned_WindowsForm_WindowsFormId]
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned]  WITH CHECK ADD  CONSTRAINT [FK_WindowsFormGroupAssigned_WindowsFormPermissionGroup_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[WindowsFormPermissionGroup] ([GroupId])
GO
ALTER TABLE [dbo].[WindowsFormGroupAssigned] CHECK CONSTRAINT [FK_WindowsFormGroupAssigned_WindowsFormPermissionGroup_GroupId]
GO
ALTER TABLE [dbo].[WindowsFormPermissionGroup]  WITH CHECK ADD  CONSTRAINT [FK_WindowsFormPermissionGroup_User_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[WindowsFormPermissionGroup] CHECK CONSTRAINT [FK_WindowsFormPermissionGroup_User_CreatedUserId]
GO
/****** Object:  StoredProcedure [dbo].[GetAnnualReport]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAnnualReport] @fromYear int,@toYear int
AS 
DECLARE @year int = @fromYear
CREATE TABLE #ReportTable
(
   "Year" int,
   "TotalSales" decimal default 0
)
WHILE @year <= @toYear
BEGIN
	 insert into #ReportTable
	  SELECT
	  @year,
      COALESCE(SUM(OrderTotalPrice),0) as "TotalSales"
  FROM [ProductionDB].[dbo].[Order]
  where YEAR([AdditionTime]) = @year
      AND IsDeleted = 0 AND IsEnabled = 1
    group by YEAR([AdditionTime])
     order by YEAR([AdditionTime])
	 
	
	 SET @year = @year + 1
	 END
SELECT
  *
FROM #ReportTable

GO
/****** Object:  StoredProcedure [dbo].[GetSalesReport]    Script Date: 16/07/2021 11:37:01 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetSalesReport] @year int
AS 
declare @month int
set @month = 1
CREATE TABLE #ReportTable
(
   "Month" int,
   "TotalSales" decimal default 0
)
WHILE @month <= 12
BEGIN
	 insert into #ReportTable
	  SELECT
	  @month,
      COALESCE(SUM(OrderTotalPrice),0) as "TotalSales"
  FROM [ProductionDB].[dbo].[Order]
  where YEAR([AdditionTime]) = @year AND MONTH([AdditionTime]) = @month
      AND IsDeleted = 0 AND IsEnabled = 1
    group by YEAR([AdditionTime]),MONTH([AdditionTime])
     order by YEAR([AdditionTime]),MONTH([AdditionTime])
	 
	
	 SET @month = @month + 1
	 END
SELECT
  *
FROM #ReportTable

GO
USE [master]
GO
ALTER DATABASE [ProductionDB] SET  READ_WRITE 
GO
