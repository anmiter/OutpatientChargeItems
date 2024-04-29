USE OutpatientChargesBase
IF OBJECT_ID('tb_MedicalRecord') IS NOT NULL
DROP TABLE tb_MedicalRecord;
GO
CREATE TABLE tb_MedicalRecord
	(PaitentNo
		INT
		CONSTRAINT fk_MedicalRecord_PaitentNo
		FOREIGN KEY (PaitentNo)
		REFERENCES tb_Patient(PaitentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DoctorNo
		INT
		CONSTRAINT fk_MedicalRecord_DoctorNo
		FOREIGN KEY (DoctorNo)
		REFERENCES tb_Doctor(DoctorNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Time
		SMALLDATETIME
	,Description
		VARCHAR(1000)
	,Orders
		VARCHAR(1000))

	INSERT INTO tb_MedicalRecord
	(PaitentNo,DoctorNo,Time,Description,Orders)
	VALUES
	(1,1,2024/3/18,'胃部轻微炎症','少吃辛辣刺激食物'),
	(1,3,2024/4/22,'气虚肝郁','多运动少熬夜')