IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[MKB10]')) 
   ALTER TABLE [dbo].[MKB10] 
   DISABLE  CHANGE_TRACKING
GO
