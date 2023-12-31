USE [master]
GO
/****** Object:  Database [DB_Library]    Script Date: 06/06/2022 07:33:13 ******/
CREATE DATABASE [DB_Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_Library] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Library] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_Library] SET QUERY_STORE = OFF
GO
USE [DB_Library]
GO
/****** Object:  Table [dbo].[TBL_Buku]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Buku](
	[BookID] [varchar](10) NOT NULL,
	[BookTitle] [varchar](50) NULL,
	[BookAuthor] [varchar](50) NULL,
	[BookType] [varchar](50) NULL,
	[ShelfID] [varchar](7) NULL,
	[BookStatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Rent]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Rent](
	[RentID] [varchar](30) NOT NULL,
	[UserID] [varchar](15) NOT NULL,
	[RentStatus] [varchar](1) NULL,
	[RentDate] [date] NULL,
	[RentDueDate] [date] NULL,
	[RentLateFee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_RentDetail]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_RentDetail](
	[RentID] [varchar](30) NOT NULL,
	[BookID] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RentID] ASC,
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Shelf]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Shelf](
	[ShelfID] [varchar](7) NOT NULL,
	[ShelfLocation] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShelfID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_User]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_User](
	[UserID] [varchar](15) NOT NULL,
	[UserTypeID] [varchar](7) NULL,
	[UserName] [varchar](50) NULL,
	[UserAddress] [varchar](50) NULL,
	[UserPhone] [varchar](50) NULL,
	[UserPassword] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_UserType]    Script Date: 06/06/2022 07:33:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_UserType](
	[UserTypeID] [varchar](7) NOT NULL,
	[UserTypeName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'1', N'Buku Satu', N'L', N'Pengetahuan', N'1', 0)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'10', N'10 Cara Membuka Docx', N'Y1', N'Guide', N'5', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'2', N'Buku Dua', N'Penulis', N'Pengetahuan', N'1', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'3', N'Buku Tiga', N'AAuthor', N'Penelitian', N'2', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'4', N'Buku Empat', N'Penulis', N'Ensiklopedia', N'1', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'5', N'Buku Lima', N'Triple A', N'Penelitian', N'4', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'6', N'Kamus Bahasa Inggris', N'Author K', N'Kamus', N'3', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'7', N'Kamus Bahasa Indonesia', N'Author K', N'Kamus', N'3', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'8', N'Ensiklopedia', N'Penulis', N'Ensiklopedia', N'4', 1)
INSERT [dbo].[TBL_Buku] ([BookID], [BookTitle], [BookAuthor], [BookType], [ShelfID], [BookStatus]) VALUES (N'9', N'Jurnal Penelitian', N'Jurnalis', N'Jurnal', N'1', 1)
GO
INSERT [dbo].[TBL_Rent] ([RentID], [UserID], [RentStatus], [RentDate], [RentDueDate], [RentLateFee]) VALUES (N'0', N'001', N'0', CAST(N'2022-05-25' AS Date), CAST(N'2022-05-26' AS Date), 0)
INSERT [dbo].[TBL_Rent] ([RentID], [UserID], [RentStatus], [RentDate], [RentDueDate], [RentLateFee]) VALUES (N'1', N'001', N'0', CAST(N'2022-05-25' AS Date), CAST(N'2022-05-26' AS Date), 0)
INSERT [dbo].[TBL_Rent] ([RentID], [UserID], [RentStatus], [RentDate], [RentDueDate], [RentLateFee]) VALUES (N'2', N'002', N'0', CAST(N'2022-05-25' AS Date), CAST(N'2022-05-26' AS Date), 0)
INSERT [dbo].[TBL_Rent] ([RentID], [UserID], [RentStatus], [RentDate], [RentDueDate], [RentLateFee]) VALUES (N'3', N'002', N'1', CAST(N'2022-05-25' AS Date), CAST(N'2022-05-26' AS Date), 0)
INSERT [dbo].[TBL_Rent] ([RentID], [UserID], [RentStatus], [RentDate], [RentDueDate], [RentLateFee]) VALUES (N'4', N'001', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'0', N'1')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'1', N'2')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'1', N'3')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'2', N'2')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'2', N'3')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'2', N'5')
INSERT [dbo].[TBL_RentDetail] ([RentID], [BookID]) VALUES (N'3', N'1')
GO
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'1', N'Rak 1A')
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'2', N'Rak 1B')
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'3', N'Rak 1C')
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'4', N'Rak 1D')
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'5', N'Rak 2A')
INSERT [dbo].[TBL_Shelf] ([ShelfID], [ShelfLocation]) VALUES (N'6', N'Rak 2B')
GO
INSERT [dbo].[TBL_User] ([UserID], [UserTypeID], [UserName], [UserAddress], [UserPhone], [UserPassword]) VALUES (N'001', N'1', N'Admin', N'Indonesia', N'081233448678', N'admin')
INSERT [dbo].[TBL_User] ([UserID], [UserTypeID], [UserName], [UserAddress], [UserPhone], [UserPassword]) VALUES (N'002', N'2', N'Dosen', N'Indonesia', N'081212346342', N'dosen')
INSERT [dbo].[TBL_User] ([UserID], [UserTypeID], [UserName], [UserAddress], [UserPhone], [UserPassword]) VALUES (N'003', N'3', N'Mahasiswa', N'Indonesia', N'081267889090', N'mahasiswa')
INSERT [dbo].[TBL_User] ([UserID], [UserTypeID], [UserName], [UserAddress], [UserPhone], [UserPassword]) VALUES (N'004', N'2', N'Dosen', N'Indonesia', N'097456753456', N'univ')
GO
INSERT [dbo].[TBL_UserType] ([UserTypeID], [UserTypeName]) VALUES (N'1', N'admin')
INSERT [dbo].[TBL_UserType] ([UserTypeID], [UserTypeName]) VALUES (N'2', N'dosen')
INSERT [dbo].[TBL_UserType] ([UserTypeID], [UserTypeName]) VALUES (N'3', N'mahasiswa')
GO
ALTER TABLE [dbo].[TBL_Buku]  WITH CHECK ADD FOREIGN KEY([ShelfID])
REFERENCES [dbo].[TBL_Shelf] ([ShelfID])
GO
ALTER TABLE [dbo].[TBL_Rent]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[TBL_User] ([UserID])
GO
ALTER TABLE [dbo].[TBL_RentDetail]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[TBL_Buku] ([BookID])
GO
ALTER TABLE [dbo].[TBL_RentDetail]  WITH CHECK ADD FOREIGN KEY([RentID])
REFERENCES [dbo].[TBL_Rent] ([RentID])
GO
ALTER TABLE [dbo].[TBL_User]  WITH CHECK ADD FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[TBL_UserType] ([UserTypeID])
GO
USE [master]
GO
ALTER DATABASE [DB_Library] SET  READ_WRITE 
GO
