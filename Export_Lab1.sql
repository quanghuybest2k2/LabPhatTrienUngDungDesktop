USE [master]
GO
/****** Object:  Database [RestaurantManagement]    Script Date: 5/9/2022 5:03:07 PM ******/
CREATE DATABASE [RestaurantManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RestaurantManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RestaurantManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RestaurantManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RestaurantManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RestaurantManagement] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RestaurantManagement] SET QUERY_STORE = OFF
GO
USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NULL,
	[FullName] [nvarchar](1000) NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[TableID] [int] NULL,
	[Amount] [int] NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NULL,
	[CheckOutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillsDetails]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillsDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[invoiceID] [int] NULL,
	[FoodID] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Unit] [nvarchar](100) NULL,
	[FoodCategoryID] [int] NULL,
	[Price] [int] NULL,
	[Notes] [nvarchar](3000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NULL,
	[Notes] [nvarchar](3000) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NULL,
	[Capacity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Table]
GO
ALTER TABLE [dbo].[BillsDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillsDetails_Bills] FOREIGN KEY([invoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillsDetails] CHECK CONSTRAINT [FK_BillsDetails_Bills]
GO
ALTER TABLE [dbo].[BillsDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillsDetails_Food] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillsDetails] CHECK CONSTRAINT [FK_BillsDetails_Food]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_Category] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_Category]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO
/****** Object:  StoredProcedure [dbo].[Category_Delete]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Category_Delete]
@ID int
as
begin
	delete from Category where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[Category_GetAll]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Category_GetAll]
As
begin
	select * from Category
end
GO
/****** Object:  StoredProcedure [dbo].[Category_GetByID]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Category_GetByID]
@id int
as
begin
	select * from Category where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Category_Insert]
@Name nvarchar(1000),
@Type int
as
begin
	if(not exists (select [Name] from Category where [Name] = @Name))
		insert into Category (Name, Type)
		Values (@Name, @Type)
end
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Category_Update]
@ID int, @Name nvarchar(1000), @Type int
as
begin
	update Category set [Name] = @Name, [Type] = @Type where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[Table_GetAll]    Script Date: 5/9/2022 5:03:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Table_GetAll]
As
begin
	select * from [Table]
end
GO
USE [master]
GO
ALTER DATABASE [RestaurantManagement] SET  READ_WRITE 
GO
