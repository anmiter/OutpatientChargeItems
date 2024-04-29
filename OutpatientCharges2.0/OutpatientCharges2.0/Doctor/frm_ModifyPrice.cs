using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Doctor
{
    /// <summary>
    /// 修改价目窗体
    /// </summary>
    public partial class frm_ModifyPrice : Form
    {
        public frm_ModifyPrice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.dgv_Drug.BackgroundColor = Color.White;
            this.dgv_Drug.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Exmaine.BackgroundColor = Color.White;
            this.dgv_Exmaine.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
            LoadDrug();
            LoadExamine();
        }
        /// <summary>
        /// 药品表
        /// </summary>
        private DataTable DrugTable;
        /// <summary>
        /// 检查项目表
        /// </summary>
        private DataTable ExamineTable;
        /// <summary>
        /// 载入药品
        /// </summary>
        public void LoadDrug()
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
           
            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Unit";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable unitTable = new DataTable();
            DataTable drugTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(unitTable);
            sqlCommand.CommandText = "SELECT * FROM tb_Drug";
            sqlDataAdapter.Fill(drugTable);
            sqlConnection.Close();
            this.DrugTable = drugTable;
            this.dgv_Drug.Columns.Clear();
            this.dgv_Drug.DataSource = drugTable;
            this.dgv_Drug.Columns["DrugNo"].ReadOnly = true;
            this.dgv_Drug.Columns["DrugNo"].HeaderText = "药品编号";
            this.dgv_Drug.Columns["ChineseName"].HeaderText = "中文名";
            this.dgv_Drug.Columns["EnglishName"].HeaderText = "英文名";
            this.dgv_Drug.Columns["Ingredient"].HeaderText = "主要成分";
            this.dgv_Drug.Columns["Treat"].HeaderText = "主治";
            this.dgv_Drug.Columns["Specification"].HeaderText = "规格";
            this.dgv_Drug.Columns["Manufacturer"].HeaderText = "生产厂家";
            this.dgv_Drug.Columns["PurchasePrice"].HeaderText = "进价";
            this.dgv_Drug.Columns["SellingPrice"].HeaderText = "售价";
            this.dgv_Drug.Columns["ExpirationDate"].HeaderText = "有效期";
            this.dgv_Drug.Columns["UnitNo"].Visible = false;
            DataGridViewComboBoxColumn unitColumn = new DataGridViewComboBoxColumn();
            this.dgv_Drug.Columns.Add(unitColumn);
            unitColumn.Name = "Unit";
            unitColumn.HeaderText = "单位";
            unitColumn.DataSource = unitTable;
            unitColumn.DisplayMember = "UnitName";
            unitColumn.ValueMember = "UnitNo";
            unitColumn.DataPropertyName = "UnitNo";
            unitColumn.DisplayIndex = 6;
            unitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Drug.Columns[this.dgv_Drug.Columns.Count - 2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
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
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_ExamineItemType";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable typeTable = new DataTable();
            DataTable exmaineTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(typeTable);
            sqlCommand.CommandText = $@"SELECT * FROM tb_ExamineItems";
            sqlDataAdapter.Fill(exmaineTable);
            sqlConnection.Close();
            this.ExamineTable = exmaineTable;
            this.dgv_Exmaine.Columns.Clear();
            this.dgv_Exmaine.DataSource = exmaineTable;
            this.dgv_Exmaine.Columns["ExamineItemNo"].ReadOnly = true;
            this.dgv_Exmaine.Columns["ExamineItemNo"].HeaderText = "项目编号";
            this.dgv_Exmaine.Columns["Name"].HeaderText = "项目名称";
            this.dgv_Exmaine.Columns["Price"].HeaderText = "价格";
            this.dgv_Exmaine.Columns["Introduction"].HeaderText = "简介";
            this.dgv_Exmaine.Columns["ExamineItemTypeNo"].Visible = false;
            DataGridViewComboBoxColumn typeColumn = new DataGridViewComboBoxColumn();
            this.dgv_Exmaine.Columns.Add(typeColumn);
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "类型";
            typeColumn.DataSource = typeTable;//数据源
            typeColumn.DisplayMember = "Name";//显示的列
            typeColumn.ValueMember = "No";//对应的值
            typeColumn.DataPropertyName = "ExamineItemTypeNo";//两张表绑定列
            typeColumn.DisplayIndex = 2;//定位，第几列，从0开始
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_Exmaine.Columns[this.dgv_Exmaine.Columns.Count - 2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// 单击保存按钮保存药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveDrug_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand insertCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_Drug
	            (ChineseName,EnglishName,Ingredient,Treat,Specification,UnitNo,Manufacturer,PurchasePrice,SellingPrice,ExpirationDate)
	            VALUES
	            (@ChineseName,@EnglishName,@Ingredient,@Treat,@Specification,@UnitNo,@Manufacturer,@PurchasePrice,@SellingPrice,@ExpirationDate)";
            insertCommand.Parameters.Add("@ChineseName", SqlDbType.VarChar, 0, "ChineseName");
            insertCommand.Parameters.Add("@EnglishName", SqlDbType.VarChar, 0, "EnglishName");
            insertCommand.Parameters.Add("@Ingredient", SqlDbType.VarChar, 0, "Ingredient");
            insertCommand.Parameters.Add("@Treat", SqlDbType.VarChar, 0, "Treat");
            insertCommand.Parameters.Add("@Specification", SqlDbType.VarChar, 0, "Specification");
            insertCommand.Parameters.Add("@UnitNo", SqlDbType.Int, 0, "UnitNo");
            insertCommand.Parameters.Add("@Manufacturer", SqlDbType.VarChar, 0, "Manufacturer");
            insertCommand.Parameters.Add("@PurchasePrice", SqlDbType.Decimal, 2, "PurchasePrice");
            insertCommand.Parameters.Add("@SellingPrice", SqlDbType.Decimal, 2, "SellingPrice");
            insertCommand.Parameters.Add("@ExpirationDate", SqlDbType.Int, 0, "ExpirationDate");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText = $@"UPDATE tb_Drug
	                                        SET
		                                        ChineseName=@ChineseName,
		                                        EnglishName=@EnglishName,
		                                        Ingredient=@Ingredient,
		                                        Treat=@Treat,
		                                        Specification=@Specification,
		                                        UnitNo=@UnitNo,
		                                        Manufacturer=@Manufacturer,
		                                        PurchasePrice=@PurchasePrice,
		                                        SellingPrice=@SellingPrice,
		                                        ExpirationDate=@ExpirationDate
	                                        WHERE
		                                        DrugNo=@DrugNo";
            updateCommand.Parameters.Add("@ChineseName", SqlDbType.VarChar, 0, "ChineseName");
            updateCommand.Parameters.Add("@EnglishName", SqlDbType.VarChar, 0, "EnglishName");
            updateCommand.Parameters.Add("@Ingredient", SqlDbType.VarChar, 0, "Ingredient");
            updateCommand.Parameters.Add("@Treat", SqlDbType.VarChar, 0, "Treat");
            updateCommand.Parameters.Add("@Specification", SqlDbType.VarChar, 0, "Specification");
            updateCommand.Parameters.Add("@UnitNo", SqlDbType.Int, 0, "UnitNo");
            updateCommand.Parameters.Add("@Manufacturer", SqlDbType.VarChar, 0, "Manufacturer");
            updateCommand.Parameters.Add("@PurchasePrice", SqlDbType.Decimal, 2, "PurchasePrice");
            updateCommand.Parameters.Add("@SellingPrice", SqlDbType.Decimal, 2, "SellingPrice");
            updateCommand.Parameters.Add("@ExpirationDate", SqlDbType.Int, 0, "ExpirationDate");
            updateCommand.Parameters.Add("@DrugNo", SqlDbType.Int, 0, "DrugNo");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_Drug WHERE DrugNo=@DrugNo";
            deleteCommand.Parameters.Add("@DrugNo", SqlDbType.Int, 0, "DrugNo");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable DrugTable = (DataTable)this.dgv_Drug.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(DrugTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
        /// <summary>
        /// 单击保存按钮保存检查项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveExamine_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand insertCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令
            insertCommand.Connection = sqlConnection;
            insertCommand.CommandText = $@"INSERT INTO tb_ExamineItems
	                                        (Name,ExamineItemTypeNo,Price,Introduction)
	                                        VALUES
	                                        (@Name,@ExamineItemTypeNo,@Price,@Introduction)";
            insertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            insertCommand.Parameters.Add("@ExamineItemTypeNo", SqlDbType.Int, 0, "ExamineItemTypeNo");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            insertCommand.Parameters.Add("@Introduction", SqlDbType.VarChar, 0, "Introduction");
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = sqlConnection;
            updateCommand.CommandText = $@"UPDATE tb_ExamineItems
	                                            SET
		                                            Name=@Name,
		                                            ExamineItemTypeNo=@ExamineItemTypeNo,
		                                            Price=@Price,
		                                            Introduction=@Introduction
	                                            WHERE
	                                                ExamineItemNo=@ExamineItemNo";
            updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 0, "Name");
            updateCommand.Parameters.Add("@ExamineItemTypeNo", SqlDbType.Int, 0, "ExamineItemTypeNo");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 2, "Price");
            updateCommand.Parameters.Add("@Introduction", SqlDbType.VarChar, 0, "Introduction");
            updateCommand.Parameters.Add("@ExamineItemNo", SqlDbType.Int, 0, "ExamineItemNo");
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = sqlConnection;
            deleteCommand.CommandText =
                "DELETE tb_ExamineItems WHERE ExamineItemNo=@ExamineItemNo";
            deleteCommand.Parameters.Add("@ExamineItemNo", SqlDbType.Int, 0, "ExamineItemNo");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = insertCommand;
            sqlDataAdapter.UpdateCommand = updateCommand;
            sqlDataAdapter.DeleteCommand = deleteCommand;
            DataTable ExamineTable = (DataTable)this.dgv_Exmaine.DataSource;
            sqlConnection.Open();
            int rowAffected = sqlDataAdapter.Update(ExamineTable);
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}
