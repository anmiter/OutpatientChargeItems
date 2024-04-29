USE OutpatientChargesBase
IF OBJECT_ID('tb_Doctor') IS NOT NULL
DROP TABLE tb_Doctor;
GO
CREATE TABLE tb_Doctor
	(DoctorNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_Doctor_DoctorNo
		PRIMARY KEY(DoctorNo)
	,Name
		VARCHAR(50)
	,Gender
		BIT
	,Age
		INT
	,TitleNo
		INT
		CONSTRAINT fk_Doctor_TitleNo
		FOREIGN KEY (TitleNo)
		REFERENCES tb_Title(TitleNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,DepartmentNo
		INT
		CONSTRAINT fk_Doctor_DepartmentNo
		FOREIGN KEY (DepartmentNo)
		REFERENCES tb_Department(DepartmentNo)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Telephone
		VARCHAR(50)
	,Certificate
		VARCHAR(50)
	,Introduction
		VARCHAR(1000))

INSERT INTO tb_Doctor
	(Name,Gender,Age,TitleNo,DepartmentNo,Telephone,Certificate,Introduction)
	VALUES
	('蔡立勉',1,63,4,2,'13022389239','7283726372873628','擅长胃肠病和肝病的诊治'),
	('邱丽贞',0,35,3,7,'13028716229','1827369283719372','乳腺、甲状腺疾病综合诊治，甲状腺、腹股沟疝、切口疝等腹壁疝的腔镜微创治疗'),
	('高玉玲',0,43,4,13,'13028716429','1526527726277267','妇科肿瘤，宫颈疾病，生殖道感染性疾病、月经量多、阴道出血等'),
	('曾华科',1,37,3,15,'13028716266','1425678276282762','眼底病、黄斑疾病、视网膜脱离、糖尿病视网膜病变、眼外伤、玻璃体积血、白内障的手术治疗'),
	('吕绍光',1,58,4,20,'13029878829','1728273617282617','不孕症、月经失调、痛经以及妇科炎症、糖尿病、甲状腺疾病以及肥胖症等'),
	('施小妹',0,36,3,21,'13028372839','1827656565172676','颈肩腰腿痛，神经痛，癌痛综合管理，失眠四高等亚健康状态调理'),
	('郑益新',1,31,2,10,'13228372293','1827192719283718','腰腿痛，颈椎病，腰椎间盘突出症，骨质疏松，腱鞘炎，腱鞘囊肿，腕管综合症，关节炎'),
	('林丽容',0,37,2,1,'13027382718','1827382738273827','高血压，急慢性心衰，冠心病，心律失常，心肌病，高血脂等内科常见疾病的诊治'),
	('林毅',1,52,4,17,'13527839920','1827392837283719','骨量不足的牙列缺损、牙列缺失的种植治疗，老年人的种植、补牙、烤瓷牙、整牙、牙结石、牙周病、氟斑牙的治疗');

SELECT * FROM tb_Doctor