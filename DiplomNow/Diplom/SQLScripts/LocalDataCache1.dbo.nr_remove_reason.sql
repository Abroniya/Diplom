IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[nr_remove_reason]')) 
   ALTER TABLE [dbo].[nr_remove_reason] 
   ENABLE  CHANGE_TRACKING
GO
