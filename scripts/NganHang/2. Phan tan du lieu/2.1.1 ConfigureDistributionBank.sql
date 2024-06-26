/*
Thiet lap thu muc de luu cac snap shot ten REPLDATA tai o dia C hoac D, thay doi ten may cho phu hop o day ten may la 'TM'
*/
use master
exec sp_adddistributor @distributor = N'TM\NGANHANG', @password = N''
GO
exec sp_adddistributiondb @database = N'distribution', @data_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL16.NGANHANG\MSSQL\Data', @log_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL16.NGANHANG\MSSQL\Data', @log_file_size = 2, @min_distretention = 0, @max_distretention = 72, @history_retention = 48, @deletebatchsize_xact = 5000, @deletebatchsize_cmd = 2000, @security_mode = 1
GO

use [distribution] 
if (not exists (select * from sysobjects where name = 'UIProperties' and type = 'U ')) 
	create table UIProperties(id int) 
if (exists (select * from ::fn_listextendedproperty('SnapshotFolder', 'user', 'dbo', 'table', 'UIProperties', null, null))) 
	EXEC sp_updateextendedproperty N'SnapshotFolder', N'\\Tm\repldata', 'user', dbo, 'table', 'UIProperties' 
else 
	EXEC sp_addextendedproperty N'SnapshotFolder', N'\\Tm\repldata', 'user', dbo, 'table', 'UIProperties'
GO

exec sp_adddistpublisher @publisher = N'TM\NGANHANG', @distribution_db = N'distribution', @security_mode = 0, @login = N'sa', @password = N'kc', @working_directory = N'\\Tm\repldata', @trusted = N'false', @thirdparty_flag = 0, @publisher_type = N'MSSQLSERVER'
GO
