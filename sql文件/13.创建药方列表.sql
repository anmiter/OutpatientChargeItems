USE OutpatientChargesBase
IF OBJECT_ID('tb_PrescriptionList') IS NOT NULL
DROP TABLE tb_PrescriptionList;
GO
CREATE TABLE tb_PrescriptionList
	(PrescriptionNo
		VARCHAR(50)
	,PaitentNo
		INT
		CONSTRAINT fk_PrescriptionList_PaitentNo
		FOREIGN KEY (PaitentNo)
		REFERENCES tb_Patient(PaitentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		INT
		CONSTRAINT fk_PrescriptionList_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(DoctorNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE)