USE OutpatientChargesBase
IF OBJECT_ID('tb_Unit') IS NOT NULL
DROP TABLE tb_Unit;
GO
CREATE TABLE tb_Unit
	(UnitNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
		CONSTRAINT pk_Unit_UnitNo
		PRIMARY KEY(UnitNo)
	,UnitName
		VARCHAR(50))

INSERT INTO tb_Unit
	(UnitName)
	VALUES
	('��'),
	('ƿ'),
	('��'),
	('g'),
	('mg'),
	('ug'),
	('ml'),
	('Ƭ'),
	('��'),
	('��'),
	('֧'),
	('��'),
	('UI'),
	('U')

SELECT * FROM tb_Unit