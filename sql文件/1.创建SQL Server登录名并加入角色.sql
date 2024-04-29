--创建SQL Server登录名Zhang015，
--密码!123357789zsY7015，且登录后默认调用master数据库
IF SUSER_ID('Zhang015') IS NOT NULL
	DROP LOGIN Zhang015;
GO
CREATE LOGIN Zhang015/*新建的SQLServer验证的登录名的默认服务器角色为Public*/
	WITH
		PASSWORD='!123357789zsY7015'
		,CHECK_POLICY=OFF/*是否强制实施 SQL Server所在计算机的 Windows 密码*/
		,DEFAULT_DATABASE=master

--在数据库OutpatientChargesBase中创建用户DbUser1 ，并映射至登录名Zhang015，
--随后再次尝试从使用Zhang015的查询窗口中访问OutpatientChargesBase
USE OutpatientChargesBase
DROP USER IF EXISTS DbUser1;/*用USER_ID函数判断指定用户是否存在*/
GO
CREATE USER DbUser1
	FOR LOGIN Zhang015
EXEC sys.sp_addrolemember 'db_datawriter','DbUser1';/*加入角色db_datawriter*/
EXEC sys.sp_addrolemember 'db_datareader','DbUser1';/*加入角色db_datawriter*/