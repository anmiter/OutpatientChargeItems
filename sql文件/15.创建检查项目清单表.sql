USE OutpatientChargesBase
IF OBJECT_ID('tb_ExamineItemsList') IS NOT NULL
DROP TABLE tb_ExamineItemsList;
GO
CREATE TABLE tb_ExamineItemsList
	(ItemListNo
		VARCHAR(50)
	,ExamineItemNo
		INT
		CONSTRAINT fk_ExamineItemsList_ExamineItemNo
		FOREIGN KEY (ExamineItemNo)
		REFERENCES tb_ExamineItems(ExamineItemNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Result
		VARCHAR(2000))

	INSERT INTO tb_ExamineItemsList
	(ItemListNo,ExamineItemNo,Result)
	VALUES
	('112024318','1','血常规结果'),
	('112024318','3','凝血功能检查结果'),
	('312024422','1','血常规结果')