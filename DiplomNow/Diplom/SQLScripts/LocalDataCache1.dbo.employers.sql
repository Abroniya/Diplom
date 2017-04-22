IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[employers]')) 
   ALTER TABLE [dbo].[employers] 
   ENABLE  CHANGE_TRACKING
GO
