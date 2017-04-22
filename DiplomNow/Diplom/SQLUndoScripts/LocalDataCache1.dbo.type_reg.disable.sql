IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[type_reg]')) 
   ALTER TABLE [dbo].[type_reg] 
   DISABLE  CHANGE_TRACKING
GO
