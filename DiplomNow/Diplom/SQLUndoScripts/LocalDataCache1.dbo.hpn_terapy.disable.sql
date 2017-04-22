IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[hpn_terapy]')) 
   ALTER TABLE [dbo].[hpn_terapy] 
   DISABLE  CHANGE_TRACKING
GO
