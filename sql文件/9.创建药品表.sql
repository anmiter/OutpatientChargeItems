USE OutpatientChargesBase
IF OBJECT_ID('tb_Drug') IS NOT NULL
DROP TABLE tb_Drug;
GO
CREATE TABLE tb_Drug
	(DrugNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
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
	('盐酸氮卓斯汀片','Azelastine Hydrochloride Tablets','盐酸氮卓斯汀','抗过敏','2mg',8,'贵州云峰药业有限公司',5.69,12.80,36),
	('匹维溴铵片','Pinaverium Bromide Tablets','匹维溴铵','肠道或胆道功能紊乱有关的疼痛','50mg',8,'福元医药',7.88,19.50,24),
	('头孢克肟胶囊','Cefix Me Capsules','头孢克肟','急性支气管炎、肺炎、膀胱炎、胆囊炎、中耳炎','100mg',10,'浙江亚太药业股份有限公司',9.10,22.70,24),
	('枫蓼肠胃康颗粒','Fengliao Changweikang Keli','牛耳枫、辣蓼','清热除湿化滞','3g',1,'海口制药厂有限公司',3.46,9.50,36),
	('夫西地酸钠软膏','Sodium Fusidate Ointment','夫西地酸','脓包疮、浅表性毛囊炎、寻常须疮、甲沟炎','15g',11,'海思科',8.69,18.20,24),
	('曲安奈德益康唑乳膏','Pevisone','硝酸益康唑、曲安奈德','皮炎、湿疹、手足癣、体癣、甲沟炎','15g',11,'西安杨森制药有限公司',7.60,15.80,24)