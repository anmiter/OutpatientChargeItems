USE OutpatientChargesBase
IF OBJECT_ID('tb_Prescription') IS NOT NULL
DROP TABLE tb_Prescription;
GO
CREATE TABLE tb_Prescription
	(PrescriptionNo
		VARCHAR(50)
	,DrugNo
		INT
		CONSTRAINT fk_Prescription_DrugNo
		FOREIGN KEY (DrugNo)
		REFERENCES tb_Drug(DrugNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Number
		INT
	,Unit
		VARCHAR(50)
	,Orders
		VARCHAR(1000))