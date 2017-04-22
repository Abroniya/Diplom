IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Status_request]')) 
   ALTER TABLE [dbo].[Status_request] 
   ENABLE  CHANGE_TRACKING
GO
