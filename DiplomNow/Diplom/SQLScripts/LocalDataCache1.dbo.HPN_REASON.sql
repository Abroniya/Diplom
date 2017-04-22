IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[HPN_REASON]')) 
   ALTER TABLE [dbo].[HPN_REASON] 
   ENABLE  CHANGE_TRACKING
GO
