USE OutpatientChargesBase
IF OBJECT_ID('tb_Doctor') IS NOT NULL
DROP TABLE tb_Doctor;
GO
CREATE TABLE tb_Doctor
	(DoctorNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Doctor_DoctorNo
		PRIMARY KEY(DoctorNo)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Age
		INT
	,TitleNo
		INT
		CONSTRAINT fk_Doctor_TitleNo
		FOREIGN KEY (TitleNo)
		REFERENCES tb_Title(TitleNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DepartmentNo
		INT
		CONSTRAINT fk_Doctor_DepartmentNo
		FOREIGN KEY (DepartmentNo)
		REFERENCES tb_Department(DepartmentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Telephone
		VARCHAR(50)
	,Certificate
		VARCHAR(50)
	,Introduction
		VARCHAR(1000))

INSERT INTO tb_Doctor
	(Name,Gender,Age,TitleNo,DepartmentNo,Telephone,Certificate,Introduction)
	VALUES
	('������',1,63,4,2,'13022389239','7283726372873628','�ó�θ�����͸β�������'),
	('������',0,35,3,7,'13028716229','1827369283719372','���١���״�ټ����ۺ����Σ���״�١����ɹ��ޡ��п��޵ȸ����޵�ǻ��΢������'),
	('������',0,43,4,13,'13028716429','1526527726277267','����������������������ֳ����Ⱦ�Լ������¾����ࡢ������Ѫ��'),
	('������',1,37,3,15,'13028716266','1425678276282762','�۵ײ����ư߼���������Ĥ���롢��������Ĥ���䡢�����ˡ��������Ѫ�������ϵ���������'),
	('���ܹ�',1,58,4,20,'13029878829','1728273617282617','����֢���¾�ʧ����ʹ���Լ�������֢�����򲡡���״�ټ����Լ�����֢��'),
	('ʩС��',0,36,3,21,'13028372839','1827656565172676','��������ʹ����ʹ����ʹ�ۺϹ���ʧ���ĸߵ��ǽ���״̬����'),
	('֣����',1,31,2,10,'13228372293','1827192719283718','����ʹ����׵������׵����ͻ��֢���������ɣ������ף��������ף�����ۺ�֢���ؽ���'),
	('������',0,37,2,1,'13027382718','1827382738273827','��Ѫѹ����������˥�����Ĳ�������ʧ�����ļ�������Ѫ֬���ڿƳ�������������'),
	('����',1,52,4,17,'13527839920','1827392837283719','�������������ȱ������ȱʧ����ֲ���ƣ������˵���ֲ��������������������������ʯ�����ܲ���������������');

SELECT * FROM tb_Doctor