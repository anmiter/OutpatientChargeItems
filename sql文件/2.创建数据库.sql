USE master;
IF DB_ID('OutpatientChargesBase') IS NOT NULL
	BEGIN
		ALTER DATABASE OutpatientChargesBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE OutpatientChargesBase;
	END
GO
CREATE DATABASE OutpatientChargesBase
	ON
		(NAME='DataFile_1'
		,FILENAME='D:\�����շ�ģ��\OutpatientCharge\OutpatientChargesDatabase\Data\DataFile_1.mdf')
	LOG ON
		(NAME='l=LogFile_1'
		,FILENAME='D:\�����շ�ģ��\OutpatientCharge\OutpatientChargesDatabase\Log\LogFile_1.ldf');