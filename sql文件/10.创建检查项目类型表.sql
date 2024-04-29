USE OutpatientChargesBase
IF OBJECT_ID('tb_ExamineItemType') IS NOT NULL
DROP TABLE tb_ExamineItemType;
GO
CREATE TABLE tb_ExamineItemType
	(No
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_ExamineItemType_No
		PRIMARY KEY(No)
	,Name
		VARCHAR(100))

INSERT INTO tb_ExamineItemType
	(Name)
	VALUES
	('ѪҺ���'),
	('��Һ���'),
	('Ӱ��ѧ���'),
	('�ĵ�ͼ���'),
	('�ڿ������'),
	('���Ƽ��'),
	('�������')

SELECT * FROM tb_ExamineItemType