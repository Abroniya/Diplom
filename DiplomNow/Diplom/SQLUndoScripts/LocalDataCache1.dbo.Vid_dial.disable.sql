IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Vid_dial]')) 
   ALTER TABLE [dbo].[Vid_dial] 
   DISABLE  CHANGE_TRACKING
GO
