USE OutpatientChargesBase
IF OBJECT_ID('tb_Title') IS NOT NULL
DROP TABLE tb_Title;
GO
CREATE TABLE tb_Title
	(TitleNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
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
	('住院医师',30),
	('主治医师',30),
	('副主任医师',40),
	('主任医师',50);

SELECT * FROM tb_Title