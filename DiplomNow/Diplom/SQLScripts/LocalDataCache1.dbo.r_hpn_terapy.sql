IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[r_hpn_terapy]')) 
   ALTER TABLE [dbo].[r_hpn_terapy] 
   ENABLE  CHANGE_TRACKING
GO
