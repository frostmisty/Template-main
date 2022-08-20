USE [master]
GO
/****** Object:  Database [Template]    Script Date: 20/08/2022 12.33.20 ******/
CREATE DATABASE [Template]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Template', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Template.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Template_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Template_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Template] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Template].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Template] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Template] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Template] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Template] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Template] SET ARITHABORT OFF 
GO
ALTER DATABASE [Template] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Template] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Template] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Template] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Template] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Template] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Template] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Template] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Template] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Template] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Template] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Template] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Template] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Template] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Template] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Template] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Template] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Template] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Template] SET  MULTI_USER 
GO
ALTER DATABASE [Template] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Template] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Template] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Template] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Template] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Template] SET QUERY_STORE = OFF
GO
USE [Template]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20/08/2022 12.33.20 ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsEnumItem]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsEnumItem](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemCategory] [nvarchar](50) NULL,
	[Sequence] [int] NULL,
	[ItemValue] [nvarchar](50) NULL,
	[ItemDesc] [nvarchar](100) NULL,
	[ParentId] [nvarchar](50) NULL,
	[Remark] [nvarchar](250) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsEnumItem] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsMenu]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsMenu](
	[MenuId] [nvarchar](450) NOT NULL,
	[ModuleId] [nvarchar](10) NOT NULL,
	[PageId] [nvarchar](10) NOT NULL,
	[ParentId] [nvarchar](max) NULL,
	[Seq] [int] NULL,
	[MenuText] [nvarchar](50) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsMenu] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsModule]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsModule](
	[ModuleId] [nvarchar](10) NOT NULL,
	[ModuleDesc] [nvarchar](50) NOT NULL,
	[Info1] [nvarchar](max) NULL,
	[Info2] [nvarchar](max) NULL,
	[Info3] [nvarchar](max) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsModule] PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsPage]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsPage](
	[ModuleId] [nvarchar](10) NOT NULL,
	[PageId] [nvarchar](10) NOT NULL,
	[PageName] [nvarchar](100) NOT NULL,
	[PageDesc] [nvarchar](100) NULL,
	[PageIcon] [nvarchar](100) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsPage] PRIMARY KEY CLUSTERED 
(
	[PageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsPermission]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsPermission](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionDesc] [nvarchar](100) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsPermission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsUser]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsUser](
	[ModuleId] [nvarchar](10) NOT NULL,
	[UserId] [nvarchar](10) NOT NULL,
	[UserRoleId] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Info1] [nvarchar](max) NULL,
	[Info2] [nvarchar](max) NULL,
	[Info3] [nvarchar](max) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_MsUser] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[ModuleId] ASC,
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsUserRole]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsUserRole](
	[ModuleId] [nvarchar](10) NOT NULL,
	[UserRoleId] [nvarchar](50) NOT NULL,
	[UserRoleDesc] [nvarchar](100) NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsUserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MsUserRoleAccess]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MsUserRoleAccess](
	[AccessID] [int] IDENTITY(1,1) NOT NULL,
	[UserRoleId] [nvarchar](50) NOT NULL,
	[PageId] [nvarchar](10) NOT NULL,
	[Permission] [nvarchar](200) NOT NULL,
	[CrtUsrId] [nvarchar](25) NOT NULL,
	[TsCrt] [datetime2](7) NOT NULL,
	[ModUsrId] [nvarchar](25) NULL,
	[TsMod] [datetime2](7) NULL,
	[ActiveFlag] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_MsUserRoleAccess] PRIMARY KEY CLUSTERED 
