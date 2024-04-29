USE OutpatientChargesBase
IF OBJECT_ID('tb_Patient') IS NOT NULL
DROP TABLE tb_Patient;
GO
CREATE TABLE tb_Patient
	(PaitentNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Patient_PatientNo
		PRIMARY KEY(PaitentNo)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Age
		INT
	,Birthday
		DATE
	,Identification
		VARCHAR(50)
	,Telephone
		VARCHAR(50)
	,Email
		VARCHAR(50)
	,ProvinceNo
		INT
		CONSTRAINT fk_Province_ProvinceNo
		FOREIGN KEY (ProvinceNo)
		REFERENCES tb_Province(ProvinceNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,MedicalCard
		VARCHAR(50)
	,Password
		VARCHAR(50)
	,Avatar
		VARBINARY(MAX)
	,Balance
		DECIMAL(18,2)
		DEFAULT 0)