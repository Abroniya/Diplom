IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Value_const]')) 
   ALTER TABLE [dbo].[Value_const] 
   DISABLE  CHANGE_TRACKING
GO
