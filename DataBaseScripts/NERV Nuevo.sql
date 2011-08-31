USE [master]
GO
/****** Object:  Database [NERV]    Script Date: 08/30/2011 18:33:02 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'NERV')
BEGIN
CREATE DATABASE [NERV] ON  PRIMARY 
( NAME = N'NERV', FILENAME = N'D:\DATABASE\NERV.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NERV_log', FILENAME = N'D:\DATABASE\NERV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
GO
ALTER DATABASE [NERV] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NERV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NERV] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [NERV] SET ANSI_NULLS OFF
GO
ALTER DATABASE [NERV] SET ANSI_PADDING OFF
GO
ALTER DATABASE [NERV] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [NERV] SET ARITHABORT OFF
GO
ALTER DATABASE [NERV] SET AUTO_CLOSE ON
GO
ALTER DATABASE [NERV] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [NERV] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [NERV] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [NERV] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [NERV] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [NERV] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [NERV] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [NERV] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [NERV] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [NERV] SET  DISABLE_BROKER
GO
ALTER DATABASE [NERV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [NERV] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [NERV] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [NERV] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [NERV] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [NERV] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [NERV] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [NERV] SET  READ_WRITE
GO
ALTER DATABASE [NERV] SET RECOVERY SIMPLE
GO
ALTER DATABASE [NERV] SET  MULTI_USER
GO
ALTER DATABASE [NERV] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [NERV] SET DB_CHAINING OFF
GO
USE [NERV]
GO
/****** Object:  ForeignKey [FK_Latch_Latch]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] DROP CONSTRAINT [FK_Latch_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_Latch]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_UserGroup]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_UserGroup]
GO
/****** Object:  ForeignKey [FK_Enterprise_Currency]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] DROP CONSTRAINT [FK_Enterprise_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency1]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency1]
GO
/****** Object:  ForeignKey [FK_UserAccount_Enterprise]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_Enterprise]
GO
/****** Object:  ForeignKey [FK_UserAccount_UserGroup]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_UserGroup]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_Enterprise]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAccount]') AND type in (N'U'))
DROP TABLE [dbo].[UserAccount]
GO
/****** Object:  Table [dbo].[CurrencyRate]    Script Date: 08/30/2011 18:33:30 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyRate]') AND type in (N'U'))
DROP TABLE [dbo].[CurrencyRate]
GO
/****** Object:  Table [dbo].[Enterprise]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] DROP CONSTRAINT [FK_Enterprise_Currency]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enterprise]') AND type in (N'U'))
DROP TABLE [dbo].[Enterprise]
GO
/****** Object:  Table [dbo].[KeyAccess]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_Latch]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyAccess]') AND type in (N'U'))
DROP TABLE [dbo].[KeyAccess]
GO
/****** Object:  Table [dbo].[Latch]    Script Date: 08/30/2011 18:33:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] DROP CONSTRAINT [FK_Latch_Latch]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Latch]') AND type in (N'U'))
DROP TABLE [dbo].[Latch]
GO
/****** Object:  StoredProcedure [dbo].[GET_SEG_USER]    Script Date: 08/30/2011 18:33:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GET_SEG_USER]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GET_SEG_USER]
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 08/30/2011 18:33:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserGroup]') AND type in (N'U'))
DROP TABLE [dbo].[UserGroup]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 08/30/2011 18:33:11 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_COM_CURRENCY_ISBASE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [DF_COM_CURRENCY_ISBASE]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Currency]') AND type in (N'U'))
DROP TABLE [dbo].[Currency]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 08/30/2011 18:33:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Currency]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Currency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Symbol] [char](4) NOT NULL,
	[IsBaseCurrency] [bit] NOT NULL CONSTRAINT [DF_COM_CURRENCY_ISBASE]  DEFAULT ((0)),
	[Mask] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Currency] ON
INSERT [dbo].[Currency] ([Id], [Name], [Symbol], [IsBaseCurrency], [Mask]) VALUES (1, N'Dolares', N'$   ', 1, N'$###')
SET IDENTITY_INSERT [dbo].[Currency] OFF
/****** Object:  Table [dbo].[UserGroup]    Script Date: 08/30/2011 18:33:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserGroup] ON
INSERT [dbo].[UserGroup] ([Id], [Name], [Description]) VALUES (1, N'Administradores', N'some description')
SET IDENTITY_INSERT [dbo].[UserGroup] OFF
/****** Object:  StoredProcedure [dbo].[GET_SEG_USER]    Script Date: 08/30/2011 18:33:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GET_SEG_USER]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		<José Luis Alvarado Avilés>
-- Create date: <08/21/2009>
-- Description:	<Devuelve los datos del usuario>
-- =============================================
CREATE PROCEDURE [dbo].[GET_SEG_USER]
	(
		@userName VARCHAR(20),
		@password VARCHAR(MAX),
		@idUser INT
	)
AS
BEGIN

	SET NOCOUNT ON;

    SELECT idUser, PER_PERSON_idPerson, userName, password, accessLevel, state
	FROM SEG_USER
	WHERE userName = @userName AND
		  password = @password AND
		  idUser = @idUser
END
' 
END
GO
/****** Object:  Table [dbo].[Latch]    Script Date: 08/30/2011 18:33:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Latch]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Latch](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](25) NOT NULL,
	[LatchParent] [int] NOT NULL,
 CONSTRAINT [PK_Latch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Latch] ON
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent]) VALUES (0, N'root', 0)
SET IDENTITY_INSERT [dbo].[Latch] OFF
/****** Object:  Table [dbo].[KeyAccess]    Script Date: 08/30/2011 18:33:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyAccess]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KeyAccess](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserGroupId] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[LatchId] [int] NOT NULL,
 CONSTRAINT [PK_KeyAccess] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Enterprise]    Script Date: 08/30/2011 18:33:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enterprise]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Enterprise](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[DataBaseName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Enterprise] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Enterprise] ON
INSERT [dbo].[Enterprise] ([Id], [Name], [CurrencyId], [DataBaseName]) VALUES (1, N'Renteco S.A.', 1, N'HF00000001')
SET IDENTITY_INSERT [dbo].[Enterprise] OFF
/****** Object:  Table [dbo].[CurrencyRate]    Script Date: 08/30/2011 18:33:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyRate]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CurrencyRate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[Buy] [float] NOT NULL,
	[Sell] [float] NOT NULL,
	[IssueDate] [datetime] NOT NULL,
	[CurrencyReference] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_CurrencyRate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 08/30/2011 18:33:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAccount]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserAccount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Account] [varchar](20) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[EnterpriseId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[IsOnline] [bit] NOT NULL,
	[UserGroupId] [int] NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[UserAccount]') AND name = N'IX_UserAccount')
CREATE UNIQUE NONCLUSTERED INDEX [IX_UserAccount] ON [dbo].[UserAccount] 
(
	[Account] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserAccount] ON
INSERT [dbo].[UserAccount] ([Id], [Account], [Password], [EnterpriseId], [Status], [IsOnline], [UserGroupId]) VALUES (1, N'ZQUALL', N'1bCi3RMap8vPNy3rKOREJw==', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
/****** Object:  ForeignKey [FK_Latch_Latch]    Script Date: 08/30/2011 18:33:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch]  WITH CHECK ADD  CONSTRAINT [FK_Latch_Latch] FOREIGN KEY([LatchParent])
REFERENCES [dbo].[Latch] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] CHECK CONSTRAINT [FK_Latch_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_Latch]    Script Date: 08/30/2011 18:33:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess]  WITH CHECK ADD  CONSTRAINT [FK_KeyAccess_Latch] FOREIGN KEY([LatchId])
REFERENCES [dbo].[Latch] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] CHECK CONSTRAINT [FK_KeyAccess_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_UserGroup]    Script Date: 08/30/2011 18:33:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess]  WITH CHECK ADD  CONSTRAINT [FK_KeyAccess_UserGroup] FOREIGN KEY([UserGroupId])
REFERENCES [dbo].[UserGroup] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] CHECK CONSTRAINT [FK_KeyAccess_UserGroup]
GO
/****** Object:  ForeignKey [FK_Enterprise_Currency]    Script Date: 08/30/2011 18:33:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise]  WITH CHECK ADD  CONSTRAINT [FK_Enterprise_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] CHECK CONSTRAINT [FK_Enterprise_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency]    Script Date: 08/30/2011 18:33:30 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate]  WITH CHECK ADD  CONSTRAINT [FK_CurrencyRate_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] CHECK CONSTRAINT [FK_CurrencyRate_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency1]    Script Date: 08/30/2011 18:33:30 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate]  WITH CHECK ADD  CONSTRAINT [FK_CurrencyRate_Currency1] FOREIGN KEY([CurrencyReference])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] CHECK CONSTRAINT [FK_CurrencyRate_Currency1]
GO
/****** Object:  ForeignKey [FK_UserAccount_Enterprise]    Script Date: 08/30/2011 18:33:30 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount]  WITH CHECK ADD  CONSTRAINT [FK_UserAccount_Enterprise] FOREIGN KEY([EnterpriseId])
REFERENCES [dbo].[Enterprise] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_Enterprise]
GO
/****** Object:  ForeignKey [FK_UserAccount_UserGroup]    Script Date: 08/30/2011 18:33:30 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount]  WITH CHECK ADD  CONSTRAINT [FK_UserAccount_UserGroup] FOREIGN KEY([UserGroupId])
REFERENCES [dbo].[UserGroup] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_UserGroup]
GO
