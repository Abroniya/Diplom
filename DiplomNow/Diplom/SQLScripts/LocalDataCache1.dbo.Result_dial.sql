IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Result_dial]')) 
   ALTER TABLE [dbo].[Result_dial] 
   ENABLE  CHANGE_TRACKING
GO
