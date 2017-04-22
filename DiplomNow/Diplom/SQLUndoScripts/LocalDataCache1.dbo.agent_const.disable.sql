IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[agent_const]')) 
   ALTER TABLE [dbo].[agent_const] 
   DISABLE  CHANGE_TRACKING
GO
