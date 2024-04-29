USE OutpatientChargesBase
IF OBJECT_ID('tb_Drug') IS NOT NULL
DROP TABLE tb_Drug;
GO
CREATE TABLE tb_Drug
	(DrugNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)������������ʼֵ1������1*/
		NOT NULL
	CONSTRAINT pk_Drug_DrugNo
		PRIMARY KEY(DrugNo)
	,ChineseName
		VARCHAR(100)
	,EnglishName
		VARCHAR(100)
	,Ingredient
		VARCHAR(250)
	,Treat
		VARCHAR(1000)
	,Specification
		VARCHAR(50)
	,UnitNo
		INT
		CONSTRAINT fk_Drug_UnitNo
		FOREIGN KEY (UnitNo)
		REFERENCES tb_Unit(UnitNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Manufacturer
		VARCHAR(500)
	,PurchasePrice
		DECIMAL(18,2)
	,SellingPrice
		DECIMAL(18,2)
	,ExpirationDate
		INT)

INSERT INTO tb_Drug
	(ChineseName,EnglishName,Ingredient,Treat,Specification,UnitNo,Manufacturer,PurchasePrice,SellingPrice,ExpirationDate)
	VALUES
	('���ᵪ׿˹͡Ƭ','Azelastine Hydrochloride Tablets','���ᵪ׿˹͡','������','2mg',8,'�����Ʒ�ҩҵ���޹�˾',5.69,12.80,36),
	('ƥά���Ƭ','Pinaverium Bromide Tablets','ƥά���','�����򵨵����������йص���ʹ','50mg',8,'��Ԫҽҩ',7.88,19.50,24),
	('ͷ�߿�뿽���','Cefix Me Capsules','ͷ�߿��','����֧�����ס����ס������ס������ס��ж���','100mg',10,'�㽭��̫ҩҵ�ɷ����޹�˾',9.10,22.70,24),
	('��ޤ��θ������','Fengliao Changweikang Keli','ţ���㡢��ޤ','���ȳ�ʪ����','3g',1,'������ҩ�����޹�˾',3.46,9.50,36),
	('�������������','Sodium Fusidate Ointment','��������','ŧ������ǳ����ë���ס�Ѱ���봯���׹���','15g',11,'��˼��',8.69,18.20,24),
	('�����ε��濵�����','Pevisone','�����濵�������ε�','Ƥ�ס�ʪ�����Ѣ����Ѣ���׹���','15g',11,'������ɭ��ҩ���޹�˾',7.60,15.80,24)