(
	[AccessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220607022905_firstmigration', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220608004345_secondmigration', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220608010914_thirdmigration', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220609032817_fourthmigration', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220611071333_migrasikeenam', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220612081441_addpasswordmigration', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220625072408_fifthmigration', N'6.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220716071041_Migrasiketujuh', N'6.0.6')
GO
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0000', N'M0001', N'P0000', NULL, 1, N'Home', N'admin', CAST(N'2022-06-11T14:26:23.5400000' AS DateTime2), N'admin', CAST(N'2022-06-11T14:26:23.5400000' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0001', N'M0001', N'P0001', N'NH001', 1, N'Master Module', N'admin', CAST(N'2022-06-11T14:26:23.6500000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:23.6500000' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0002', N'M0001', N'P0002', N'NH001', 2, N'Master Page', N'admin', CAST(N'2022-06-11T14:26:23.7300000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:23.7300000' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0003', N'M0001', N'P0003', N'NH001', 4, N'Master User Role', N'admin', CAST(N'2022-06-11T14:26:23.8066667' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:23.8066667' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0004', N'M0001', N'P0004', N'NH001', 5, N'Master User Role Access', N'admin', CAST(N'2022-06-11T14:26:24.1200000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:24.1200000' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0005', N'M0001', N'P0005', N'NH001', 3, N'Master Menu', N'admin', CAST(N'2022-06-11T14:26:24.4633333' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:24.4633333' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0006', N'M0001', N'P0006', N'NH001', 6, N'Master User', N'admin', CAST(N'2022-06-11T14:26:24.8066667' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:24.8066667' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0007', N'M0001', N'P0007', N'NH001', 7, N'Master Enum Items', N'admin', CAST(N'2022-06-11T14:26:25.1500000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:25.1500000' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'N0008', N'M0001', N'P0008', N'NH001', 8, N'Master Permssion', N'admin', CAST(N'2022-06-11T14:26:25.5133333' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:25.5133333' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'NH001', N'M0001', N'P9001', NULL, 1, N'Administrator', N'admin', CAST(N'2022-06-11T14:26:25.9033333' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:25.9033333' AS DateTime2), N'Y')
INSERT [dbo].[MsMenu] ([MenuId], [ModuleId], [PageId], [ParentId], [Seq], [MenuText], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'NH002', N'M0001', N'P9002', NULL, 1, N'Master Data', N'admin', CAST(N'2022-06-11T14:26:26.4033333' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T14:26:26.4033333' AS DateTime2), N'Y')
GO
INSERT [dbo].[MsModule] ([ModuleId], [ModuleDesc], [Info1], [Info2], [Info3], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'Template', NULL, NULL, NULL, N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:24:18.8633333' AS DateTime2), N'Y')
GO
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0000', N'/Home', N'Master', N'fa-home', N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:26:03.3766667' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0001', N'MsModule', N'Module', NULL, N'SYSTEM', CAST(N'2022-06-11T12:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T12:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0002', N'MsPage', N'Page', NULL, N'SYSTEM', CAST(N'2022-06-11T12:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T12:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0003', N'MsUserRole', N'User Role', NULL, N'SYSTEM', CAST(N'2022-06-11T14:26:04.4366667' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:26:04.4366667' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0004', N'MsUserRoleAccess', N'User Role Access', NULL, N'SYSTEM', CAST(N'2022-06-11T14:26:04.7800000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:26:04.7800000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0005', N'MsMenu', N'Menu', NULL, N'SYSTEM', CAST(N'2022-06-11T14:26:05.1100000' AS DateTime2), N'SYSTEM', CAST(N'2022-07-11T21:58:36.3391551' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0006', N'MsUser', N'User', NULL, N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0007', N'MsEnumItem', N'Master Enum Items', NULL, N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P0008', N'MsPermission', N'Master Permission', NULL, N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPage] ([ModuleId], [PageId], [PageName], [PageDesc], [PageIcon], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'P9001', N'#', N'Administrator', N'fa-home', N'SYSTEM', CAST(N'2022-06-11T05:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:26:06.5333333' AS DateTime2), N'Y')
GO
SET IDENTITY_INSERT [dbo].[MsPermission] ON 

INSERT [dbo].[MsPermission] ([PermissionID], [PermissionDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (1, N'VIEW', N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPermission] ([PermissionID], [PermissionDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (2, N'CREATE', N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPermission] ([PermissionID], [PermissionDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (3, N'UPDATE', N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsPermission] ([PermissionID], [PermissionDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (4, N'DELETE', N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), NULL, CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'Y')
SET IDENTITY_INSERT [dbo].[MsPermission] OFF
GO
INSERT [dbo].[MsUser] ([ModuleId], [UserId], [UserRoleId], [Area], [FullName], [Email], [Info1], [Info2], [Info3], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag], [Password]) VALUES (N'M0001', N'01135702', N'SYSADMIN', NULL, N'NURDIANSYAH SAPUTRA', N'NURDIANSYAH_sAPUTRA@APP.CO.ID', NULL, NULL, NULL, N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T00:00:00.0000000' AS DateTime2), N'Y', NULL)
GO
INSERT [dbo].[MsUserRole] ([ModuleId], [UserRoleId], [UserRoleDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'SUPERUSER TBMS', N'SUPERUSER TREE BREEDING', N'ssimamor', CAST(N'2022-06-11T14:27:05.2833333' AS DateTime2), N'ssimamor', NULL, N'Y')
INSERT [dbo].[MsUserRole] ([ModuleId], [UserRoleId], [UserRoleDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'SUPERUSER TREE BREED', N'SUPERUSER TREE BREEDING', N'ssimamor', CAST(N'2022-06-11T14:27:05.3166667' AS DateTime2), N'ssimamor', NULL, N'N')
INSERT [dbo].[MsUserRole] ([ModuleId], [UserRoleId], [UserRoleDesc], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (N'M0001', N'SYSADMIN', N'SYSADMIN', N'SYSTEM', CAST(N'2022-06-11T23:20:02.0000000' AS DateTime2), N'fsimanju', NULL, N'Y')
GO
SET IDENTITY_INSERT [dbo].[MsUserRoleAccess] ON 

INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (1, N'SYSADMIN', N'P0000', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T14:23:37.9500000' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:23:37.9500000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (2, N'SYSADMIN', N'P0001', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:04.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:04.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (3, N'SYSADMIN', N'P0002', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:04.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:04.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (4, N'SYSADMIN', N'P0003', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (5, N'SYSADMIN', N'P0004', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (6, N'SYSADMIN', N'P0005', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:05.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (7, N'SYSADMIN', N'P0006', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (8, N'SYSADMIN', N'P0007', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (9, N'SYSADMIN', N'P0008', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'fsimanju', CAST(N'2022-06-11T09:12:06.0000000' AS DateTime2), N'Y')
INSERT [dbo].[MsUserRoleAccess] ([AccessID], [UserRoleId], [PageId], [Permission], [CrtUsrId], [TsCrt], [ModUsrId], [TsMod], [ActiveFlag]) VALUES (10, N'SYSADMIN', N'P9001', N'View,Insert,Update,Delete', N'SYSTEM', CAST(N'2022-06-11T14:23:41.2533333' AS DateTime2), N'SYSTEM', CAST(N'2022-06-11T14:23:41.2533333' AS DateTime2), N'Y')
SET IDENTITY_INSERT [dbo].[MsUserRoleAccess] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 20/08/2022 12.33.20 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 20/08/2022 12.33.20 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 20/08/2022 12.33.20 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 20/08/2022 12.33.20 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 20/08/2022 12.33.20 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 20/08/2022 12.33.20 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 20/08/2022 12.33.20 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MsEnumItem] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsEnumItem] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsEnumItem] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsMenu] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsMenu] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsMenu] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsModule] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsModule] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsModule] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsPage] ADD  CONSTRAINT [DF__MsPage__TsCrt__59FA5E80]  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsPage] ADD  CONSTRAINT [DF__MsPage__TsMod__5AEE82B9]  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsPage] ADD  CONSTRAINT [DF__MsPage__ActiveFl__5BE2A6F2]  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsPermission] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsPermission] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsPermission] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsUser] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsUser] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsUser] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsUserRole] ADD  CONSTRAINT [DF__MsUserRol__TsCrt__68487DD7]  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsUserRole] ADD  CONSTRAINT [DF__MsUserRol__Activ__693CA210]  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[MsUserRoleAccess] ADD  DEFAULT (getdate()) FOR [TsCrt]
GO
ALTER TABLE [dbo].[MsUserRoleAccess] ADD  DEFAULT (getdate()) FOR [TsMod]
GO
ALTER TABLE [dbo].[MsUserRoleAccess] ADD  DEFAULT (N'Y') FOR [ActiveFlag]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[GetMenu]    Script Date: 20/08/2022 12.33.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 

