USE OutpatientChargesBase
IF OBJECT_ID('tb_Province') IS NOT NULL
DROP TABLE tb_Province;
GO
CREATE TABLE tb_Province
	(ProvinceNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Province_ProvinceNo
		PRIMARY KEY(ProvinceNo)
	,Province
		VARCHAR(100))

INSERT INTO tb_Province
	(Province)
	VALUES
	('�ӱ�'),
	('ɽ��'),
	('����'),
	('����'),
	('������'),
	('����'),
	('�㽭'),
	('����'),
	('����'),
	('����'),
	('ɽ��'),
	('����'),
	('����'),
	('����'),
	('�㶫'),
	('����'),
	('�Ĵ�'),
	('����'),
	('����'),
	('����'),
	('����'),
	('�ຣ'),
	('̨��'),
	('���ɹ�������'),
	('����׳��������'),
	('����������'),
	('���Ļ���������'),
	('�½�ά���������'),
	('����'),
	('���'),
	('�Ϻ�'),
	('����'),
	('���'),
	('����')

SELECT * FROM tb_Province