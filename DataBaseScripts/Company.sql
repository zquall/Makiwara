USE [COMPANY]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_Family]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Family]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 10/14/2011 16:35:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
/****** Object:  ForeignKey [FK_Task_Task]    Script Date: 10/14/2011 16:35:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Task]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Measure]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_ResourceType]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Task]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resource]') AND type in (N'U'))
DROP TABLE [dbo].[Resource]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 10/14/2011 16:35:18 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Task]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
DROP TABLE [dbo].[Task]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Family]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestDetail]
GO
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeXCustomer]
GO
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequest]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerContact]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
DROP TABLE [dbo].[PersonPhone]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneType]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceType]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceType]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Family]    Script Date: 10/14/2011 16:35:16 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Family]') AND type in (N'U'))
DROP TABLE [dbo].[Family]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
DROP TABLE [dbo].[Measure]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/14/2011 16:35:17 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/14/2011 16:35:17 ******/
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
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (1, N'Jaime', N'Torner')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (2, N'Jose Luis', N'Alvarado')
SET IDENTITY_INSERT [dbo].[Person] OFF
/****** Object:  Table [dbo].[Measure]    Script Date: 10/14/2011 16:35:17 ******/
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
/****** Object:  Table [dbo].[Family]    Script Date: 10/14/2011 16:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Family]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Family](
	[Id] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Family] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/14/2011 16:35:16 ******/
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
	[Address] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT [dbo].[Customer] ([Id], [Name], [Address]) VALUES (1, N'My Company Demo', N'jjbnf iubcjsdnunouiase uibnsdkcfnsdnfguis uihosed sdiubfjdhfj sioudhfksdhhuuiujhsdifoiuhsdf iughsdifsdfiuh')
INSERT [dbo].[Customer] ([Id], [Name], [Address]) VALUES (2, N'SEccond company', N'asdasdasd')
INSERT [dbo].[Customer] ([Id], [Name], [Address]) VALUES (3, N'T3 company chupe', N'cahsd')
SET IDENTITY_INSERT [dbo].[Customer] OFF
/****** Object:  Table [dbo].[ResourceType]    Script Date: 10/14/2011 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ResourceType](
	[Id] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[isTaxed] [bit] NOT NULL,
 CONSTRAINT [PK_ResourceType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 10/14/2011 16:35:17 ******/
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
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (2, N'Oficina')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (3, N'Casa')
SET IDENTITY_INSERT [dbo].[PhoneType] OFF
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 10/14/2011 16:35:17 ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 10/14/2011 16:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[UserAccountId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([Id], [PersonId], [UserAccountId]) VALUES (1, 1, 1)
INSERT [dbo].[Employee] ([Id], [PersonId], [UserAccountId]) VALUES (2, 2, 3)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 10/14/2011 16:35:16 ******/
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
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 10/14/2011 16:35:16 ******/
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
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 10/14/2011 16:35:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EmployeeXCustomer](
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeXCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[EmployeeXCustomer] ([CustomerId], [EmployeeId]) VALUES (1, 1)
INSERT [dbo].[EmployeeXCustomer] ([CustomerId], [EmployeeId]) VALUES (2, 1)
INSERT [dbo].[EmployeeXCustomer] ([CustomerId], [EmployeeId]) VALUES (2, 2)
INSERT [dbo].[EmployeeXCustomer] ([CustomerId], [EmployeeId]) VALUES (3, 1)
INSERT [dbo].[EmployeeXCustomer] ([CustomerId], [EmployeeId]) VALUES (3, 2)
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 10/14/2011 16:35:16 ******/
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
/****** Object:  Table [dbo].[Project]    Script Date: 10/14/2011 16:35:17 ******/
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
	[FamilyId] [int] NOT NULL,
	[BudgetRequestId] [int] NOT NULL,
	[CustumerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[ManagementApproval] [bit] NOT NULL,
	[CxcApproval] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ContingenciesRate] [float] NOT NULL,
	[GuaranteeRate] [float] NOT NULL,
	[TotalUtilityRate] [float] NOT NULL,
	[DiscountRate] [float] NOT NULL,
	[SalesTax] [float] NOT NULL,
	[OthersRate] [float] NOT NULL,
	[Comments] [text] NOT NULL,
 CONSTRAINT [PK_CustomerProject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Task]    Script Date: 10/14/2011 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Task](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Duration] [time](7) NOT NULL,
	[PercentComplete] [float] NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NOT NULL,
	[Notes] [text] NOT NULL,
	[RowNumber] [int] NOT NULL,
	[BindingListIndex] [int] NOT NULL,
	[CompleteThrough] [datetime] NOT NULL,
	[DeadLine] [datetime] NOT NULL,
	[DurationResolved] [time](7) NOT NULL,
	[EndDateTimeResolved] [datetime] NOT NULL,
	[Expanded] [bit] NOT NULL,
	[IsRoot] [bit] NOT NULL,
	[IsSumary] [bit] NOT NULL,
	[TaskLevel] [int] NOT NULL,
	[Milestone] [bit] NOT NULL,
	[MilestoneResolved] [bit] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 10/14/2011 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resource]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Resource](
	[Id] [int] NOT NULL,
	[MeasureId] [int] NOT NULL,
	[ResourceTypeId] [int] NOT NULL,
	[TaskId] [int] NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Amount] [float] NOT NULL,
	[Cost] [money] NOT NULL,
	[TotalCost] [money] NOT NULL,
	[RealUsed] [float] NOT NULL,
 CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequest_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest] FOREIGN KEY([ApplicationRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 10/14/2011 16:35:16 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Customer] FOREIGN KEY([CustumerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_Family]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Family] FOREIGN KEY([FamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Family]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceTypeId])
REFERENCES [dbo].[ResourceType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 10/14/2011 16:35:17 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 10/14/2011 16:35:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
/****** Object:  ForeignKey [FK_Task_Task]    Script Date: 10/14/2011 16:35:18 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Task] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Task]
GO
