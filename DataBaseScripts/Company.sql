USE [COMPANY]
GO
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_CustomerContact]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_CustomerContact]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_CustomerContact]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Family]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Family]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_PersonPhone]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_PersonPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_PersonPhone]
GO
/****** Object:  ForeignKey [FK_BudgetRequestConditions_BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] DROP CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_Item]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_Item]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_SubFamily]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubFamily]') AND parent_object_id = OBJECT_ID(N'[dbo].[Family]'))
ALTER TABLE [dbo].[Family] DROP CONSTRAINT [FK_SubFamily]
GO
/****** Object:  ForeignKey [FK_Item_Family]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Item_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Item]'))
ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_Family]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_ProjectState]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_ProjectState]
GO
/****** Object:  ForeignKey [FK_ProjectInform_Project]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] DROP CONSTRAINT [FK_ProjectInform_Project]
GO
/****** Object:  ForeignKey [FK_ProjectInform_ProjectState]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] DROP CONSTRAINT [FK_ProjectInform_ProjectState]
GO
/****** Object:  ForeignKey [FK_RentalItem_Family]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalItem_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalItem]'))
ALTER TABLE [dbo].[RentalItem] DROP CONSTRAINT [FK_RentalItem_Family]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Stock_Item]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Item]
GO
/****** Object:  ForeignKey [FK_Stock_Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Warehouse]
GO
/****** Object:  ForeignKey [FK_Storage_RentalItem]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_RentalItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] DROP CONSTRAINT [FK_Storage_RentalItem]
GO
/****** Object:  ForeignKey [FK_Storage_Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] DROP CONSTRAINT [FK_Storage_Warehouse]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
/****** Object:  Table [dbo].[Dependencies]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] DROP CONSTRAINT [FK_Dependencies_Task1]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dependencies]') AND type in (N'U'))
DROP TABLE [dbo].[Dependencies]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 04/23/2012 12:58:41 ******/
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
/****** Object:  Table [dbo].[ProjectInform]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] DROP CONSTRAINT [FK_ProjectInform_Project]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] DROP CONSTRAINT [FK_ProjectInform_ProjectState]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectInform]') AND type in (N'U'))
DROP TABLE [dbo].[ProjectInform]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_Project]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
DROP TABLE [dbo].[Task]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 04/23/2012 12:58:41 ******/
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
/****** Object:  Table [dbo].[BudgetRequestCondition]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] DROP CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestCondition]
GO
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] DROP CONSTRAINT [FK_BudgetRequestDetail_Item]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequestDetail]
GO
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_ApplicationRequest_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_CustomerContact]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_CustomerContact]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Employee]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_Family]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_PersonPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] DROP CONSTRAINT [FK_BudgetRequest_PersonPhone]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
DROP TABLE [dbo].[BudgetRequest]
GO
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] DROP CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeeXCustomer]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Item]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [FK_Stock_Warehouse]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Stock_MaximunDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Stock] DROP CONSTRAINT [DF_Stock_MaximunDiscount]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Stock]') AND type in (N'U'))
DROP TABLE [dbo].[Stock]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_RentalItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] DROP CONSTRAINT [FK_Storage_RentalItem]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] DROP CONSTRAINT [FK_Storage_Warehouse]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Storage]') AND type in (N'U'))
DROP TABLE [dbo].[Storage]
GO
/****** Object:  Table [dbo].[RentalItem]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalItem_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalItem]'))
ALTER TABLE [dbo].[RentalItem] DROP CONSTRAINT [FK_RentalItem_Family]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalItem_RentalCost]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalItem] DROP CONSTRAINT [DF_RentalItem_RentalCost]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalItem_MaximunDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalItem] DROP CONSTRAINT [DF_RentalItem_MaximunDiscount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalItem_FamilyId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalItem] DROP CONSTRAINT [DF_RentalItem_FamilyId]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalItem]') AND type in (N'U'))
DROP TABLE [dbo].[RentalItem]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Customer]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] DROP CONSTRAINT [FK_CustomerContact_Person]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerContact]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerContact]
GO
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 04/23/2012 12:58:39 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] DROP CONSTRAINT [FK_BindCustomer_Customer]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BindCustomer]') AND type in (N'U'))
DROP TABLE [dbo].[BindCustomer]
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_Person]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] DROP CONSTRAINT [FK_PersonPhone_PhoneType]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonPhone]') AND type in (N'U'))
DROP TABLE [dbo].[PersonPhone]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Item_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Item]'))
ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Item_Family]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Item_MaximunDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Item] DROP CONSTRAINT [DF_Item_MaximunDiscount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Item_FamilyId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Item] DROP CONSTRAINT [DF_Item_FamilyId]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
DROP TABLE [dbo].[Item]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Person]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Employee_SalaryByHour]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [DF_Employee_SalaryByHour]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Measure]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Measure]') AND type in (N'U'))
DROP TABLE [dbo].[Measure]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Person]') AND type in (N'U'))
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 04/23/2012 12:58:41 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhoneType]') AND type in (N'U'))
DROP TABLE [dbo].[PhoneType]
GO
/****** Object:  Table [dbo].[Family]    Script Date: 04/23/2012 12:58:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubFamily]') AND parent_object_id = OBJECT_ID(N'[dbo].[Family]'))
ALTER TABLE [dbo].[Family] DROP CONSTRAINT [FK_SubFamily]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Family_MaximunDiscount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Family] DROP CONSTRAINT [DF_Family_MaximunDiscount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Family_MinimunProfit]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Family] DROP CONSTRAINT [DF_Family_MinimunProfit]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Family]') AND type in (N'U'))
DROP TABLE [dbo].[Family]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResourceType]') AND type in (N'U'))
DROP TABLE [dbo].[ResourceType]
GO
/****** Object:  Table [dbo].[State]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[State]') AND type in (N'U'))
DROP TABLE [dbo].[State]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Warehouse]') AND type in (N'U'))
DROP TABLE [dbo].[Warehouse]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
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
/****** Object:  Table [dbo].[State]    Script Date: 04/23/2012 12:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[State]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[State](
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
SET IDENTITY_INSERT [dbo].[State] ON
INSERT [dbo].[State] ([Id], [Name]) VALUES (1, N'Activo')
INSERT [dbo].[State] ([Id], [Name]) VALUES (2, N'Terminado')
SET IDENTITY_INSERT [dbo].[State] OFF
/****** Object:  Table [dbo].[ResourceType]    Script Date: 04/23/2012 12:58:42 ******/
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
/****** Object:  Table [dbo].[Family]    Script Date: 04/23/2012 12:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Family]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Family](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FamilyId] [int] NOT NULL,
	[Code] [nchar](10) NOT NULL,
	[MaximunDiscount] [decimal](6, 4) NOT NULL CONSTRAINT [DF_Family_MaximunDiscount]  DEFAULT ((0)),
	[MinimunProfit] [decimal](6, 4) NOT NULL CONSTRAINT [DF_Family_MinimunProfit]  DEFAULT ((1)),
 CONSTRAINT [PK_Family] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Family] ON
INSERT [dbo].[Family] ([Id], [Name], [FamilyId], [Code], [MaximunDiscount], [MinimunProfit]) VALUES (0, N'Base', 0, N'0         ', CAST(0.0000 AS Decimal(6, 4)), CAST(1.0000 AS Decimal(6, 4)))
INSERT [dbo].[Family] ([Id], [Name], [FamilyId], [Code], [MaximunDiscount], [MinimunProfit]) VALUES (1, N'Quimicos', 0, N'QUI       ', CAST(15.0000 AS Decimal(6, 4)), CAST(1.0000 AS Decimal(6, 4)))
SET IDENTITY_INSERT [dbo].[Family] OFF
/****** Object:  Table [dbo].[PhoneType]    Script Date: 04/23/2012 12:58:41 ******/
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
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (7, N'Celular')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (8, N'Oficina')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (9, N'Casa')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (10, N'Celular')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (11, N'Oficina')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (12, N'Casa')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (13, N'Celular')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (14, N'Oficina')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (15, N'Casa')
SET IDENTITY_INSERT [dbo].[PhoneType] OFF
/****** Object:  Table [dbo].[Person]    Script Date: 04/23/2012 12:58:41 ******/
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
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (54, N'sdsdasd', N'dasdasd')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (55, N'sdaf', N'asdf')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (56, N'aaaaaaa', N'aaaaa')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (57, N'El pelon', N'Calvo')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (58, N'JUAN CARLOS RODRIGUEZ', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (59, N'Jaime', N'Torner')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (60, N'Jose Luis', N'Alvarado')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (61, N'Jaime', N'Torner')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (62, N'Jose Luis', N'Alvarado')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (63, N'Otro', N'Contacto')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (64, N'Jose Luis', N'Alvarado')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (65, N'nevo ', N'ppsad')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (66, N'porque', N'no ')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (67, N'GUILLERMO ALVAREZ 8824-2222/ DAISY', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (68, N'GUILLERMO ALVAREZ 8824-2222/ DAISY', N'')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (69, N'lkjlkjlk', N'jlkjlkjlk')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (70, N'098098', N'09')
INSERT [dbo].[Person] ([Id], [Name], [LastName]) VALUES (71, N'carmen', N'elia')
SET IDENTITY_INSERT [dbo].[Person] OFF
/****** Object:  Table [dbo].[Measure]    Script Date: 04/23/2012 12:58:41 ******/
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
INSERT [dbo].[Measure] ([Id], [Name], [Symbol]) VALUES (3, N'Metro Cuadrado', N'm²')
INSERT [dbo].[Measure] ([Id], [Name], [Symbol]) VALUES (4, N'Metro', N'm')
SET IDENTITY_INSERT [dbo].[Measure] OFF
/****** Object:  Table [dbo].[Customer]    Script Date: 04/23/2012 12:58:40 ******/
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
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (67, N'EL PELON DE LA BAJURA S.A', N'RADIAL SAN SANTONIO DE BELEN ENTRADA PRINCIPAL DE MATRA 175 ESTE', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (68, N'ABBOTT BUILDING SHELL', N'LOS YOSES', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (69, N'ABBOTT BUILDING SHELL', N'LOS YOSES', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (70, N'ABBOTT BUILDING SHELL', N'LOS YOSES', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (71, N'A LA FIESTA TOTAL S.A.', N'LA URUCA DE CAPRIS 75 NORTE, MANO IZQ, EDIFICIO DE COLOR AZUL DE DOS PLANTAS. TOLDO  COLOR BLANCO EN LA ENTRADA ', NULL, NULL, NULL)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (72, N'oikjhlkjhlk', N'jlkjlkjlk', N'kljlkjlkjlkj', N'lkjlkjlkjkl', N'lkjlkj')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (73, N'098098098', N'80', N'98', N'809', N'09')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [AddressOptional], [Phone], [Fax]) VALUES (74, N'Edificar', N'kjhkjhj', N'jkhjkh', N'5665', N'534534')
SET IDENTITY_INSERT [dbo].[Customer] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 04/23/2012 12:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[Code] [varchar](30) NOT NULL,
	[UserAccountId] [int] NOT NULL,
	[SalaryByHour] [money] NOT NULL CONSTRAINT [DF_Employee_SalaryByHour]  DEFAULT ((0)),
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([Id], [PersonId], [Code], [UserAccountId], [SalaryByHour]) VALUES (1, 1, N'12', 1, 0.0000)
INSERT [dbo].[Employee] ([Id], [PersonId], [Code], [UserAccountId], [SalaryByHour]) VALUES (2, 2, N'1314', 3, 0.0000)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  Table [dbo].[Item]    Script Date: 04/23/2012 12:58:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
	[Price] [money] NOT NULL,
	[IsTaxed] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[MaximunDiscount] [decimal](6, 4) NOT NULL CONSTRAINT [DF_Item_MaximunDiscount]  DEFAULT ((0)),
	[WasDeleted] [bit] NOT NULL,
	[FamilyId] [int] NOT NULL CONSTRAINT [DF_Item_FamilyId]  DEFAULT ((0)),
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (0, N'APLICACION DE IMPERM. ACRILICO Y TELA DE REFUERZO', N'A-SER-001-80', 0.0000, 0.0000, 1, CAST(0x0000A00601861D9C AS DateTime), CAST(0x0000A00601861D9C AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (2, N'FLOOR - FLOOR EXP. JT SYS', N'V-MMS-LASD-3-1.5', 89.1700, 0.0000, 1, CAST(0x0000A006018842E9 AS DateTime), CAST(0x0000A006018842E9 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (3, N'ADOBE BUFF LIQ DISPERSION', N'V-INC-DIS-AD', 36.7700, 73.5400, 1, CAST(0x0000A00B0185CA20 AS DateTime), CAST(0x0000A00B0185CA20 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (4, N'BEARING ASSY CPM8', N'V-ICX-65057', 132.6000, 0.0000, 1, CAST(0x0000A00C00009677 AS DateTime), CAST(0x0000A00C00009677 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (5, N'GUANTE CUERO LONA REFOR.PALMA DEDOS', N'V-PS-1008-03', 2.4300, 0.0000, 0, CAST(0x0000A00C0013601F AS DateTime), CAST(0x0000A00C0013601F AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (6, N'ACUAPOXY B ESTAÑON', N'V-EDC-730-02', 1043.4400, 0.0000, 1, CAST(0x0000A00C001386AA AS DateTime), CAST(0x0000A00C001386AA AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (7, N'MASKING TAPE 50 MM.', N'V-BDF-728-10', 1.3700, 0.0000, 0, CAST(0x0000A00C00B12640 AS DateTime), CAST(0x0000A00C00B12640 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (8, N'MASKING TAPE 50 MM.', N'V-BDF-728-10', 1.3700, 0.0000, 0, CAST(0x0000A00C00B193EA AS DateTime), CAST(0x0000A00C00B193EA AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (9, N'PADSA IMPAC 5000 BLANCO 5 GLS', N'V-PAD-200-23', 31.1300, 0.0000, 1, CAST(0x0000A00C00B88595 AS DateTime), CAST(0x0000A00C00B88595 AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (10, N'WEARGUARD-SDS PT A 2 GAL', N'V-TEN-60670-13', 458.1900, 0.0000, 1, CAST(0x0000A00C00D6556B AS DateTime), CAST(0x0000A00C00D6556B AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (11, N'LYTOC (20 KG)', N'V-TOX-EXP-01', 53.0700, 99.5400, 1, CAST(0x0000A00C00D6E55B AS DateTime), CAST(0x0000A00C00D6E55B AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (12, N'COLORANT, IVY GREEN, 1 PT', N'V-TEN-60608', 22.9800, 0.0000, 1, CAST(0x0000A00C00D996CB AS DateTime), CAST(0x0000A00C00D996CB AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (13, N'FAST DRY AMARILLO JOHN DEERE', N'V-FAS-DRY-11', 35.1900, 0.0000, 0, CAST(0x0000A00C00D9FD18 AS DateTime), CAST(0x0000A00C00D9FD18 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (14, N'SF BONDING ADDITIVE 4 OZ', N'V-TEN-08533413', 38.7700, 77.5400, 1, CAST(0x0000A00C00DA1524 AS DateTime), CAST(0x0000A00C00DA1524 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (15, N'36 ROLLER SQUEEGEE YELLOW', N'V-ICX-SQU-YE', 113.9700, 0.0000, 1, CAST(0x0000A00C00DA3816 AS DateTime), CAST(0x0000A00C00DA3816 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (16, N'ANTIQUE 102 SANDED', N'V-FR6-25L-03', 0.0100, 0.0000, 1, CAST(0x0000A00C00DA69DB AS DateTime), CAST(0x0000A00C00DA69DB AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (17, N'1/4" MARINA BLK SOLID FLAKE #50', N'V-TEN-9000640', 190.2300, 0.0000, 1, CAST(0x0000A00C00DA7920 AS DateTime), CAST(0x0000A00C00DA7920 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (18, N'ACARREOS', N'A-SER-001-10', 0.0000, 0.0100, 0, CAST(0x0000A00C00DA9155 AS DateTime), CAST(0x0000A00C00DA9155 AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (19, N'1/4" BROWN HI INTENSITY FLAKE #50', N'V-TEN-9000661', 225.3400, 0.0000, 1, CAST(0x0000A00C00E38814 AS DateTime), CAST(0x0000A00C00E38814 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (20, N'ACUAPOXY B ESTAÑON', N'V-EDC-730-02', 1043.4400, 0.0000, 1, CAST(0x0000A00C00E4F212 AS DateTime), CAST(0x0000A00C00E4F212 AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (21, N'FLOOR - WALL EXP. JT SYS', N'V-MMS-LASDE-3-1.5', 67.9200, 0.0000, 1, CAST(0x0000A00C00E5A305 AS DateTime), CAST(0x0000A00C00E5A305 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (22, N'WEARGUARD-SDS PT A 2 GAL', N'V-TEN-60670-13', 458.1900, 0.0000, 1, CAST(0x0000A00C00E6191E AS DateTime), CAST(0x0000A00C00E6191E AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (23, N'1/4" EGGSHELL WHITE SOLID FLAKE #50', N'V-TEN-9000660', 225.3400, 0.0000, 1, CAST(0x0000A00C00E6FBA0 AS DateTime), CAST(0x0000A00C00E6FBA0 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (24, N'ARENA P/MORTERO EPOXICO TRASNPARENTE', N'V-GRA-SIL-02', 5.0100, 10.0200, 1, CAST(0x0000A00C00ECAC8C AS DateTime), CAST(0x0000A00C00ECAC8C AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (25, N'36" FLOWER ROCK SET', N'V-INC-FRS-36', 0.0000, 0.0000, 1, CAST(0x0000A00C00ED2260 AS DateTime), CAST(0x0000A00C00ED2260 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (26, N'36" FLOWER ROCK SET', N'V-INC-FRS-36', 0.0000, 0.0000, 1, CAST(0x0000A00C00ED2260 AS DateTime), CAST(0x0000A00C00ED2260 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (27, N'BURKE EPOXY REFLEX JOINT FILLER (10 GLS)', N'V-BUR-711-10', 249.0400, 425.3389, 1, CAST(0x0000A00D01233588 AS DateTime), CAST(0x0000A00D01233588 AS DateTime), CAST(20.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (28, N'AIRTOC D CUBETA 5 GALONES', N'V-TOX-AIR-05', 18.7300, 35.7200, 1, CAST(0x0000A00D01265080 AS DateTime), CAST(0x0000A00D01265080 AS DateTime), CAST(26.0000 AS Decimal(6, 4)), 0, 0)
INSERT [dbo].[Item] ([Id], [Name], [Code], [Cost], [Price], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (29, N'ECO-CFO PART B 0.71 GAL', N'V-TEN-9001662', 56.6500, 141.6300, 1, CAST(0x0000A00D0127759B AS DateTime), CAST(0x0000A00D0127759B AS DateTime), CAST(15.0000 AS Decimal(6, 4)), 0, 0)
SET IDENTITY_INSERT [dbo].[Item] OFF
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 04/23/2012 12:58:41 ******/
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
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (139, N'4234324', 1, 54)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (140, N'234234', 2, 54)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (141, N'', 3, 54)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (142, N'asdf', 1, 55)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (143, N'asdf', 2, 55)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (144, N'sdf', 3, 55)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (145, N'aaaaaa', 1, 56)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (146, N'aaaaaa', 2, 56)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (147, N'aaaa', 3, 56)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (148, N'123123', 1, 57)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (149, N'987987', 2, 57)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (150, N'987987', 3, 57)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (151, N'234', 7, 59)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (152, N'765564', 7, 60)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (153, N'234', 8, 59)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (154, N'65345', 8, 60)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (155, N'234', 9, 59)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (156, N'543453', 9, 60)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (157, N'0923840', 10, 61)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (158, N'765564', 10, 62)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (159, N'0980998', 11, 61)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (160, N'65345', 11, 62)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (161, N'7867867', 12, 61)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (162, N'543453', 12, 62)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (163, N'234234', 13, 63)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (164, N'765564', 13, 64)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (165, N'56464577', 14, 63)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (166, N'65345', 14, 64)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (167, N'876', 15, 63)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (168, N'543453', 15, 64)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (169, N'jklj', 6, 65)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (170, N'klj', 2, 65)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (171, N'kl', 3, 65)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (172, N'cochinanda', 1, 66)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (173, N'jueputa', 2, 66)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (174, N'', 3, 66)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (175, N'234234325', 1, 68)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (176, N'897987', 2, 68)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (177, N'0987', 3, 68)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (178, N'lkjlkjl', 2, 69)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (179, N'lkjlkjlkj', 2, 69)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (180, N'lkjlkjlkj', 3, 69)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (181, N'098098', 1, 70)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (182, N'098098', 2, 70)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (183, N'09809', 3, 70)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (184, N'765765', 1, 71)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (185, N'676876', 2, 71)
INSERT [dbo].[PersonPhone] ([Id], [Phone], [PhoneTypeId], [PersonId]) VALUES (186, N'876876', 3, 71)
SET IDENTITY_INSERT [dbo].[PersonPhone] OFF
/****** Object:  Table [dbo].[BindCustomer]    Script Date: 04/23/2012 12:58:39 ******/
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
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (71, N'001714')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (28, N'001806')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (65, N'002219')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (66, N'002551')
INSERT [dbo].[BindCustomer] ([CustomerId], [AlienId]) VALUES (64, N'002662')
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 04/23/2012 12:58:40 ******/
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
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (53, N'asdsdas', 54, 65, N'asdasdas')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (54, N'asdf', 55, 27, N'asdf')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (55, N'aaaa', 56, 65, N'aaaaa')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (56, N'oikjikj', 57, 67, N'lkj')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (57, N'Funcionario', 58, 67, N'no@email.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (58, N'Programador', 59, 68, N'werwewerwe')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (59, N'Informatica', 60, 68, N'kugy@tjfy.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (60, N'Programador', 61, 69, N'sdfs@sdfsdf.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (61, N'Informatica', 62, 69, N'kugy@tjfy.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (62, N'sdfgs', 63, 70, N'sgdfg')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (63, N'Informatica', 64, 70, N'kugy@tjfy.com')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (64, N'ko', 65, 70, N'k')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (65, N'quiere', 66, 70, N'sirvir esta')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (66, N'Funcionario', 68, 71, N'email@no.disponible')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (67, N'jlkjlkjlkj', 69, 72, N'lkjlkjklj')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (68, N'80', 70, 73, N'98098098')
INSERT [dbo].[CustomerContact] ([Id], [Job], [PersonId], [CustomerId], [Email]) VALUES (69, N'vendedora', 71, 74, N'correo@sdcscdds.com')
SET IDENTITY_INSERT [dbo].[CustomerContact] OFF
/****** Object:  Table [dbo].[RentalItem]    Script Date: 04/23/2012 12:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RentalItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Cost] [money] NOT NULL,
	[Price] [money] NOT NULL,
	[MonthlyPrice] [money] NOT NULL CONSTRAINT [DF_RentalItem_RentalCost]  DEFAULT ((0)),
	[FortnightPrice] [money] NOT NULL,
	[WeeklyPrice] [money] NOT NULL,
	[DailyPrice] [money] NOT NULL,
	[IsTaxed] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[MaximunDiscount] [decimal](6, 4) NOT NULL CONSTRAINT [DF_RentalItem_MaximunDiscount]  DEFAULT ((0)),
	[WasDeleted] [bit] NOT NULL,
	[FamilyId] [int] NOT NULL CONSTRAINT [DF_RentalItem_FamilyId]  DEFAULT ((0)),
 CONSTRAINT [PK_RentalItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[RentalItem] ON
INSERT [dbo].[RentalItem] ([Id], [Name], [Code], [Cost], [Price], [MonthlyPrice], [FortnightPrice], [WeeklyPrice], [DailyPrice], [IsTaxed], [DateCreated], [DateModified], [MaximunDiscount], [WasDeleted], [FamilyId]) VALUES (1, N'MOLDE DE FORMALETA 0.20 X 1.22 (8 IN X 4 FT)', N'R-TER-125-20', 48096.8200, 48096.8200, 5.5000, 3.8000, 0.0000, 0.0000, 0, CAST(0x0000A01600C0F067 AS DateTime), CAST(0x0000A01600FC2D27 AS DateTime), CAST(0.0000 AS Decimal(6, 4)), 0, 0)
SET IDENTITY_INSERT [dbo].[RentalItem] OFF
/****** Object:  Table [dbo].[Storage]    Script Date: 04/23/2012 12:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Storage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Storage](
	[RentalItemId] [int] NOT NULL,
	[WarehouseId] [int] NOT NULL,
	[Quantity] [decimal](18, 6) NOT NULL,
	[MaximunDiscount] [int] NOT NULL,
	[MinimunCount] [int] NOT NULL,
	[Available] [decimal](18, 6) NOT NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[RentalItemId] ASC,
	[WarehouseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 04/23/2012 12:58:42 ******/
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
	[MaximunDiscount] [decimal](6, 4) NOT NULL CONSTRAINT [DF_Stock_MaximunDiscount]  DEFAULT ((0)),
	[MinimumCount] [int] NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC,
	[WarehouseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EmployeeXCustomer]    Script Date: 04/23/2012 12:58:40 ******/
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
/****** Object:  Table [dbo].[BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequest]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequest](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ProjectName] [varchar](50) NOT NULL,
	[DateCreated] [date] NOT NULL,
	[DateModified] [date] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[CustomerContactId] [int] NOT NULL,
	[PersonPhoneId] [int] NOT NULL,
	[FamilyId] [int] NOT NULL,
 CONSTRAINT [PK_ApplicationRequest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BudgetRequest] ON
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (0, 29, N'lkhj', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (1, 29, N'PROYECTO 1', CAST(0x0A350B00 AS Date), CAST(0x0A350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (2, 29, N'otro', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (3, 29, N'otro', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (4, 29, N'otro', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (5, 29, N'los alpes', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (7, 29, N'kkjkjkj', CAST(0x00000000 AS Date), CAST(0x49350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (8, 29, N'La pampa', CAST(0x00000000 AS Date), CAST(0x4B350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (9, 29, N'La pampa', CAST(0x00000000 AS Date), CAST(0x4B350B00 AS Date), 1, 50, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (10, 29, N'Test ME', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (11, 65, N'asdasdas', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 53, 139, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (12, 29, N'caca', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (13, 29, N'caca 1', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (14, 29, N'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (15, 29, N'bbbbbbbbbbbbbbbbbbbbbbbbbbbbb', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 49, 133, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (17, 29, N'preuebea asdlaskdl', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 62, 163, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (18, 69, N'preuebea asdlaskdl', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 61, 162, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (19, 70, N'preuebea asdlaskdl', CAST(0x00000000 AS Date), CAST(0x50350B00 AS Date), 1, 65, 173, 1)
INSERT [dbo].[BudgetRequest] ([Id], [CustomerId], [ProjectName], [DateCreated], [DateModified], [EmployeeId], [CustomerContactId], [PersonPhoneId], [FamilyId]) VALUES (20, 70, N'dfgfdgfdg', CAST(0x00000000 AS Date), CAST(0x67350B00 AS Date), 1, 63, 166, 1)
SET IDENTITY_INSERT [dbo].[BudgetRequest] OFF
/****** Object:  Table [dbo].[BudgetRequestDetail]    Script Date: 04/23/2012 12:58:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BudgetRequestDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationRequestId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[MeasureId] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[BudgetRequestDetail] ON
INSERT [dbo].[BudgetRequestDetail] ([Id], [ApplicationRequestId], [ItemId], [MeasureId], [ItemName], [Quantity], [Problem], [Solution]) VALUES (0, 20, 26, 3, N'36" FLOWER ROCK SET', 1, N'tretret', N'eretert')
INSERT [dbo].[BudgetRequestDetail] ([Id], [ApplicationRequestId], [ItemId], [MeasureId], [ItemName], [Quantity], [Problem], [Solution]) VALUES (2, 10, 27, 4, N'BURKE EPOXY REFLEX JOINT FILLER (10 GLS)', 1, N'sdfsdsd', N'cxczxczx')
SET IDENTITY_INSERT [dbo].[BudgetRequestDetail] OFF
/****** Object:  Table [dbo].[BudgetRequestCondition]    Script Date: 04/23/2012 12:58:39 ******/
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
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (0, CAST(0x00009FFF00000000 AS DateTime), CAST(4.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(3.0 AS Decimal(4, 1)), CAST(2.0 AS Decimal(4, 1)), N'ñlkjo', 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (1, CAST(0x00009FE800000000 AS DateTime), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), N'algo', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (2, CAST(0x00009FF700000000 AS DateTime), CAST(4.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), CAST(5.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), N'', 0, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (3, CAST(0x00009FF700000000 AS DateTime), CAST(4.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), CAST(5.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), N'liioujiouj', 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (4, CAST(0x00009FF700000000 AS DateTime), CAST(4.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), CAST(5.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), N'kljpk', 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (5, CAST(0x00009FF800000000 AS DateTime), CAST(1.0 AS Decimal(4, 1)), CAST(2.0 AS Decimal(4, 1)), CAST(3.0 AS Decimal(4, 1)), CAST(4.0 AS Decimal(4, 1)), N'Papas', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (7, CAST(0x00009FEE015CF6AD AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (8, CAST(0x00009FF000000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (9, CAST(0x00009FF000000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (10, CAST(0x00009FF500000000 AS DateTime), CAST(3.0 AS Decimal(4, 1)), CAST(3.0 AS Decimal(4, 1)), CAST(3.0 AS Decimal(4, 1)), CAST(3.0 AS Decimal(4, 1)), N'', 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (11, CAST(0x00009FF500000000 AS DateTime), CAST(2.0 AS Decimal(4, 1)), CAST(2.0 AS Decimal(4, 1)), CAST(2.0 AS Decimal(4, 1)), CAST(2.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (12, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (13, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (14, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (15, CAST(0x00009FF500000000 AS DateTime), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), CAST(1.0 AS Decimal(4, 1)), N'', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (17, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (18, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (19, CAST(0x00009FF500000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[BudgetRequestCondition] ([BudgetRequestId], [StartDate], [Period], [Warranty], [SafetyCourse], [MaximunHeight], [Observations], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday], [Sunday], [DayTurn], [NightTurn], [DrinkableWater], [Electricity], [Warehouse], [WorkInside], [WorkOutside], [Reachable], [Ventilation], [Toilet], [Moisture], [Wet], [Noise], [Dust], [Lodging], [Food]) VALUES (20, CAST(0x0000A00C00000000 AS DateTime), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), CAST(0.0 AS Decimal(4, 1)), N'', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
/****** Object:  Table [dbo].[Project]    Script Date: 04/23/2012 12:58:41 ******/
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
	[Code] [nchar](10) NOT NULL,
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
INSERT [dbo].[Project] ([Id], [Code], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments], [StateId]) VALUES (1, N'201202001 ', 1, 1, 1, N'Proyecto Arosi', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO', 1)
INSERT [dbo].[Project] ([Id], [Code], [BudgetRequestId], [CustumerId], [EmployeeId], [Name], [ManagementApproval], [CxcApproval], [CreateDate], [ContingenciesRate], [GuaranteeRate], [TotalUtilityRate], [DiscountRate], [SalesTax], [OthersRate], [Comments], [StateId]) VALUES (2, N'201202002 ', 1, 1, 1, N'Casa Octavio Silva', 0, 0, CAST(0x00009F9E00000000 AS DateTime), 5, 5, 50, 10, 13, 8, N'NINGUNO', 1)
SET IDENTITY_INSERT [dbo].[Project] OFF
/****** Object:  Table [dbo].[Task]    Script Date: 04/23/2012 12:58:42 ******/
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
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (15, 2, 0, N'Tarea 7', N'6.00:00:00', 0, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000A02800000000 AS DateTime), N'Ninguna', 7, -1, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'6.00:00:00', CAST(0x0000A027018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (16, 2, 0, N'Tarea 1', N'7.00:00:00', 0, CAST(0x0000A01B00000000 AS DateTime), CAST(0x0000A02200000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x0000A01B00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'7.00:00:00', CAST(0x0000A021018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (17, 2, 0, N'Tarea 3', N'3.00:00:00', 0, CAST(0x0000A01D00000000 AS DateTime), CAST(0x0000A02000000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x0000A01D00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x0000A01F018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (18, 2, 0, N'Tarea 2', N'2.00:00:00', 0, CAST(0x0000A01B00000000 AS DateTime), CAST(0x0000A01D00000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x0000A01B00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x0000A01C018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (19, 2, 0, N'Tarea 4', N'2.00:00:00', 0, CAST(0x0000A02000000000 AS DateTime), CAST(0x0000A02200000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x0000A02000000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x0000A021018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (20, 2, 0, N'Tarea 5', N'1.00:00:00', 0, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000A02300000000 AS DateTime), N'Ninguna', 5, -1, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x0000A022018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (21, 2, 0, N'Tarea 6', N'2.00:00:00', 0, CAST(0x0000A02300000000 AS DateTime), CAST(0x0000A02500000000 AS DateTime), N'Ninguna', 6, -1, CAST(0x0000A02300000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x0000A024018B80D4 AS DateTime), 1, 1, 0, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (22, 2, 0, N'Tarea 9', N'2.00:00:00', 0, CAST(0x0000A02300000000 AS DateTime), CAST(0x0000A02500000000 AS DateTime), N'Ninguna', 9, -1, CAST(0x0000A02300000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'2.00:00:00', CAST(0x0000A024018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (23, 2, 0, N'Tarea 8', N'1.00:00:00', 0, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000A02300000000 AS DateTime), N'Ninguna', 8, -1, CAST(0x0000A02200000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x0000A022018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (24, 2, 0, N'Tarea 10', N'3.00:00:00', 0, CAST(0x0000A02500000000 AS DateTime), CAST(0x0000A02800000000 AS DateTime), N'Ninguna', 10, -1, CAST(0x0000A02500000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x0000A027018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (25, 1, 0, N'Tarea 1', N'3.00:00:00', 0, CAST(0x0000A01C00000000 AS DateTime), CAST(0x0000A01F00000000 AS DateTime), N'Ninguna', 1, -1, CAST(0x0000A01C00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'3.00:00:00', CAST(0x0000A01E018B80D4 AS DateTime), 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (26, 1, 0, N'Tarea 3', N'1.00:00:00', 0, CAST(0x0000A01D00000000 AS DateTime), CAST(0x0000A01E00000000 AS DateTime), N'Ninguna', 3, -1, CAST(0x0000A01D00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x0000A01D018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (27, 1, 0, N'Tarea 2', N'1.00:00:00', 0, CAST(0x0000A01C00000000 AS DateTime), CAST(0x0000A01D00000000 AS DateTime), N'Ninguna', 2, -1, CAST(0x0000A01C00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x0000A01C018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Task] ([Id], [ProjectId], [ParentId], [Name], [Duration], [PercentComplete], [StartDateTime], [EndDateTime], [Notes], [RowNumber], [BindingListIndex], [CompleteThrough], [DeadLine], [DurationResolved], [EndDateTimeResolved], [Expanded], [IsRoot], [IsSumary], [TaskLevel], [Milestone], [MilestoneResolved]) VALUES (28, 1, 0, N'Tarea 4', N'1.00:00:00', 0, CAST(0x0000A01E00000000 AS DateTime), CAST(0x0000A01F00000000 AS DateTime), N'Ninguna', 4, -1, CAST(0x0000A01E00000000 AS DateTime), CAST(0x0000901A00000000 AS DateTime), N'1.00:00:00', CAST(0x0000A01E018B80D4 AS DateTime), 1, 0, 0, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Task] OFF
/****** Object:  Table [dbo].[ProjectInform]    Script Date: 04/23/2012 12:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectInform]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProjectInform](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[StateId] [int] NOT NULL,
	[WasDeleted] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[Advanced] [decimal](3, 2) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_ProjectInform] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 04/23/2012 12:58:41 ******/
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
INSERT [dbo].[Resource] ([Id], [MeasureId], [ResourceTypeId], [TaskId], [Code], [Name], [Amount], [Cost], [TotalCost], [RealUsed]) VALUES (2, 1, 1, 25, N'1', N'ALQ-01', 55, 40.0000, 2200.0000, 50)
SET IDENTITY_INSERT [dbo].[Resource] OFF
/****** Object:  Table [dbo].[Dependencies]    Script Date: 04/23/2012 12:58:40 ******/
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
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (15, 16)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (17, 18)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (19, 17)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (20, 19)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (21, 20)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (22, 23)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (24, 22)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (26, 27)
INSERT [dbo].[Dependencies] ([TaskId], [DependencyId]) VALUES (28, 26)
/****** Object:  ForeignKey [FK_BindCustomer_Customer]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer]  WITH CHECK ADD  CONSTRAINT [FK_BindCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BindCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BindCustomer]'))
ALTER TABLE [dbo].[BindCustomer] CHECK CONSTRAINT [FK_BindCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_ApplicationRequest_Customer]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequest_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequest_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_ApplicationRequest_Customer]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_CustomerContact]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_CustomerContact]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_CustomerContact] FOREIGN KEY([CustomerContactId])
REFERENCES [dbo].[CustomerContact] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_CustomerContact]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_CustomerContact]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Employee]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_Employee]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_Family]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_Family] FOREIGN KEY([FamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_Family]
GO
/****** Object:  ForeignKey [FK_BudgetRequest_PersonPhone]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_PersonPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequest_PersonPhone] FOREIGN KEY([PersonPhoneId])
REFERENCES [dbo].[PersonPhone] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequest_PersonPhone]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequest]'))
ALTER TABLE [dbo].[BudgetRequest] CHECK CONSTRAINT [FK_BudgetRequest_PersonPhone]
GO
/****** Object:  ForeignKey [FK_BudgetRequestConditions_BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestConditions_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestCondition]'))
ALTER TABLE [dbo].[BudgetRequestCondition] CHECK CONSTRAINT [FK_BudgetRequestConditions_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_ApplicationRequestDetail_Measure]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationRequestDetail_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ApplicationRequestDetail_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_ApplicationRequestDetail_Measure]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_BudgetRequest]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest] FOREIGN KEY([ApplicationRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_BudgetRequestDetail_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_BudgetRequestDetail_Item]    Script Date: 04/23/2012 12:58:39 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail]  WITH CHECK ADD  CONSTRAINT [FK_BudgetRequestDetail_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BudgetRequestDetail_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[BudgetRequestDetail]'))
ALTER TABLE [dbo].[BudgetRequestDetail] CHECK CONSTRAINT [FK_BudgetRequestDetail_Item]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Customer]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer]
GO
/****** Object:  ForeignKey [FK_CustomerContact_Person]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerContact_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerContact]'))
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Person]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task]
GO
/****** Object:  ForeignKey [FK_Dependencies_Task1]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies]  WITH CHECK ADD  CONSTRAINT [FK_Dependencies_Task1] FOREIGN KEY([DependencyId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dependencies_Task1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Dependencies]'))
ALTER TABLE [dbo].[Dependencies] CHECK CONSTRAINT [FK_Dependencies_Task1]
GO
/****** Object:  ForeignKey [FK_Employee_Person]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Employee_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[Employee]'))
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Customer]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Customer]
GO
/****** Object:  ForeignKey [FK_EmployeeXCustomer_Employee]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeXCustomer_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EmployeeXCustomer_Employee]') AND parent_object_id = OBJECT_ID(N'[dbo].[EmployeeXCustomer]'))
ALTER TABLE [dbo].[EmployeeXCustomer] CHECK CONSTRAINT [FK_EmployeeXCustomer_Employee]
GO
/****** Object:  ForeignKey [FK_SubFamily]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubFamily]') AND parent_object_id = OBJECT_ID(N'[dbo].[Family]'))
ALTER TABLE [dbo].[Family]  WITH CHECK ADD  CONSTRAINT [FK_SubFamily] FOREIGN KEY([FamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SubFamily]') AND parent_object_id = OBJECT_ID(N'[dbo].[Family]'))
ALTER TABLE [dbo].[Family] CHECK CONSTRAINT [FK_SubFamily]
GO
/****** Object:  ForeignKey [FK_Item_Family]    Script Date: 04/23/2012 12:58:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Item_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Item]'))
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Family] FOREIGN KEY([FamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Item_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[Item]'))
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Family]
GO
/****** Object:  ForeignKey [FK_PersonPhone_Person]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_Person]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
/****** Object:  ForeignKey [FK_PersonPhone_PhoneType]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_PhoneType] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PersonPhone_PhoneType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PersonPhone]'))
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_PhoneType]
GO
/****** Object:  ForeignKey [FK_Project_BudgetRequest]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_BudgetRequest] FOREIGN KEY([BudgetRequestId])
REFERENCES [dbo].[BudgetRequest] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_BudgetRequest]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_BudgetRequest]
GO
/****** Object:  ForeignKey [FK_Project_Customer]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Customer] FOREIGN KEY([CustumerId])
REFERENCES [dbo].[Customer] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Customer]
GO
/****** Object:  ForeignKey [FK_Project_ProjectState]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_ProjectState] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_ProjectState]
GO
/****** Object:  ForeignKey [FK_ProjectInform_Project]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform]  WITH CHECK ADD  CONSTRAINT [FK_ProjectInform_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] CHECK CONSTRAINT [FK_ProjectInform_Project]
GO
/****** Object:  ForeignKey [FK_ProjectInform_ProjectState]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform]  WITH CHECK ADD  CONSTRAINT [FK_ProjectInform_ProjectState] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ProjectInform_ProjectState]') AND parent_object_id = OBJECT_ID(N'[dbo].[ProjectInform]'))
ALTER TABLE [dbo].[ProjectInform] CHECK CONSTRAINT [FK_ProjectInform_ProjectState]
GO
/****** Object:  ForeignKey [FK_RentalItem_Family]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalItem_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalItem]'))
ALTER TABLE [dbo].[RentalItem]  WITH CHECK ADD  CONSTRAINT [FK_RentalItem_Family] FOREIGN KEY([FamilyId])
REFERENCES [dbo].[Family] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalItem_Family]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalItem]'))
ALTER TABLE [dbo].[RentalItem] CHECK CONSTRAINT [FK_RentalItem_Family]
GO
/****** Object:  ForeignKey [FK_Resource_Measure]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Measure] FOREIGN KEY([MeasureId])
REFERENCES [dbo].[Measure] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Measure]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Measure]
GO
/****** Object:  ForeignKey [FK_Resource_ResourceType]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceTypeId])
REFERENCES [dbo].[ResourceType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_ResourceType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO
/****** Object:  ForeignKey [FK_Resource_Task]    Script Date: 04/23/2012 12:58:41 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Resource_Task]') AND parent_object_id = OBJECT_ID(N'[dbo].[Resource]'))
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Task]
GO
/****** Object:  ForeignKey [FK_Stock_Item]    Script Date: 04/23/2012 12:58:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Item]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Item]
GO
/****** Object:  ForeignKey [FK_Stock_Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Warehouse] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[Warehouse] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Stock_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Stock]'))
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Warehouse]
GO
/****** Object:  ForeignKey [FK_Storage_RentalItem]    Script Date: 04/23/2012 12:58:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_RentalItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_RentalItem] FOREIGN KEY([RentalItemId])
REFERENCES [dbo].[RentalItem] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_RentalItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Storage_RentalItem]
GO
/****** Object:  ForeignKey [FK_Storage_Warehouse]    Script Date: 04/23/2012 12:58:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_Warehouse] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[Warehouse] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Storage_Warehouse]') AND parent_object_id = OBJECT_ID(N'[dbo].[Storage]'))
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Storage_Warehouse]
GO
/****** Object:  ForeignKey [FK_Task_Project]    Script Date: 04/23/2012 12:58:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Task_Project]') AND parent_object_id = OBJECT_ID(N'[dbo].[Task]'))
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Project]
GO
