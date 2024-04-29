using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Patient
{
    /// <summary>
    /// 价目查询窗体
    /// </summary>
    public partial class frm_PriceSearch : Form
    {
        public frm_PriceSearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.dgv_Drug.AllowUserToAddRows = false;//数据网格视图不允许用户添加行
            this.dgv_Drug.RowHeadersVisible = false;//数据网格视图的行标题不可见
            this.dgv_Drug.BackgroundColor = Color.White;//数据网格视图的背景色设为白色
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;//数据网格视图的自动调整列宽模式设为显示所有单元格
            this.dgv_Exmaine.AllowUserToAddRows = false;//数据网格视图不允许用户添加行
            this.dgv_Exmaine.RowHeadersVisible = false;//数据网格视图的行标题不可见
            this.dgv_Exmaine.BackgroundColor = Color.White;//数据网格视图的背景色设为白色
            this.dgv_Exmaine.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;//数据网格视图的自动调整列宽模式设为显示所有单元格
            LoadDrug();//载入药品
            LoadExamine();//载入检查项目
        }
        /// <summary>
        /// 药品表
        /// </summary>
        private DataTable _DrugTable;
        /// <summary>
        /// 检查项目表
        /// </summary>
        private DataTable _ExamineTable;
        /// <summary>
        /// 按名称排序的药品数据视图；
        /// </summary>
        private DataView _DrugViewByName;
        /// <summary>
        /// 按名称排序的项目数据视图；
        /// </summary>
        private DataView _ExamineViewByName;
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT D.DrugNo,D.ChineseName,D.Ingredient,D.Treat,U.UnitName,D.SellingPrice,D.ExpirationDate
                                            FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo=U.UnitNo";//指定SQL命令的命令文本；该命令查询所有药品，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable DrugTable = new DataTable("DrugTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药品
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(DrugTable);//SQL数据适配器读取数据，并填充药品数据表
            sqlConnection.Close();//关闭SQL连接
            this._DrugTable = DrugTable;
            this._DrugViewByName = new DataView();//实例化本窗体的药品数据视图，用于按照名称进行快速查询
            this._DrugViewByName.Table = DrugTable;//设置药品数据视图对应的数据表
            this._DrugViewByName.Sort = "ChineseName ASC";//设置药品数据视图的排序条件，即查询所覆盖的列
            this.dgv_Drug.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Drug.DataSource = DrugTable;//将数据网格视图的数据源设为药品数据表
            this.dgv_Drug.Columns["DrugNo"].ReadOnly = true;
            this.dgv_Drug.Columns["DrugNo"].HeaderText = "药品编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "药品名称";
            this.dgv_Drug.Columns["Ingredient"].HeaderText = "主要成分";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["UnitName"].HeaderText = "单位";
            this.dgv_Drug.Columns["SellingPrice"].HeaderText = "售价";
            this.dgv_Drug.Columns["ExpirationDate"].HeaderText = "有效期";
        }
        /// <summary>
        /// 载入检查项目
        /// </summary>
        public void LoadExamine()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = $@"SELECT Item.ExamineItemNo AS No,Type.Name AS Type,Item.Name AS Name,Item.Price as Price,Item.Introduction AS Introduction
	                                        FROM tb_ExamineItems AS Item JOIN tb_ExamineItemType AS Type ON Item.ExamineItemTypeNo=Type.No";//指定SQL命令的命令文本；该命令查询所有检查项目，以用作数据网格视图数据源
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable ExamineTable = new DataTable("ExamineTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索检查项目
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(ExamineTable);//SQL数据适配器读取数据，并填充检查项目数据表
            sqlConnection.Close();//关闭SQL连接
            this._ExamineTable = ExamineTable;
            this._ExamineViewByName = new DataView();//实例化本窗体的检查项目数据视图，用于按照名称进行快速查询
            this._ExamineViewByName.Table = ExamineTable;//设置检查项目数据视图对应的数据表
            this._ExamineViewByName.Sort = "Name ASC";//设置检查项目数据视图的排序条件，即查询所覆盖的列
            this.dgv_Exmaine.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Exmaine.DataSource = ExamineTable;//将数据网格视图的数据源设为检查项目数据表
            this.dgv_Exmaine.Columns["No"].ReadOnly = true;
            this.dgv_Exmaine.Columns["No"].HeaderText = "项目编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Exmaine.Columns["Name"].HeaderText = "项目名称";
            this.dgv_Exmaine.Columns["Type"].HeaderText = "类型";
            this.dgv_Exmaine.Columns["Price"].HeaderText = "价格";
            this.dgv_Exmaine.Columns["Introduction"].HeaderText = "简介";
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByNo_Click(object sender, EventArgs e)
        {
            if (this.txb_DrugNo.Text.Trim() != "")
            {
                DataRow drugRow = this._DrugTable.Rows.Find(this.txb_DrugNo.Text.Trim());
                DataTable searchResultTable = this._DrugTable.Clone();//借助本窗体的药品数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
                searchResultTable.ImportRow(drugRow);//将（复制后的）数据行导入数据表；
                this.dgv_Drug.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据编号搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExamineByNo_Click(object sender, EventArgs e)
        {
            if (this.txb_ExamineNo.Text.Trim() != "")
            {
                DataRow ExamineRow = this._ExamineTable.Rows.Find(this.txb_ExamineNo.Text.Trim());
                DataTable searchResultTable = this._ExamineTable.Clone();//借助本窗体的检查项目数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
                searchResultTable.ImportRow(ExamineRow);//将（复制后的）数据行导入数据表；
                this.dgv_Exmaine.DataSource = searchResultTable;
            }
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByName_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews =
                this._DrugViewByName.FindRows(this.txb_DrugName.Text.Trim());//借助本窗体的按名称排序的药品数据视图的方法FindRows，根据排序列（即药品名称）快速查找相应药品；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._DrugTable.Clone();//借助本窗体的药品数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRowView dataRowView in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(dataRowView.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_Drug.DataSource = searchResultTable;//将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 单击根据名称搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExmaineByName_Click(object sender, EventArgs e)
        {
            DataRowView[] searchResultRowViews =
                this._ExamineViewByName.FindRows(this.txb_ExamineName.Text.Trim());//借助本窗体的按名称排序的检查项目数据视图的方法FindRows，根据排序列（即项目名称）快速查找相应检查项目；由于该列并非主键，可能返回多行查询结果，故返回数据行视图数组；数据行视图数组不能直接作为数据源，需转为列表后方可作为数据源；
            DataTable searchResultTable = this._ExamineTable.Clone();//借助本窗体的检查项目数据表的方法Clone，创建相同架构的空表，用于保存搜索结果所在数据行；
            foreach (DataRowView dataRowView in searchResultRowViews)//遍历搜索结果所在数据行视图数组；
            {
                searchResultTable.ImportRow(dataRowView.Row);//通过每条数据行视图的属性Row获取相应的数据行，并导入数据表；
            }
            this.dgv_Exmaine.DataSource = searchResultTable;//将数据网格视图的数据源设为搜索结果数据表；
        }
        /// <summary>
        /// 单击重新载入按钮载入药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewLoadDrug_Click(object sender, EventArgs e)
        {
            LoadDrug();
            this.txb_DrugName.Clear();
            this.txb_ExamineName.Clear();
            this.txb_DrugNo.Clear();
            this.txb_ExamineNo.Clear();
        }
        /// <summary>
        /// 单击重新载入按钮载入检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newLoadExamine_Click(object sender, EventArgs e)
        {
            LoadExamine();
            this.txb_DrugName.Clear();
            this.txb_ExamineName.Clear();
            this.txb_DrugNo.Clear();
            this.txb_ExamineNo.Clear();
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchDrugByKeyword_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接

            sqlCommand.CommandText = @"SELECT D.DrugNo, D.ChineseName, D.Ingredient, D.Treat, U.UnitName, D.SellingPrice, D.ExpirationDate    
                                        FROM tb_Drug AS D JOIN tb_Unit AS U ON D.UnitNo = U.UnitNo    
                                        WHERE D.ChineseName LIKE '%' + @KeyWord + '%' OR D.Treat LIKE '%' + @KeyWord + '%'";//指定SQL命令的命令文本；该命令查询所有药品，以用作数据网格视图数据源
            sqlCommand.Parameters.Add("@KeyWord", SqlDbType.VarChar).Value = this.txb_DrugKeyWord.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable DrugTable = new DataTable("DrugTable"); // 设置DataTable的名称  
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索药品
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(DrugTable);//SQL数据适配器读取数据，并填充药品数据表
            sqlConnection.Close();//关闭SQL连接
            this._DrugTable = DrugTable;
            this._DrugViewByName = new DataView();//实例化本窗体的药品数据视图，用于按照名称进行快速查询
            this._DrugViewByName.Table = DrugTable;//设置药品数据视图对应的数据表
            this._DrugViewByName.Sort = "ChineseName ASC";//设置药品数据视图的排序条件，即查询所覆盖的列
            this.dgv_Drug.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Drug.DataSource = DrugTable;//将数据网格视图的数据源设为药品数据表
            this.dgv_Drug.Columns["DrugNo"].ReadOnly = true;
            this.dgv_Drug.Columns["DrugNo"].HeaderText = "药品编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "药品名称";
            this.dgv_Drug.Columns["Ingredient"].HeaderText = "主要成分";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["UnitName"].HeaderText = "单位";
            this.dgv_Drug.Columns["SellingPrice"].HeaderText = "售价";
            this.dgv_Drug.Columns["ExpirationDate"].HeaderText = "有效期";
        }
        /// <summary>
        /// 单击根据关键字搜索按钮搜索检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SearchExamineByKeyWord_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;//将SQL命令的连接属性指向SQL连接
            sqlCommand.CommandText = @"SELECT Item.ExamineItemNo AS No, Type.Name AS Type, Item.Name AS Name, Item.Price AS Price, Item.Introduction AS Introduction    
                               FROM tb_ExamineItems AS Item     
                               JOIN tb_ExamineItemType AS Type ON Item.ExamineItemTypeNo = Type.No    
                               WHERE Item.Name LIKE '%' + @KeyWord + '%' OR Type.Name LIKE '%' + @KeyWord + '%'";//指定SQL命令的命令文本；该命令查询所有检查项目，以用作数据网格视图数据源
            sqlCommand.Parameters.Add("@KeyWord", SqlDbType.VarChar).Value = this.txb_ExamineKeyWord.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();//声明并实例化SQL数据适配器
            sqlDataAdapter.SelectCommand = sqlCommand;//将SQL数据适配器的查询命令属性指向SQL命令
            DataTable ExamineTable = new DataTable("ExamineTable");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置SQL数据适配器在缺少架构时的动作为追加主键，从而获取数据库中定义的主键，否则无法根据编号搜索检查项目
            sqlConnection.Open();//打开SQL连接
            sqlDataAdapter.Fill(ExamineTable);//SQL数据适配器读取数据，并填充检查项目数据表
            sqlConnection.Close();//关闭SQL连接
            this._ExamineTable = ExamineTable;
            this._ExamineViewByName = new DataView();//实例化本窗体的检查项目数据视图，用于按照名称进行快速查询
            this._ExamineViewByName.Table = ExamineTable;//设置检查项目数据视图对应的数据表
            this._ExamineViewByName.Sort = "Name ASC";//设置检查项目数据视图的排序条件，即查询所覆盖的列
            this.dgv_Exmaine.Columns.Clear();//数据网格视图的列集合清空
            this.dgv_Exmaine.DataSource = ExamineTable;//将数据网格视图的数据源设为检查项目数据表
            this.dgv_Exmaine.Columns["No"].ReadOnly = true;
            this.dgv_Exmaine.Columns["No"].HeaderText = "项目编号";//将数据网格视图的指定列的表头文本设为中文
            this.dgv_Exmaine.Columns["Name"].HeaderText = "项目名称";
            this.dgv_Exmaine.Columns["Type"].HeaderText = "类型";
            this.dgv_Exmaine.Columns["Price"].HeaderText = "价格";
            this.dgv_Exmaine.Columns["Introduction"].HeaderText = "简介";
        }
        private void dgv_Exmaine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tp_DrugPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
