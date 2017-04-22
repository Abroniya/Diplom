IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[agent]')) 
   ALTER TABLE [dbo].[agent] 
   DISABLE  CHANGE_TRACKING
GO
