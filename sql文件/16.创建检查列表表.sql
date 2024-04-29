USE OutpatientChargesBase
IF OBJECT_ID('tb_ExamineList') IS NOT NULL
DROP TABLE tb_ExamineList;
GO
CREATE TABLE tb_ExamineList
	(ItemListNo
		VARCHAR(50)
	,DoctorNo
		INT
		CONSTRAINT fk_ExamineList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(DoctorNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,PaitentNo
		INT
		CONSTRAINT fk_ExamineList_PaitentNo
		FOREIGN KEY (PaitentNo)
		REFERENCES tb_Patient(PaitentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Time
		SMALLDATETIME)