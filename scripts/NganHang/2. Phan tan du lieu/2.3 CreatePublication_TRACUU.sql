-- Enabling the replication database
use master
exec sp_replicationdboption @dbname = N'NGANHANG', @optname = N'merge publish', @value = N'true'
GO

-- Adding the merge publication
use [NGANHANG]
exec sp_addmergepublication @publication = N'NGANHANG_TRACUU', @description = N'TRACUU', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = null, @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO


exec sp_addpublication_snapshot @publication = N'NGANHANG_TRACUU', @frequency_type = 4, @frequency_interval = 14, @frequency_relative_interval = 1, @frequency_recurrence_factor = 0, @frequency_subday = 1, @frequency_subday_interval = 5, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N'kc'


use [NGANHANG]
exec sp_addmergearticle @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @source_owner = N'dbo', @source_object = N'KhachHang', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'true', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'CMND', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'HO', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'TEN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'NGAYCAP', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'SODT', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'KhachHang', @column = N'MACN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [NGANHANG]
/* 
exec sp_addmergearticle @publication = N'NGANHANG_TRACUU', @article = N'TaiKhoan', @source_owner = N'dbo', @source_object = N'TaiKhoan', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'true', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'TaiKhoan', @column = N'SOTK', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'TaiKhoan', @column = N'CMND', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'TaiKhoan', @column = N'MACN', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_mergearticlecolumn @publication = N'NGANHANG_TRACUU', @article = N'TaiKhoan', @column = N'NGAYMOTK', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
*/
GO


