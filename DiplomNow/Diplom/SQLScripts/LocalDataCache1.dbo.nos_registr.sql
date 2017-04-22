IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[nos_registr]')) 
   ALTER TABLE [dbo].[nos_registr] 
   ENABLE  CHANGE_TRACKING
GO
