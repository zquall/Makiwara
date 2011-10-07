USE [RENTECOSA]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_ApplicationRequest]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_ApplicationRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_CustomerProject_Customer]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerProject_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_CustomerProject_Customer]
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_ApplicationRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestDetail]
GO
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequest]
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
DROP TABLE [dbo].[PersonPhone]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerContact]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerProject_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_CustomerProject_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
DROP TABLE [dbo].[Measure]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 10/07/2011 16:43:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneType]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/07/2011 16:43:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 10/07/2011 16:43:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhoneType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PhoneType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PhoneType] ON
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (1, N'Celular')
SET IDENTITY_INSERT [dbo].[PhoneType] OFF
/****** Object:  Table [dbo].[Person]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (1, N'Jose Luis', N'Alvarado')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (2, N'Jaime', N'Torner')
SET IDENTITY_INSERT [dbo].[Person] OFF
/****** Object:  Table [dbo].[Measure]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Measure](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Symbol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Measure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 10/07/2011 16:43:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_CustomerProject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[UserAccountId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CustomerContact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Job] [varchar](50) NOT NULL,
	[PersonId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_CustomerContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 10/07/2011 16:43:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonPhone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[PhoneTypeId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
 CONSTRAINT [PK_PersonPhone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PersonPhone] ON
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (1, N'8855-3679', 1, 1)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (2, N'2573-3155', 1, 1)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (3, N'8827-7129', 1, 2)
SET IDENTITY_INSERT [dbo].[PersonPhone] OFF
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequest](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ProjectName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ApplicationRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 10/07/2011 16:43:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequestDetail](
	[Id] [bigint] NOT NULL,
	[ApplicationRequestId] [int] NOT NULL,
	[MeasureId] [int] NOT NULL,
	[Quantity] [float] NOT NULL,
	[Problem] [varchar](75) NOT NULL,
	[Solution] [varchar](75) NOT NULL,
 CONSTRAINT [PK_ApplicationRequestDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequest_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_ApplicationRequest]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_ApplicationRequest] FOREIGN KEY([ApplicationRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_ApplicationRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_ApplicationRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 10/07/2011 16:43:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 10/07/2011 16:43:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 10/07/2011 16:43:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_CustomerProject_Customer]    Script Date: 10/07/2011 16:43:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerProject_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_CustomerProject_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerProject_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_CustomerProject_Customer]
GO
