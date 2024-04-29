USE OutpatientChargesBase
IF OBJECT_ID('tb_Title') IS NOT NULL
DROP TABLE tb_Title;
GO
CREATE TABLE tb_Title
	(TitleNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Title_TitleNo
		PRIMARY KEY(TitleNo)
	,Name
		VARCHAR(100)
	,CopayFee
		DECIMAL(18,2))

INSERT INTO tb_Title
	(Name,CopayFee)
	VALUES
	('סԺҽʦ',30),
	('����ҽʦ',30),
	('������ҽʦ',40),
	('����ҽʦ',50);

SELECT * FROM tb_Title