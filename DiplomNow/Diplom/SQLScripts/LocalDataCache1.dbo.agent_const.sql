IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[agent_const]')) 
   ALTER TABLE [dbo].[agent_const] 
   ENABLE  CHANGE_TRACKING
GO
