USE OutpatientChargesBase
IF OBJECT_ID('tb_ExamineItems') IS NOT NULL
DROP TABLE tb_ExamineItems;
GO
CREATE TABLE tb_ExamineItems
	(ExamineItemNo
		INT IDENTITY(1,1)/*IDENTITY(1,1)：自增长，起始值1，增量1*/
		NOT NULL
	CONSTRAINT pk_ExamineItem_ExamineItemNo
		PRIMARY KEY(ExamineItemNo)
	,Name
		VARCHAR(100)
	,ExamineItemTypeNo
		INT
		CONSTRAINT fk_ExamineItems_ExamineItemTypeNo
		FOREIGN KEY (ExamineItemTypeNo)
		REFERENCES tb_ExamineItemType(No)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	,Price
		DECIMAL(18,2)
	,Introduction
		VARCHAR(1000))

INSERT INTO tb_ExamineItems
	(Name,ExamineItemTypeNo,Price,Introduction)
	VALUES
	('血常规',1,45,'包括红细胞计数、白细胞计数、血红蛋白浓度等，用于评估贫血、感染、白血病等血液相关疾病'),
	('生化检查',1,180,'包括肝功能、肾功能、血脂、血糖等，可以了解身体各器官的功能状态，以及是否存在代谢异常'),
	('凝血功能检查',1,100,'评估血液凝固能力，常用于术前评估或血栓性疾病的诊断'),
	('尿常规',2,18,'包括尿比重、尿pH值、尿蛋白、尿糖等，用于泌尿系统疾病的初步筛查'),
	('尿沉渣检查',2,25,'观察尿液中的细胞、管型等，有助于诊断肾炎、尿路感染等疾病'),
	('B超',3,200,'利用超声波原理，观察身体内部结构，常用于肝、胆、胰、脾、肾、子宫、附件等器官的检查'),
	('X光',3,130,'利用X射线穿透身体，观察骨骼、肺部等结构，常用于骨折、肺炎等疾病的诊断'),
	('CT',3,800,'计算机断层扫描，通过多个X射线层面的组合，生成身体内部的立体图像，常用于肿瘤、脑血管疾病的诊断'),
	('MRI',3,1200,'磁共振成像，利用磁场和射频波生成身体内部的详细图像，对软组织分辨率高，常用于神经系统、关节等疾病的诊断'),
	('心电图检查',4,60,'通过记录心脏的电活动，评估心脏功能，常用于心律失常、心肌缺血等心脏疾病的诊断'),
	('胃镜',5,780,'通过口腔进入，观察食道、胃、十二指肠的黏膜情况，常用于胃溃疡、胃炎、食管癌等疾病的诊断'),
	('肠镜',5,550,'通过肛门进入，观察结肠和直肠的黏膜情况，常用于结肠炎、肠息肉、肠癌等疾病的诊断'),
	('宫颈涂片',6,200,'采集宫颈细胞进行检查，用于宫颈癌的筛查'),
	('乳腺检查',6,1280,'包括触诊和乳腺B超，用于乳腺增生的诊断，乳腺癌的筛查'),
	('脑电图',7,300,'记录大脑的电活动，用于癫痫、脑炎等神经系统疾病的诊断'),
	('骨密度检查',7,300,'评估骨骼健康状况，常用于骨质疏松的诊断'),
	('基因检测',7,1500,'通过检测基因序列，预测患某种疾病的风险，或用于遗传性疾病的诊断')

SELECT * FROM tb_ExamineItems