-- =============================================

-- Author:           <Author,,Name>

-- Create date: <Create Date,,>

-- Description:      <Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[GetMenu]

(
       @UserID varchar(30)='',
       @UserRoleID varchar(40)='',
	   @Posisi varchar(30)=''
)

AS
BEGIN
       -- SET NOCOUNT ON added to prevent extra result sets from
       -- interfering with SELECT statements.
       SET NOCOUNT ON;
    -- Insert statements for procedure here
	if(@Posisi = 'Header')
	begin
       select b.PageId,c.ParentId,c.MenuId,b.PageIcon,b.PageName,c.MenuText,c.Seq from MsUserRoleAccess a
       left join MsPage b on a.PageId = b.PageId and a.ActiveFlag = 'Y' and b.ActiveFlag = 'Y'
       inner join MsMenu c on b.PageId = c.PageId and c.ActiveFlag = 'Y'
       inner join MsUser d on d.UserRoleId = a.UserRoleId and d.ActiveFlag = 'Y'
       where d.UserId = @UserID and c.ParentId is null and d.UserRoleId like '%'+ @UserRoleID +'%'
       order by c.MenuId,c.ParentId,c.Seq
	end
	else
	begin
		select b.PageId,c.ParentId,c.MenuId,b.PageIcon,b.PageName,c.MenuText,c.Seq from MsUserRoleAccess a
       left join MsPage b on a.PageId = b.PageId and a.ActiveFlag = 'Y' and b.ActiveFlag = 'Y'
       inner join MsMenu c on b.PageId = c.PageId and c.ActiveFlag = 'Y'
       inner join MsUser d on d.UserRoleId = a.UserRoleId and d.ActiveFlag = 'Y'
       where d.UserId = @UserID and c.ParentId is not null and d.UserRoleId like '%'+ @UserRoleID +'%'
       order by c.MenuId,c.ParentId,c.Seq
	end


END

GO
USE [master]
GO
ALTER DATABASE [Template] SET  READ_WRITE 
GO
