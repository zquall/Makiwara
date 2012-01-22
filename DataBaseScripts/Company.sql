USE [COMPANY]
GO
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 01/21/2012 20:45:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 01/21/2012 20:45:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 01/21/2012 20:45:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 01/21/2012 20:45:58 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 01/21/2012 20:45:58 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 01/21/2012 20:46:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 01/21/2012 20:46:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
/****** Object:  Table [dbo].[Dependencies]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencies]') AND type in (N'U'))
DROP TABLE [dbo].[Dependencies]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 01/21/2012 20:46:01 ******/
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
/****** Object:  Table [dbo].[Task]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
DROP TABLE [dbo].[Task]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 01/21/2012 20:45:58 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestDetail]
GO
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 01/21/2012 20:45:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequest]
GO
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 01/21/2012 20:46:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeXCustomer]
GO
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 01/21/2012 20:45:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[BindCustomer]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerContact]
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
DROP TABLE [dbo].[PersonPhone]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 01/21/2012 20:45:59 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneType]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceType]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceType]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 01/21/2012 20:45:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 01/21/2012 20:46:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
DROP TABLE [dbo].[Measure]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 01/21/2012 20:46:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 01/21/2012 20:46:01 ******/
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
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (3, N'ALEJANDRO FONSECA SOLANO', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (4, N'JUAN CARLOS RODRIGUEZ', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (5, N'asdf', N'fasd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (6, N'f', N'fasd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (7, N'123', N'3123')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (8, N'234', N'412')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (9, N'234', N'4')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (10, N'sdfsd', N'dsf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (11, N'dasd', N'das')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (12, N'asd', N'das')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (13, N'34534534534', N'34534')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (14, N'asd', N'asdfasdfds')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (15, N'asd', N'asdas')
SET IDENTITY_INSERT [dbo].[Person] OFF
/****** Object:  Table [dbo].[Measure]    Script Date: 01/21/2012 20:46:00 ******/
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
INSERT [dbo].[Measure] ([Id], [Name], [Symbol]) VALUES (1, N'MEDIDA 1', N'M1')
/****** Object:  Table [dbo].[Customer]    Script Date: 01/21/2012 20:45:58 ******/
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
	[AddressOptional] [varchar](255) NULL,
	[Phone] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
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
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (1, N'Renteco S.A.', N'jjbnf iubcjsdnunouiase uibnsdkcfnsdnfguis uihosed sdiubfjdhfj sioudhfksdhhuuiujhsdifoiuhsdf iughsdifsdfiuh', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (27, N'AGROINDUCHEM S.A', N'PAVAS, ZONA INDUSTRIAL , DE LAS OFICINAS CENTRALES DE PIZZA HUT 250 MTS OESTE, FRENTE CONCRETERA NACIONAL.', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (28, N'EL PELON DE LA BAJURA S.A', N'RADIAL SAN SANTONIO DE BELEN ENTRADA PRINCIPAL DE MATRA 175 ESTE', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (29, N'ABBOTT BUILDING SHELL', N'LOS YOSES', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (30, N'sdfa', N'fasdfasdf', N'asdfasdf', N'fadsf', N'dfasdf')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (31, N'3123', N'3123', N'12312', N'12312', N'123')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (32, N'2341234', N'123423', N'23423', N'231423', N'4123423')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (33, N'234', N'234', N'423', N'234', N'423')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (34, N'sdf', N'sdfds', N'fsdf', N'sdfsd', N'sdfsdf')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (35, N'asd', N'das', N'asdas', N'dasd', N'das')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (36, N'sdf', N'gsfd', N'fsdgsfd', N'gfgsfd', N'fsdg')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (37, N'fdsgfd', N'gfsdgfdg', N'dfgfdg', N'dfg', N'gfd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (38, N'zxz<', N'xx', N'xz<', N'z<x', N'xz')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (39, N'asdasdasd', N'asdas', N'asdasd', N'asdasd', N'adass')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (40, N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Customer] OFF
/****** Object:  Table [dbo].[ResourceType]    Script Date: 01/21/2012 20:46:01 ******/
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
	[IsTaxed] [bit] NOT NULL,
 CONSTRAINT [PK_ResourceType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ResourceType] ([Id], [Name], [IsTaxed]) VALUES (1, N'ALQUILERES', 0)
INSERT [dbo].[ResourceType] ([Id], [Name], [IsTaxed]) VALUES (2, N'PRODUCTO', 1)
INSERT [dbo].[ResourceType] ([Id], [Name], [IsTaxed]) VALUES (3, N'PLANILLA', 0)
/****** Object:  Table [dbo].[PhoneType]    Script Date: 01/21/2012 20:46:01 ******/
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
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (4, N'Celular')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (5, N'Oficina')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (6, N'Casa')
SET IDENTITY_INSERT [dbo].[PhoneType] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 01/21/2012 20:45:59 ******/
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
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 01/21/2012 20:46:01 ******/
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
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (4, N'12312', 4, 7)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (5, N'123123', 5, 7)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (6, N'123', 6, 7)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (7, N'234231', 1, 8)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (8, N'234', 2, 8)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (9, N'4', 3, 8)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (10, N'4', 1, 9)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (11, N'423', 2, 9)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (12, N'23423', 3, 9)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (13, N'fsd', 1, 10)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (14, N'sdfsd', 2, 10)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (15, N'sdfsdf', 3, 10)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (16, N'asd', 1, 11)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (17, N'dasd', 2, 11)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (18, N'asdas', 3, 11)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (19, N'asd', 1, 12)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (20, N'das', 2, 12)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (21, N'asd', 3, 12)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (22, N'34534', 1, 13)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (23, N'5345', 2, 13)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (24, N'45345', 3, 13)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (25, N'sdfasdfasd', 1, 14)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (26, N'fsdafsd', 2, 14)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (27, N'fasdf', 3, 14)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (28, N'as', 1, 15)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (29, N'asdas', 2, 15)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (30, N'asd', 3, 15)
SET IDENTITY_INSERT [dbo].[PersonPhone] OFF
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 01/21/2012 20:45:59 ******/
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
	[Email] [varchar](75) NOT NULL,
 CONSTRAINT [PK_CustomerContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerContact] ON
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (1, N'Funcionario', 3, 27, N'no@email.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (2, N'Funcionario', 4, 28, N'no@email.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (3, N'asdf', 5, 30, N'fasdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (4, N'ff', 6, 30, N'dsafsdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (5, N'123123', 7, 31, N'3123')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (6, N'1234', 8, 32, N'12341234')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (7, N'4234', 9, 33, N'342343')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (8, N'fsd', 10, 34, N'sdfsdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (9, N'asd', 11, 35, N'asdasd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (10, N'asdas', 12, 35, N'dasd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (11, N'534534', 13, 37, N'345345')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (12, N'asdfdsa', 14, 38, N'sdfasdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (13, N'as', 15, 39, N'asdasd')
SET IDENTITY_INSERT [dbo].[CustomerContact] OFF
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 01/21/2012 20:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindCustomer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BindCustomer](
	[CustomerId] [int] NOT NULL,
	[AlienId] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BindCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_BindCustomer] UNIQUE NONCLUSTERED 
(
	[AlienId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (29, N'001000')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (28, N'001806')
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 01/21/2012 20:46:00 ******/
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
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 01/21/2012 20:45:57 ******/
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
	[DateCreated] [date] NOT NULL,
	[DateModified] [date] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_ApplicationRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId]) VALUES (1, 1, N'PROYECTO 1', CAST(0x0A350B00 AS Date), CAST(0x0A350B00 AS Date), 1)
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 01/21/2012 20:45:58 ******/
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
/****** Object:  Table [dbo].[Project]    Script Date: 01/21/2012 20:46:01 ******/
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
SET IDENTITY_INSERT [dbo].[Project] ON
INSERT [dbo].[Project] ([Id], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments]) VALUES (1, 1, 1, 1, N'PROYECTO 1', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO')
INSERT [dbo].[Project] ([Id], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments]) VALUES (2, 1, 1, 1, N'PROYECTO 1', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO')
SET IDENTITY_INSERT [dbo].[Project] OFF
/****** Object:  Table [dbo].[Task]    Script Date: 01/21/2012 20:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Task](
	[Id] [bigint] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Duration] [varchar](50) NOT NULL,
	[PercentComplete] [float] NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NOT NULL,
	[Notes] [text] NOT NULL,
	[RowNumber] [int] NOT NULL,
	[BindingListIndex] [int] NOT NULL,
	[CompleteThrough] [datetime] NOT NULL,
	[DeadLine] [datetime] NOT NULL,
	[DurationResolved] [varchar](50) NOT NULL,
	[EndDateTimeResolved] [datetime] NOT NULL,
	[Expanded] [bit] NOT NULL,
	[IsRoot] [bit] NOT NULL,
	[IsSumary] [bit] NOT NULL,
	[TaskLevel] [int] NOT NULL,
	[Milestone] [bit] NOT NULL,
	[MilestoneResolved] [bit] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (1, 1, 1, N'Tarea 1', N'3.00:00:00', 0, CAST(0x00009FB700000000 AS DateTime), CAST(0x00009FBA00000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x00009FB700000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FB9018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (1, 2, 1, N'Tarea 1', N'7.00:00:00', 0, CAST(0x00009FA800000000 AS DateTime), CAST(0x00009FAF00000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x00009FA900000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'7.00:00:00', CAST(0x00009FAE018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (2, 1, 1, N'Tarea 2', N'1.00:00:00', 0, CAST(0x00009FB700000000 AS DateTime), CAST(0x00009FB800000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x00009FB700000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB7018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (2, 2, 1, N'Tarea 2', N'2.00:00:00', 0, CAST(0x00009FA800000000 AS DateTime), CAST(0x00009FAA00000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x00009FA800000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FA9018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (3, 1, 1, N'Tarea 3', N'1.00:00:00', 0, CAST(0x00009FB800000000 AS DateTime), CAST(0x00009FB900000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x00009FB800000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB8018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (3, 2, 1, N'Tarea 3', N'3.00:00:00', 0, CAST(0x00009FAA00000000 AS DateTime), CAST(0x00009FAD00000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x00009FAB00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FAC018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (4, 1, 1, N'Tarea 4', N'1.00:00:00', 0, CAST(0x00009FB900000000 AS DateTime), CAST(0x00009FBA00000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x00009FB900000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB9018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (4, 2, 1, N'Tarea 4', N'2.00:00:00', 0, CAST(0x00009FAD00000000 AS DateTime), CAST(0x00009FAF00000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x00009FAD00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FAE018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (5, 2, 1, N'Tarea 5', N'1.00:00:00', 0, CAST(0x00009FAD00000000 AS DateTime), CAST(0x00009FAE00000000 AS DateTime), N'Ninguna', 5, -1, CAST(0x00009FAD00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FAD018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (6, 2, 1, N'Tarea 6', N'2.00:00:00', 0, CAST(0x00009FAE00000000 AS DateTime), CAST(0x00009FB000000000 AS DateTime), N'Ninguna', 6, -1, CAST(0x00009FAE00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FAF018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (7, 2, 1, N'Tarea 7', N'6.00:00:00', 0, CAST(0x00009FB000000000 AS DateTime), CAST(0x00009FB600000000 AS DateTime), N'Ninguna', 7, -1, CAST(0x00009FB000000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'6.00:00:00', CAST(0x00009FB5018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (8, 2, 1, N'Tarea 8', N'1.00:00:00', 0, CAST(0x00009FB000000000 AS DateTime), CAST(0x00009FB100000000 AS DateTime), N'Ninguna', 8, -1, CAST(0x00009FB000000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB0018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (9, 2, 1, N'Tarea 9', N'2.00:00:00', 0, CAST(0x00009FB100000000 AS DateTime), CAST(0x00009FB300000000 AS DateTime), N'Ninguna', 9, -1, CAST(0x00009FB100000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FB2018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (10, 2, 1, N'Tarea 10', N'3.00:00:00', 0, CAST(0x00009FB300000000 AS DateTime), CAST(0x00009FB600000000 AS DateTime), N'Ninguna', 10, -1, CAST(0x00009FB300000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FB5018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
/****** Object:  Table [dbo].[Resource]    Script Date: 01/21/2012 20:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resource]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Resource](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[MeasureId] [int] NOT NULL,
	[ResourceTypeId] [int] NOT NULL,
	[TaskId] [bigint] NOT NULL,
	[Code] [varchar](25) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Resource] ON
INSERT [dbo].[Resource] ([Id], [ProjectId], [MeasureId], [ResourceTypeId], [TaskId], [Code], [Name], [Amount], [Cost], [TotalCost], [RealUsed]) VALUES (1, 2, 1, 1, 1, N'1', N'ALQ-01', 55, 40.0000, 2200.0000, 50)
SET IDENTITY_INSERT [dbo].[Resource] OFF
/****** Object:  Table [dbo].[Dependencies]    Script Date: 01/21/2012 20:45:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Dependencies](
	[idTask] [bigint] NOT NULL,
	[idTaskProject] [int] NOT NULL,
	[idDependency] [bigint] NOT NULL,
	[idDependencyProject] [int] NOT NULL
) ON [PRIMARY]
END
GO
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (3, 1, 2, 1)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (4, 1, 3, 1)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (3, 2, 2, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (4, 2, 3, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (5, 2, 3, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (6, 2, 5, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (7, 2, 5, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (7, 2, 6, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (9, 2, 8, 2)
INSERT [dbo].[Dependencies] ([idTask], [idTaskProject], [idDependency], [idDependencyProject]) VALUES (10, 2, 9, 2)
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 01/21/2012 20:45:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer]  WITH CHECK ADD  CONSTRAINT [FK_BindCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] CHECK CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 01/21/2012 20:45:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequest_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 01/21/2012 20:45:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 01/21/2012 20:45:58 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 01/21/2012 20:45:58 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest] FOREIGN KEY([ApplicationRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 01/21/2012 20:45:59 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 01/21/2012 20:45:59 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 01/21/2012 20:45:59 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task] FOREIGN KEY([idTask], [idTaskProject])
REFERENCES [dbo].[Task] ([Id], [ProjectId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 01/21/2012 20:45:59 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task1] FOREIGN KEY([idDependency], [idDependencyProject])
REFERENCES [dbo].[Task] ([Id], [ProjectId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 01/21/2012 20:45:59 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 01/21/2012 20:46:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 01/21/2012 20:46:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Customer] FOREIGN KEY([CustumerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceTypeId])
REFERENCES [dbo].[ResourceType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Task] FOREIGN KEY([TaskId], [ProjectId])
REFERENCES [dbo].[Task] ([Id], [ProjectId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 01/21/2012 20:46:01 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
