IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[hpn_diagn]')) 
   ALTER TABLE [dbo].[hpn_diagn] 
   ENABLE  CHANGE_TRACKING
GO
