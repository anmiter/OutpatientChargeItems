USE OutpatientChargesBase
IF OBJECT_ID('tb_Bill') IS NOT NULL
DROP TABLE tb_Bill;
GO
CREATE TABLE tb_Bill
	(BillNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
		CONSTRAINT pk_Bill_BillNo
		PRIMARY KEY(BillNo)
	,PaitentNo
		INT
		CONSTRAINT fk_Bill_PaitentNo
		FOREIGN KEY (PaitentNo)
		REFERENCES tb_Patient(PaitentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		INT
		CONSTRAINT fk_Bill_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(DoctorNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,MedicinesCost
		DECIMAL(18,2)
	,ExamineCost
		DECIMAL(18,2)
	,CopayFee
		DECIMAL(18,2)
	,TotalCost
		AS (MedicinesCost+ExamineCost+CopayFee)
	,Time
		SMALLDATETIME
	,State
		BIT)

	INSERT INTO tb_Bill
	(PaitentNo,DoctorNo,MedicinesCost,ExamineCost,CopayFee,Time,State)
	VALUES
	(1,1,97.50,145,50,2024/3/18,1),
	(1,3,88.00,45,50,2024/4/22,1)