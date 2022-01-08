USE [master]
GO
/****** Object:  Database [khothuoctay]    Script Date: 07/01/2022 11:11:09 CH ******/
CREATE DATABASE [khothuoctay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'khothuoctay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\khothuoctay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'khothuoctay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\khothuoctay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [khothuoctay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [khothuoctay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [khothuoctay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [khothuoctay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [khothuoctay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [khothuoctay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [khothuoctay] SET ARITHABORT OFF 
GO
ALTER DATABASE [khothuoctay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [khothuoctay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [khothuoctay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [khothuoctay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [khothuoctay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [khothuoctay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [khothuoctay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [khothuoctay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [khothuoctay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [khothuoctay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [khothuoctay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [khothuoctay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [khothuoctay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [khothuoctay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [khothuoctay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [khothuoctay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [khothuoctay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [khothuoctay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [khothuoctay] SET  MULTI_USER 
GO
ALTER DATABASE [khothuoctay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [khothuoctay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [khothuoctay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [khothuoctay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [khothuoctay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [khothuoctay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [khothuoctay] SET QUERY_STORE = OFF
GO
USE [khothuoctay]
GO
/****** Object:  Table [dbo].[loaithuoc]    Script Date: 07/01/2022 11:11:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaithuoc](
	[maloaithuoc] [int] IDENTITY(1,1) NOT NULL,
	[tenloaithuoc] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_loaithuoc] PRIMARY KEY CLUSTERED 
(
	[maloaithuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thuoc]    Script Date: 07/01/2022 11:11:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thuoc](
	[mathuoc] [int] IDENTITY(1,1) NOT NULL,
	[tenthuoc] [nvarchar](255) NOT NULL,
	[noisanxuat] [nvarchar](255) NOT NULL,
	[ngaysanxuat] [date] NOT NULL,
	[hansudung] [date] NOT NULL,
	[maloaithuoc] [int] NOT NULL,
	[nhacungcap] [nvarchar](255) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[donvitinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_thuoc] PRIMARY KEY CLUSTERED 
(
	[mathuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_thuoc]    Script Date: 07/01/2022 11:11:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_thuoc] as
SELECT       ROW_NUMBER() OVER (ORDER BY mathuoc) AS [sothutu],   dbo.thuoc.mathuoc, dbo.thuoc.tenthuoc, dbo.thuoc.noisanxuat, dbo.thuoc.ngaysanxuat, dbo.thuoc.hansudung, dbo.thuoc.nhacungcap, dbo.thuoc.soluong, dbo.thuoc.dongia, dbo.thuoc.donvitinh, dbo.loaithuoc.tenloaithuoc
FROM            dbo.thuoc INNER JOIN
                         dbo.loaithuoc ON dbo.thuoc.maloaithuoc = dbo.loaithuoc.maloaithuoc
GO
/****** Object:  View [dbo].[view_loaithuoc]    Script Date: 07/01/2022 11:11:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_loaithuoc] as
select ROW_NUMBER() OVER (ORDER BY maloaithuoc) AS [sothutu], *
from loaithuoc
GO
SET IDENTITY_INSERT [dbo].[loaithuoc] ON 

INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (1, N'Thuốc gây mê')
INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (2, N'Thuốc giảm đau')
INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (3, N'Thuốc chống dị ứng')
INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (4, N'Thuốc giải độc')
INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (5, N'Thuốc da liễu')
INSERT [dbo].[loaithuoc] ([maloaithuoc], [tenloaithuoc]) VALUES (6, N'Thuốc kháng sinh')
SET IDENTITY_INSERT [dbo].[loaithuoc] OFF
GO
SET IDENTITY_INSERT [dbo].[thuoc] ON 

INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (1, N'Halothane', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 1, N'AVC', 3, 20000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (3, N'Isoflurane', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 1, N'AVC', 3, 20000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (4, N'Nitơ oxit', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 1, N'AVC', 3, 30000, N'Chai')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (7, N'Paracetamol', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 2, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (8, N'Aspirin', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 2, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (9, N'Morphine', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 2, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (10, N'Telfast BD', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 3, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (11, N'Zyrtec', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 3, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (12, N'Piperacilin', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 6, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (13, N'Meropenem', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 6, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (14, N'Penicillin V potassium', N'ABC', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 6, N'AVC', 3, 50000, N'Vỉ')
INSERT [dbo].[thuoc] ([mathuoc], [tenthuoc], [noisanxuat], [ngaysanxuat], [hansudung], [maloaithuoc], [nhacungcap], [soluong], [dongia], [donvitinh]) VALUES (17, N'abc', N'abc', CAST(N'2021-01-01' AS Date), CAST(N'2022-11-11' AS Date), 6, N'abc', 123, 23, N'abc')
SET IDENTITY_INSERT [dbo].[thuoc] OFF
GO
ALTER TABLE [dbo].[thuoc]  WITH CHECK ADD  CONSTRAINT [FK_thuoc_loaithuoc1] FOREIGN KEY([maloaithuoc])
REFERENCES [dbo].[loaithuoc] ([maloaithuoc])
GO
ALTER TABLE [dbo].[thuoc] CHECK CONSTRAINT [FK_thuoc_loaithuoc1]
GO
USE [master]
GO
ALTER DATABASE [khothuoctay] SET  READ_WRITE 
GO
