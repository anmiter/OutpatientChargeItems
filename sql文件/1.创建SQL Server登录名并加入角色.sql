--����SQL Server��¼��Zhang015��
--����!123357789zsY7015���ҵ�¼��Ĭ�ϵ���master���ݿ�
IF SUSER_ID('Zhang015') IS NOT NULL
	DROP LOGIN Zhang015;
GO
CREATE LOGIN Zhang015/*�½���SQLServer��֤�ĵ�¼����Ĭ�Ϸ�������ɫΪPublic*/
	WITH
		PASSWORD='!123357789zsY7015'
		,CHECK_POLICY=OFF/*�Ƿ�ǿ��ʵʩ SQL Server���ڼ������ Windows ����*/
		,DEFAULT_DATABASE=master

--�����ݿ�OutpatientChargesBase�д����û�DbUser1 ����ӳ������¼��Zhang015��
--����ٴγ��Դ�ʹ��Zhang015�Ĳ�ѯ�����з���OutpatientChargesBase
USE OutpatientChargesBase
DROP USER IF EXISTS DbUser1;/*��USER_ID�����ж�ָ���û��Ƿ����*/
GO
CREATE USER DbUser1
	FOR LOGIN Zhang015
EXEC sys.sp_addrolemember 'db_datawriter','DbUser1';/*�����ɫdb_datawriter*/
EXEC sys.sp_addrolemember 'db_datareader','DbUser1';/*�����ɫdb_datawriter*/