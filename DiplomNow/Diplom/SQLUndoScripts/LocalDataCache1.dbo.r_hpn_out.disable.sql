IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[r_hpn_out]')) 
   ALTER TABLE [dbo].[r_hpn_out] 
   DISABLE  CHANGE_TRACKING
GO
