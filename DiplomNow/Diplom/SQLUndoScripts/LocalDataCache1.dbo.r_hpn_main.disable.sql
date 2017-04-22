IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[r_hpn_main]')) 
   ALTER TABLE [dbo].[r_hpn_main] 
   DISABLE  CHANGE_TRACKING
GO
