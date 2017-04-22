IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[hpn_skf]')) 
   ALTER TABLE [dbo].[hpn_skf] 
   DISABLE  CHANGE_TRACKING
GO
