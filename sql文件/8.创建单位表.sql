USE OutpatientChargesBase
IF OBJECT_ID('tb_Unit') IS NOT NULL
DROP TABLE tb_Unit;
GO
CREATE TABLE tb_Unit
	(UnitNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
		CONSTRAINT pk_Unit_UnitNo
		PRIMARY KEY(UnitNo)
	,UnitName
		VARCHAR(50))

INSERT INTO tb_Unit
	(UnitName)
	VALUES
	('袋'),
	('瓶'),
	('盒'),
	('g'),
	('mg'),
	('ug'),
	('ml'),
	('片'),
	('丸'),
	('粒'),
	('支'),
	('剂'),
	('UI'),
	('U')

SELECT * FROM tb_Unit