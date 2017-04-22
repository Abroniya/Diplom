IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[hpn_main]')) 
   ALTER TABLE [dbo].[hpn_main] 
   ENABLE  CHANGE_TRACKING
GO
