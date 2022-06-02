create database RestaurantManagement
go
use RestaurantManagement
go

CREATE TABLE [Table]
(
	ID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(1000),
	[Status] INT,
	Capacity INT
)
go

create table Category
(
	ID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(1000),
	[Type] INT
)
go

CREATE TABLE Bills
(
	ID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(1000),
	TableID INT,
	Amount INT,
	Discount FLOAT,
	Tax FLOAT,
	[Status] BIT,
	CheckOutDate SMALLDATETIME,
	Account NVARCHAR(100)
)
go

CREATE TABLE Food
(
	ID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(1000),
	Unit NVARCHAR(100),
	FoodCategoryID INT,
	Price INT,
	Notes NVARCHAR(3000)
)
go

CREATE TABLE BillsDetails
(
	ID INT IDENTITY PRIMARY KEY,
	invoiceID INT,
	FoodID INT,
	Quantity INT
)
go
---- Các bảng phân quyền
CREATE TABLE Role
(
	ID INT IDENTITY PRIMARY KEY,
	RoleName NVARCHAR(1000),
	[Path] NVARCHAR(3000),
	Notes NVARCHAR(3000)
)
go
CREATE TABLE Account
(
	AccountName	NVARCHAR(100) PRIMARY KEY,
	[Password] NVARCHAR(200),
	FullName NVARCHAR(1000),
	Email NVARCHAR(1000),
	Tell NVARCHAR(200),
	DateCreated SMALLDATETIME
)
go
CREATE TABLE RoleAccount
(
	RoleID INT IDENTITY,
	AccountName NVARCHAR(100),
	Actived BIT,
	Notes NVARCHAR(3000),
	PRIMARY KEY(RoleID, AccountName)
)
go
---- truy van
select * from [Table]
