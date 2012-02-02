USE [COMPANY]
GO
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_BudgetRequestConditions_BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] DROP CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_ProjectState]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_ProjectState]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Stock_Item]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Item]
GO
/****** Object:  ForeignKey [FK_Stock_Warehouse]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Warehouse]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
/****** Object:  Table [dbo].[Dependencies]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencies]') AND type in (N'U'))
DROP TABLE [dbo].[Dependencies]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 02/02/2012 17:35:56 ******/
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
/****** Object:  Table [dbo].[Task]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
DROP TABLE [dbo].[Task]
GO
/****** Object:  Table [dbo].[BudgetRequestCondition]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] DROP CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestCondition]
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestDetail]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_ProjectState]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeXCustomer]
GO
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequest]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[BindCustomer]
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
DROP TABLE [dbo].[PersonPhone]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerContact]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Item]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Warehouse]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stock]') AND type in (N'U'))
DROP TABLE [dbo].[Stock]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 02/02/2012 17:35:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceType]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceType]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 02/02/2012 17:35:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Warehouse]') AND type in (N'U'))
DROP TABLE [dbo].[Warehouse]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneType]
GO
/****** Object:  Table [dbo].[BindItem]    Script Date: 02/02/2012 17:35:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindItem]') AND type in (N'U'))
DROP TABLE [dbo].[BindItem]
GO
/****** Object:  Table [dbo].[ProjectState]    Script Date: 02/02/2012 17:35:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectState]') AND type in (N'U'))
DROP TABLE [dbo].[ProjectState]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
DROP TABLE [dbo].[Item]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
DROP TABLE [dbo].[Measure]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 02/02/2012 17:35:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 02/02/2012 17:35:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 02/02/2012 17:35:53 ******/
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
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (1, N'Renteco S.A.', N'200 Sur del liceo del Sur, Barrio Cuba', NULL, NULL, NULL)
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
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (41, N'sdfsdf', N'sdfsd', N'sdfsdf', N'fsdf', N'fsdf')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (42, N'csc', N'csd', N'sdcsd', N'cdsc', N'sdc')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (43, N'sadc', N'casd', N'asdcasdd', N'c', N'csdacsdcasd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (44, N'sd', N'fsdfsd', N'fsdf', N'sdfsdf', N'sdfsd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (45, N'asdfsd', N'asdfasdf', N'fasdfasd', N'fsdfasdfads', N'asfsd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (46, N'sdc', N'asdc', N'dcasd', N'casd', N'casd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (47, N'sdfvsdfvsdf', N'vdfsvsdf', N'sdfvfsdv', N'vsdf', N'vsdfvsdfv')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (48, N'erf', N'fer', N'ferf', N'er', N'erf')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (49, N'as', N'sacas', N'cas', N'asdcs', N'adcsdcscsad')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (50, N'ghj', N'hjh', N'ghjfghj', N'jfg', N'fhjhfgjhg')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (51, N'asdfas', N'asdf', N'asdfasd', N'asdf', N'dfasd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (52, N'erf', N'ref', N'fref', N'erfer', N'erf')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (53, N'sdf', N'fsdfsdf', N'sdf', N'fsd', N'fsd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (54, N'tr', N'tytrytr', N'ytrey', N'trytry', N'y')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (55, N'erferferf', N'ferf', N'ferf', N'fer', N'f')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (56, N'erger', N'ergerg', N'gger', N'ergr', N'egerg')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (57, N'vb ', N'cbv ', N' bv bv ', N'bvc ', N'cbv cbv')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (58, N'sdac', N'sdc', N'csdcas', N'casd', N'csd')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (59, N'gbfgbfgb', N'fbfg', N'fdbgfgb', N'bb', N'gb')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (60, N'b', N'bfgb', N'bfgbfgbfg', N'fgbfg', N'gfbfg')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (61, N'pok', N'sdvsd', N'vsdvsdv', N'po´k', N'poj')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (62, N'rrrrrrr', N'rrr', N'rrrrrr', N'rrrr', N'rrrr')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (63, N'bbbbbb', N'bbb', N'bbbbb', N'bbbb', N'bbbb')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (64, N'APLICACIONES DE RENTECO', N'BARRIO CUBA', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (65, N'ABONDANZA D.E.C.R S.A.', N'SAN JOSE, AV 1 CALLES 29 Y 33, BARRIO ESCALANTE', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (66, N'LOCHIYU S.A.', N'CONCEPCION DE TRES RIOS.', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customer] OFF
/****** Object:  Table [dbo].[Person]    Script Date: 02/02/2012 17:35:54 ******/
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
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (16, N'asdf', N'asdfasdfasdf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (17, N'sdc', N'csd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (18, N'sdcsd', N'csdc')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (19, N'sad', N'das')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (20, N'fsdfsd', N'fsdf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (21, N'sdf', N'fsdf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (22, N'asdf', N'dfasd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (23, N'sdcasd', N'asdc')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (24, N'dsfvsdf', N'vsdfv')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (25, N'erf', N'refrefref')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (26, N'cscsc', N'scsc')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (27, N'ghjfgj', N'jjghjhjfg')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (28, N'asdf', N'fasd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (29, N'f', N'fer')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (30, N'sdfsd', N'fsd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (31, N'ry', N'yyyyyy')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (32, N'erferf', N'fer')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (33, N'ergerg', N'erge')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (34, N'bvc cbv', N'bv ')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (35, N'c', N'sadc')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (36, N'dfgbgdfb', N'dfgbdfg')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (37, N'dfgb', N'bfgb')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (38, N'fgb', N'bfgbgf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (39, N'dvsd', N'sdv')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (40, N'rrr', N'rrr')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (41, N'tt', N'tt')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (42, N'wwwww', N'ww')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (43, N'yyy', N'yy')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (44, N'xxx', N'xxx')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (45, N'bbbb', N'b')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (46, N'yy', N'yy')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (47, N'Carlos', N'Mata')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (48, N'David', N'Sibaja')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (49, N'Luis', N'Hernandez')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (50, N'Jose Luis', N'Alvarado')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (51, N'ANA LUCIA MONGE', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (52, N'lkj', N'lkj')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (53, N'CHEN SHIAN LO TSENG (DOÑA SARA) 8827-6510', N'')
SET IDENTITY_INSERT [dbo].[Person] OFF
/****** Object:  Table [dbo].[Measure]    Script Date: 02/02/2012 17:35:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Measure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Symbol] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Measure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Measure] ON
INSERT [dbo].[Measure] ([Id], [Name], [Symbol]) VALUES (1, N'Metro', N'm')
INSERT [dbo].[Measure] ([Id], [Name], [Symbol]) VALUES (2, N'Metro Cuadrado', N'm²')
SET IDENTITY_INSERT [dbo].[Measure] OFF
/****** Object:  Table [dbo].[Item]    Script Date: 02/02/2012 17:35:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Item](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
	[Price] [money] NOT NULL,
	[IsTaxed] [bit] NOT NULL,
	[DateCreated] [timestamp] NOT NULL,
	[DateModified] [date] NOT NULL,
	[MaximunDiscount] [int] NOT NULL,
	[WasDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectState]    Script Date: 02/02/2012 17:35:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectState]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProjectState](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProjectState] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectState] ON
INSERT [dbo].[ProjectState] ([Id], [Name]) VALUES (1, N'Activo')
SET IDENTITY_INSERT [dbo].[ProjectState] OFF
/****** Object:  Table [dbo].[BindItem]    Script Date: 02/02/2012 17:35:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BindItem](
	[ItemId] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 02/02/2012 17:35:55 ******/
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
/****** Object:  Table [dbo].[Warehouse]    Script Date: 02/02/2012 17:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Warehouse]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Warehouse](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 02/02/2012 17:35:56 ******/
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
/****** Object:  Table [dbo].[Stock]    Script Date: 02/02/2012 17:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stock]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Stock](
	[ItemId] [int] NOT NULL,
	[WarehouseId] [int] NOT NULL,
	[Quantity] [decimal](18, 6) NOT NULL,
	[Maximun] [int] NOT NULL,
	[Minimum] [int] NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC,
	[WarehouseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 02/02/2012 17:35:53 ******/
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
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (14, N'fas', 16, 41, N'fasdfasd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (15, N'csdc', 17, 42, N'csd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (16, N'sdc', 18, 42, N'sdcsdc')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (17, N'as', 19, 43, N'asdas')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (18, N'fsdfsd', 20, 43, N'fsdfsd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (19, N'sdf', 21, 44, N'fsdfsd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (20, N'asdfa', 22, 45, N'fasfsd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (21, N'asdcasd', 23, 46, N'asdcasd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (22, N'vsdf', 24, 47, N'sdfvfdv')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (23, N'erf', 25, 48, N'ferf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (24, N'cs', 26, 49, N'cscsc')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (25, N'hghjh', 27, 50, N'fjhfghj')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (26, N'fasdfa', 28, 51, N'fasdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (27, N'ref', 29, 52, N'ferf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (28, N'sdf', 30, 53, N'sdfsdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (29, N'yyyyertytr', 31, 54, N'ytry')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (30, N'ferf', 32, 55, N'ferf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (31, N'gerg', 33, 56, N'ergerg')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (32, N' bv', 34, 57, N' bvc bv')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (33, N'casdc', 35, 58, N'asdcasd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (34, N'bdffgb', 36, 59, N'gfbfgbg')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (35, N'fgb', 37, 59, N'bfgbfgb')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (36, N'fgb', 38, 60, N'bfgbfg')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (37, N'vsd', 39, 61, N'sdvsd')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (38, N'rrrr', 40, 62, N'rrrr')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (39, N'tttt', 41, 62, N'ttttt')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (41, N'wwwwww', 42, 62, N'wwww')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (42, N'yyy', 43, 62, N'y')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (43, N'xxx', 44, 62, N'xxxx')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (44, N'bb', 45, 63, N'bb')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (45, N'yyy', 46, 63, N'yy')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (46, N'Gerente Financiero', 47, 1, N'cmata@renteco.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (47, N'Director de Obras', 48, 64, N'dsibaja@renteco.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (48, N'Director de Quimicos y Aplicaciones', 49, 1, N'lhernandez@renteco.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (49, N'Informatica', 50, 29, N'kugy@tjfy.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (50, N'Funcionario', 51, 65, N'email@no.disponible')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (51, N'klj', 52, 65, N'ñlkj')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (52, N'Funcionario', 53, 66, N'email@no.disponible')
SET IDENTITY_INSERT [dbo].[CustomerContact] OFF
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 02/02/2012 17:35:55 ******/
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
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (31, N'sdaf', 1, 16)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (32, N'fsdfsd', 2, 16)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (33, N'asdfsd', 3, 16)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (34, N'sdcds', 1, 17)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (35, N'csd', 2, 17)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (36, N'sdcsd', 3, 17)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (37, N'csd', 1, 18)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (38, N'sdc', 2, 18)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (39, N'dscsdc', 3, 18)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (40, N'as', 1, 19)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (41, N'asd', 2, 19)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (42, N'sd', 3, 19)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (43, N'ssd', 1, 20)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (44, N'sdfsdf', 2, 20)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (45, N'fsdf', 3, 20)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (46, N'sdfsd', 2, 21)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (47, N'sdf', 2, 21)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (48, N'sdfsdf', 3, 21)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (49, N'asd', 1, 22)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (50, N'asdfasd', 2, 22)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (51, N'fasdf', 3, 22)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (52, N'asd', 1, 23)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (53, N'asdc', 2, 23)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (54, N'casdcsd', 3, 23)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (55, N'123231423', 1, 24)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (56, N'1234123', 2, 24)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (57, N'41234231', 3, 24)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (58, N'erf', 1, 25)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (59, N'fr', 2, 25)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (60, N'ferfre', 3, 25)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (61, N's', 1, 26)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (62, N'c', 2, 26)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (63, N'scsc', 3, 26)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (64, N'j', 1, 27)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (65, N'hj', 2, 27)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (66, N'ghj', 3, 27)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (67, N'asdf', 1, 28)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (68, N'fasdf', 2, 28)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (69, N'asdfasd', 3, 28)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (70, N'fer', 1, 29)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (71, N'fre', 2, 29)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (72, N'fref', 3, 29)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (73, N'sdfsdf', 1, 30)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (74, N'sdf', 2, 30)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (75, N'sdfsdf', 3, 30)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (76, N'rty', 1, 31)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (77, N'eytry', 2, 31)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (78, N'treyerty', 3, 31)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (79, N'fer', 1, 32)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (80, N'er', 2, 32)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (81, N'erfre', 3, 32)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (82, N'egerg', 1, 33)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (83, N'ergerg', 2, 33)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (84, N'eger', 3, 33)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (85, N'vb bv', 1, 34)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (86, N' cbv ', 2, 34)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (87, N'bv bv ', 3, 34)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (88, N'ac', 1, 35)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (89, N'dcsda', 2, 35)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (90, N'sdc', 3, 35)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (91, N'dfgb', 1, 36)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (92, N'bfgdb', 2, 36)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (93, N'fbfgb', 3, 36)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (94, N'dfgdfg', 1, 37)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (95, N'fgdbfg', 2, 37)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (96, N'', 3, 37)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (97, N'fgbfgbfg', 1, 38)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (98, N'bgfb', 2, 38)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (99, N'gfbgfbg', 3, 38)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (100, N'sdv', 1, 39)
GO
print 'Processed 100 total records'
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (101, N'sdvsdv', 2, 39)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (102, N'sdv', 3, 39)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (103, N'rrrr', 1, 40)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (104, N'rrrr', 2, 40)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (105, N'rrrrr', 3, 40)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (106, N'tttt', 1, 41)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (107, N'ttt', 2, 41)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (108, N'ttt', 3, 41)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (109, N'wwww', 1, 42)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (110, N'www', 2, 42)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (111, N'www', 3, 42)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (112, N'yyy', 1, 43)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (113, N'yy', 2, 43)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (114, N'yyy', 3, 43)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (115, N'xxx', 1, 44)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (116, N'xxxx', 2, 44)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (117, N'xxx', 3, 44)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (118, N'bb', 1, 45)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (119, N'bbb', 2, 45)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (120, N'bbbb', 3, 45)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (121, N'bby', 1, 46)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (122, N'bbby', 2, 46)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (123, N'bbbby', 3, 46)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (124, N'', 1, 47)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (125, N'2257-4373', 2, 47)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (126, N'', 3, 47)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (127, N'123123', 1, 48)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (128, N'098709', 2, 48)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (129, N'werwere', 3, 48)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (130, N'123', 1, 49)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (131, N'098', 2, 49)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (132, N'098', 3, 49)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (133, N'765564', 1, 50)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (134, N'65345', 2, 50)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (135, N'543453', 3, 50)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (136, N'sdfsdff', 1, 52)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (137, N'', 2, 52)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (138, N'', 3, 52)
SET IDENTITY_INSERT [dbo].[PersonPhone] OFF
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 02/02/2012 17:35:52 ******/
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
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (65, N'002219')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (66, N'002551')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (64, N'002662')
/****** Object:  Table [dbo].[Employee]    Script Date: 02/02/2012 17:35:53 ******/
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
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
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
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 02/02/2012 17:35:54 ******/
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
/****** Object:  Table [dbo].[Project]    Script Date: 02/02/2012 17:35:55 ******/
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
	[StateId] [int] NOT NULL,
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
INSERT [dbo].[Project] ([Id], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments], [StateId]) VALUES (1, 1, 1, 1, N'Proyecto Arosi', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO', 1)
INSERT [dbo].[Project] ([Id], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments], [StateId]) VALUES (2, 1, 1, 1, N'Casa Octavio Silva', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO', 1)
SET IDENTITY_INSERT [dbo].[Project] OFF
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 02/02/2012 17:35:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequestDetail](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[BudgetRequestCondition]    Script Date: 02/02/2012 17:35:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequestCondition](
	[BudgetRequestId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[Period] [decimal](4, 1) NOT NULL,
	[Warranty] [decimal](4, 1) NOT NULL,
	[SafetyCourse] [decimal](4, 1) NOT NULL,
	[MaximunHeight] [decimal](4, 1) NOT NULL,
	[Observations] [text] NOT NULL,
	[Monday] [bit] NOT NULL,
	[Tuesday] [bit] NOT NULL,
	[Wednesday] [bit] NOT NULL,
	[Thursday] [bit] NOT NULL,
	[Friday] [bit] NOT NULL,
	[Saturday] [bit] NOT NULL,
	[Sunday] [bit] NOT NULL,
	[DayTurn] [bit] NOT NULL,
	[NightTurn] [bit] NOT NULL,
	[DrinkableWater] [bit] NOT NULL,
	[Electricity] [bit] NOT NULL,
	[Warehouse] [bit] NOT NULL,
	[WorkInside] [bit] NOT NULL,
	[WorkOutside] [bit] NOT NULL,
	[Reachable] [bit] NOT NULL,
	[Ventilation] [bit] NOT NULL,
	[Toilet] [bit] NOT NULL,
	[Moisture] [bit] NOT NULL,
	[Wet] [bit] NOT NULL,
	[Noise] [bit] NOT NULL,
	[Dust] [bit] NOT NULL,
	[Lodging] [bit] NOT NULL,
	[Food] [bit] NOT NULL,
 CONSTRAINT [PK_BudgetRequestConditions_1] PRIMARY KEY CLUSTERED 
(
	[BudgetRequestId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (1, CAST(0x00009FE800000000 AS DateTime), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), N'algo', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1)
/****** Object:  Table [dbo].[Task]    Script Date: 02/02/2012 17:35:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Task](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
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
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (1, 1, 1, N'Tarea 1', N'3.00:00:00', 0, CAST(0x00009FB700000000 AS DateTime), CAST(0x00009FBA00000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x00009FB700000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FB9018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (2, 2, 1, N'Tarea 1', N'7.00:00:00', 0, CAST(0x00009FA800000000 AS DateTime), CAST(0x00009FAF00000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x00009FA900000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'7.00:00:00', CAST(0x00009FAE018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (3, 1, 1, N'Tarea 2', N'1.00:00:00', 0, CAST(0x00009FB700000000 AS DateTime), CAST(0x00009FB800000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x00009FB700000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB7018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (4, 2, 1, N'Tarea 2', N'2.00:00:00', 0, CAST(0x00009FA800000000 AS DateTime), CAST(0x00009FAA00000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x00009FA800000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FA9018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (5, 1, 1, N'Tarea 3', N'1.00:00:00', 0, CAST(0x00009FB800000000 AS DateTime), CAST(0x00009FB900000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x00009FB800000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB8018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (6, 2, 1, N'Tarea 3', N'3.00:00:00', 0, CAST(0x00009FAA00000000 AS DateTime), CAST(0x00009FAD00000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x00009FAB00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FAC018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (7, 1, 1, N'Tarea 4', N'1.00:00:00', 0, CAST(0x00009FB900000000 AS DateTime), CAST(0x00009FBA00000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x00009FB900000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB9018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (8, 2, 1, N'Tarea 4', N'2.00:00:00', 0, CAST(0x00009FAD00000000 AS DateTime), CAST(0x00009FAF00000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x00009FAD00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FAE018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (9, 2, 1, N'Tarea 5', N'1.00:00:00', 0, CAST(0x00009FAD00000000 AS DateTime), CAST(0x00009FAE00000000 AS DateTime), N'Ninguna', 5, -1, CAST(0x00009FAD00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FAD018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (10, 2, 1, N'Tarea 6', N'2.00:00:00', 0, CAST(0x00009FAE00000000 AS DateTime), CAST(0x00009FB000000000 AS DateTime), N'Ninguna', 6, -1, CAST(0x00009FAE00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FAF018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (11, 2, 1, N'Tarea 7', N'6.00:00:00', 0, CAST(0x00009FB000000000 AS DateTime), CAST(0x00009FB600000000 AS DateTime), N'Ninguna', 7, -1, CAST(0x00009FB000000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'6.00:00:00', CAST(0x00009FB5018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (12, 2, 1, N'Tarea 8', N'1.00:00:00', 0, CAST(0x00009FB000000000 AS DateTime), CAST(0x00009FB100000000 AS DateTime), N'Ninguna', 8, -1, CAST(0x00009FB000000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x00009FB0018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (13, 2, 1, N'Tarea 9', N'2.00:00:00', 0, CAST(0x00009FB100000000 AS DateTime), CAST(0x00009FB300000000 AS DateTime), N'Ninguna', 9, -1, CAST(0x00009FB100000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x00009FB2018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (14, 2, 1, N'Tarea 10', N'3.00:00:00', 0, CAST(0x00009FB300000000 AS DateTime), CAST(0x00009FB600000000 AS DateTime), N'Ninguna', 10, -1, CAST(0x00009FB300000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x00009FB5018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Task] OFF
/****** Object:  Table [dbo].[Resource]    Script Date: 02/02/2012 17:35:56 ******/
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
INSERT [dbo].[Resource] ([Id], [MeasureId], [ResourceTypeId], [TaskId], [Code], [Name], [Amount], [Cost], [TotalCost], [RealUsed]) VALUES (1, 1, 1, 1, N'1', N'ALQ-01', 55, 40.0000, 2200.0000, 50)
SET IDENTITY_INSERT [dbo].[Resource] OFF
/****** Object:  Table [dbo].[Dependencies]    Script Date: 02/02/2012 17:35:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Dependencies](
	[TaskId] [bigint] NOT NULL,
	[DependencyId] [bigint] NOT NULL,
 CONSTRAINT [PK_Dependencies] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC,
	[DependencyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer]  WITH CHECK ADD  CONSTRAINT [FK_BindCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] CHECK CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequest_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_BudgetRequestConditions_BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] CHECK CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 02/02/2012 17:35:52 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest] FOREIGN KEY([ApplicationRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 02/02/2012 17:35:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 02/02/2012 17:35:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 02/02/2012 17:35:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 02/02/2012 17:35:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task1] FOREIGN KEY([DependencyId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 02/02/2012 17:35:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 02/02/2012 17:35:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 02/02/2012 17:35:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 02/02/2012 17:35:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 02/02/2012 17:35:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 02/02/2012 17:35:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 02/02/2012 17:35:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Customer] FOREIGN KEY([CustumerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_ProjectState]    Script Date: 02/02/2012 17:35:55 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_ProjectState] FOREIGN KEY([StateId])
REFERENCES [dbo].[ProjectState] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_ProjectState]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceTypeId])
REFERENCES [dbo].[ResourceType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Stock_Item]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Item]
GO
/****** Object:  ForeignKey [FK_Stock_Warehouse]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Warehouse] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[Warehouse] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Warehouse]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 02/02/2012 17:35:56 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
