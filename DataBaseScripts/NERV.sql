USE [NERV]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency]    Script Date: 10/14/2011 16:36:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency1]    Script Date: 10/14/2011 16:36:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency1]
GO
/****** Object:  ForeignKey [FK_Enterprise_Currency]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] DROP CONSTRAINT [FK_Enterprise_Currency]
GO
/****** Object:  ForeignKey [FK_KeyAccess_Latch]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_UserGroup]
GO
/****** Object:  ForeignKey [FK_Latch_Latch]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] DROP CONSTRAINT [FK_Latch_Latch]
GO
/****** Object:  ForeignKey [FK_UserAccount_Enterprise]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_Enterprise]
GO
/****** Object:  ForeignKey [FK_UserAccount_UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_UserGroup]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_Enterprise]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT [FK_UserAccount_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAccount]') AND type in (N'U'))
DROP TABLE [dbo].[UserAccount]
GO
/****** Object:  Table [dbo].[CurrencyRate]    Script Date: 10/14/2011 16:36:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] DROP CONSTRAINT [FK_CurrencyRate_Currency1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CurrencyRate]') AND type in (N'U'))
DROP TABLE [dbo].[CurrencyRate]
GO
/****** Object:  Table [dbo].[Enterprise]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] DROP CONSTRAINT [FK_Enterprise_Currency]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enterprise]') AND type in (N'U'))
DROP TABLE [dbo].[Enterprise]
GO
/****** Object:  Table [dbo].[KeyAccess]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_Latch]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] DROP CONSTRAINT [FK_KeyAccess_UserGroup]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyAccess]') AND type in (N'U'))
DROP TABLE [dbo].[KeyAccess]
GO
/****** Object:  Table [dbo].[Latch]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] DROP CONSTRAINT [FK_Latch_Latch]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Latch]') AND type in (N'U'))
DROP TABLE [dbo].[Latch]
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserGroup]') AND type in (N'U'))
DROP TABLE [dbo].[UserGroup]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 10/14/2011 16:36:55 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_COM_CURRENCY_ISBASE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Currency] DROP CONSTRAINT [DF_COM_CURRENCY_ISBASE]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Currency]') AND type in (N'U'))
DROP TABLE [dbo].[Currency]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 10/14/2011 16:36:55 ******/
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
/****** Object:  Table [dbo].[UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
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
/****** Object:  Table [dbo].[Latch]    Script Date: 10/14/2011 16:36:56 ******/
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
	[Caption] [varchar](25) NULL,
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
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (0, N'root', 0, N'/')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (1, N'DashBoard', 0, N'DashBoard')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (2, N'Project', 1, N'Proyectos')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (3, N'BugetRequest', 2, N'Solicutud de Presupuesto')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (4, N'EstimateProject', 2, N'Cotizar Proyecto')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (6, N'CreateProject', 2, N'Crear Proyecto')
INSERT [dbo].[Latch] ([Id], [Code], [LatchParent], [Caption]) VALUES (7, N'SearchProject', 2, N'Buscar Proyecto')
SET IDENTITY_INSERT [dbo].[Latch] OFF
/****** Object:  Table [dbo].[KeyAccess]    Script Date: 10/14/2011 16:36:56 ******/
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
/****** Object:  Table [dbo].[Enterprise]    Script Date: 10/14/2011 16:36:56 ******/
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
/****** Object:  Table [dbo].[CurrencyRate]    Script Date: 10/14/2011 16:36:55 ******/
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
	[CurrencyIdReference] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_CurrencyRate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 10/14/2011 16:36:56 ******/
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
INSERT [dbo].[UserAccount] ([Id], [Account], [Password], [EnterpriseId], [Status], [IsOnline], [UserGroupId]) VALUES (3, N'VORTEX', N'1bCi3RMap8vPNy3rKOREJw==', 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
/****** Object:  ForeignKey [FK_CurrencyRate_Currency]    Script Date: 10/14/2011 16:36:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate]  WITH CHECK ADD  CONSTRAINT [FK_CurrencyRate_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] CHECK CONSTRAINT [FK_CurrencyRate_Currency]
GO
/****** Object:  ForeignKey [FK_CurrencyRate_Currency1]    Script Date: 10/14/2011 16:36:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate]  WITH CHECK ADD  CONSTRAINT [FK_CurrencyRate_Currency1] FOREIGN KEY([CurrencyIdReference])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CurrencyRate_Currency1]') AND parent_object_id = OBJECT_ID(N'[dbo].[CurrencyRate]'))
ALTER TABLE [dbo].[CurrencyRate] CHECK CONSTRAINT [FK_CurrencyRate_Currency1]
GO
/****** Object:  ForeignKey [FK_Enterprise_Currency]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise]  WITH CHECK ADD  CONSTRAINT [FK_Enterprise_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Enterprise_Currency]') AND parent_object_id = OBJECT_ID(N'[dbo].[Enterprise]'))
ALTER TABLE [dbo].[Enterprise] CHECK CONSTRAINT [FK_Enterprise_Currency]
GO
/****** Object:  ForeignKey [FK_KeyAccess_Latch]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess]  WITH CHECK ADD  CONSTRAINT [FK_KeyAccess_Latch] FOREIGN KEY([LatchId])
REFERENCES [dbo].[Latch] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] CHECK CONSTRAINT [FK_KeyAccess_Latch]
GO
/****** Object:  ForeignKey [FK_KeyAccess_UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess]  WITH CHECK ADD  CONSTRAINT [FK_KeyAccess_UserGroup] FOREIGN KEY([UserGroupId])
REFERENCES [dbo].[UserGroup] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_KeyAccess_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyAccess]'))
ALTER TABLE [dbo].[KeyAccess] CHECK CONSTRAINT [FK_KeyAccess_UserGroup]
GO
/****** Object:  ForeignKey [FK_Latch_Latch]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch]  WITH CHECK ADD  CONSTRAINT [FK_Latch_Latch] FOREIGN KEY([LatchParent])
REFERENCES [dbo].[Latch] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Latch_Latch]') AND parent_object_id = OBJECT_ID(N'[dbo].[Latch]'))
ALTER TABLE [dbo].[Latch] CHECK CONSTRAINT [FK_Latch_Latch]
GO
/****** Object:  ForeignKey [FK_UserAccount_Enterprise]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount]  WITH CHECK ADD  CONSTRAINT [FK_UserAccount_Enterprise] FOREIGN KEY([EnterpriseId])
REFERENCES [dbo].[Enterprise] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_Enterprise]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_Enterprise]
GO
/****** Object:  ForeignKey [FK_UserAccount_UserGroup]    Script Date: 10/14/2011 16:36:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount]  WITH CHECK ADD  CONSTRAINT [FK_UserAccount_UserGroup] FOREIGN KEY([UserGroupId])
REFERENCES [dbo].[UserGroup] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserAccount_UserGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccount]'))
ALTER TABLE [dbo].[UserAccount] CHECK CONSTRAINT [FK_UserAccount_UserGroup]
GO
