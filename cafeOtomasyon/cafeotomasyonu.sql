USE [master]
GO
/****** Object:  Database [cafeeotomasyonu]    Script Date: 30.05.2021 17:10:53 ******/
CREATE DATABASE [cafeeotomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cafeeotomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cafeeotomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cafeeotomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cafeeotomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cafeeotomasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cafeeotomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cafeeotomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cafeeotomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cafeeotomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cafeeotomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cafeeotomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cafeeotomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [cafeeotomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cafeeotomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cafeeotomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cafeeotomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cafeeotomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cafeeotomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cafeeotomasyonu] SET QUERY_STORE = OFF
GO
USE [cafeeotomasyonu]
GO
/****** Object:  Table [dbo].[cariler]    Script Date: 30.05.2021 17:10:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cariler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tarih] [nvarchar](350) NULL,
	[toplam] [nvarchar](350) NULL,
 CONSTRAINT [PK_carilerim] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanicilar]    Script Date: 30.05.2021 17:10:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanicilar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciadi] [varchar](350) NULL,
	[sifre] [varchar](350) NULL,
	[yetki] [nvarchar](50) NULL,
 CONSTRAINT [PK_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[masalar]    Script Date: 30.05.2021 17:10:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[masalar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adi] [nvarchar](350) NULL,
	[tutar] [nvarchar](350) NULL,
 CONSTRAINT [PK_masalar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urunler]    Script Date: 30.05.2021 17:10:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[urunadi] [nvarchar](350) NULL,
	[fiyati] [int] NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cariler] ON 

INSERT [dbo].[cariler] ([id], [tarih], [toplam]) VALUES (1, N'30 Mayıs 2021 Pazar', N'31088')
SET IDENTITY_INSERT [dbo].[cariler] OFF
GO
SET IDENTITY_INSERT [dbo].[kullanicilar] ON 

INSERT [dbo].[kullanicilar] ([id], [kullaniciadi], [sifre], [yetki]) VALUES (1, N'admin', N'12345', N'yönetici')
INSERT [dbo].[kullanicilar] ([id], [kullaniciadi], [sifre], [yetki]) VALUES (3, N'personel', N'12345', N'personel')
INSERT [dbo].[kullanicilar] ([id], [kullaniciadi], [sifre], [yetki]) VALUES (7, N'süveyda', N'12345', N'yönetici')
INSERT [dbo].[kullanicilar] ([id], [kullaniciadi], [sifre], [yetki]) VALUES (9, N'admin 2', N'12345', N'personel')
SET IDENTITY_INSERT [dbo].[kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[masalar] ON 

INSERT [dbo].[masalar] ([id], [adi], [tutar]) VALUES (3, N'Masa 3', N'0')
INSERT [dbo].[masalar] ([id], [adi], [tutar]) VALUES (4, N'Lobi Masa 1', N'0')
INSERT [dbo].[masalar] ([id], [adi], [tutar]) VALUES (5, N'Lobi Masa 2', N'0')
INSERT [dbo].[masalar] ([id], [adi], [tutar]) VALUES (14, N'lobi 9', N'0')
SET IDENTITY_INSERT [dbo].[masalar] OFF
GO
SET IDENTITY_INSERT [dbo].[urunler] ON 

INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (21, N'türk kahvesi', 12)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (22, N'menengiç kahvesi', 18)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (23, N'yaş pasta', 16)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (24, N'yeşil çay', 10)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (26, N'soğuk kahve', 20)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (29, N'dondurma', 5)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (31, N'şeker pare', 14)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (32, N'külahta dondurma', 3)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (35, N'çay ', 6)
INSERT [dbo].[urunler] ([id], [urunadi], [fiyati]) VALUES (38, N'kahve', 7)
SET IDENTITY_INSERT [dbo].[urunler] OFF
GO
USE [master]
GO
ALTER DATABASE [cafeeotomasyonu] SET  READ_WRITE 
GO
