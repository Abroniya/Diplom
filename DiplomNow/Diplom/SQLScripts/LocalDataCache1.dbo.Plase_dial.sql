IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Plase_dial]')) 
   ALTER TABLE [dbo].[Plase_dial] 
   ENABLE  CHANGE_TRACKING
GO
