IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Hpn_hbp]')) 
   ALTER TABLE [dbo].[Hpn_hbp] 
   DISABLE  CHANGE_TRACKING
GO
