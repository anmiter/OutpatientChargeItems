using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace OutpatientCharges2._0.Patient
{
    /// <summary>
    /// 个人中心窗体
    /// </summary>
    public partial class frm_PersonalCenter : Form
    {
        public frm_PersonalCenter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
            this.cmb_Province.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// 患者编号
        /// </summary>
        int PatientNo;
        /// <summary>
        /// 传参载入
        /// </summary>
        /// <param name="id"></param>
        public frm_PersonalCenter(int patientNo) : this()
        {
            this.PatientNo = patientNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Province";
            sqlCommand2.CommandText = $@"SELECT * FROM tb_Patient WHERE PaitentNo='{this.PatientNo}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable provinceTable = new DataTable();
            sqlConnection.Open();//打开SQL连接；
            sqlDataAdapter.Fill(provinceTable);
            this.cmb_Province.DataSource = provinceTable;
            this.cmb_Province.DisplayMember = "Province";
            this.cmb_Province.ValueMember = "ProvinceNo";
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_PaitentNo.Text = sqlDataReader["PaitentNo"].ToString();
                if (sqlDataReader["Name"] != DBNull.Value)
                {
                    this.txb_Name.Text = sqlDataReader["Name"].ToString();
                }
                if (sqlDataReader["Gender"] != DBNull.Value)
                {
                    this.rdb_Male.Checked = (bool)sqlDataReader["Gender"];
                    this.rdb_Female.Checked = !(bool)sqlDataReader["Gender"];
                }
                if (sqlDataReader["Age"] != DBNull.Value)
                {
                    this.nud_Age.Value = decimal.Parse(sqlDataReader["Age"].ToString());
                }
                if (sqlDataReader["BirthDay"] != DBNull.Value)
                {
                    this.dtp_Birthday.Value = (DateTime)sqlDataReader["BirthDay"];
                }
                if (sqlDataReader["Identification"] != DBNull.Value)
                {
                    this.txb_Identification.Text = sqlDataReader["Identification"].ToString();
                }
                if (sqlDataReader["Telephone"] != DBNull.Value)
                {
                    this.txb_Telephone.Text = sqlDataReader["Telephone"].ToString();
                }
                if (sqlDataReader["Email"] != DBNull.Value)
                {
                    this.txb_Email.Text = sqlDataReader["Email"].ToString();
                }
                if (sqlDataReader["ProvinceNo"] != DBNull.Value)
                {
                    this.cmb_Province.SelectedValue = (int)sqlDataReader["ProvinceNo"];
                }
                if (sqlDataReader["MedicalCard"] != DBNull.Value)
                {
                    this.txb_MedicalCard.Text = sqlDataReader["MedicalCard"].ToString();
                }
                if (sqlDataReader["Avatar"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])sqlDataReader["Avatar"];
                    MemoryStream memoryStream = new MemoryStream(photoBytes);//内存流
                    this.ptb_Avatar.Image = Image.FromStream(memoryStream);
                }
            }
            sqlConnection.Close();
        }
        /// <summary>
        /// 单击更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //判空->验证身份证号->验证手机号->验证QQ邮箱
            if (this.txb_Telephone.Text.Trim() != "" && this.txb_Name.Text.Trim() != "" && this.txb_MedicalCard.Text.Trim() != "" && this.txb_Identification.Text.Trim() != "" && this.txb_Email.Text.Trim() != "")
            {
                if (CheckFunction.CheckID(this.txb_Identification.Text.Trim()))
                {
                    if (CheckFunction.CheckTelephone(this.txb_Telephone.Text.Trim()))
                    {
                        if (CheckFunction.CheckMail(this.txb_Email.Text.Trim()))
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            this.ptb_Avatar.Image.Save(memoryStream, ImageFormat.Bmp);
                            byte[] photoBytes = new byte[memoryStream.Length];
                            memoryStream.Seek(0, SeekOrigin.Begin);
                            memoryStream.Read(photoBytes, 0, photoBytes.Length);
                            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                            sqlConnection.ConnectionString =
                                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.CommandText =
                                $@"UPDATE tb_Patient
	                                    SET Name=@Name
	                                    ,Gender=@Gender
	                                    ,Age=@Age
	                                    ,Birthday=@BirthDay
	                                    ,Identification=@Identification
	                                    ,Telephone=@Telephone
	                                    ,Email=@Email
	                                    ,ProvinceNo=@ProvinceNo
	                                    ,MedicalCard=@MedicalCard
                                        ,Avatar=@Avatar
	                                    WHERE PaitentNo={this.PatientNo}";
                            sqlCommand.Parameters.AddWithValue("@Name", this.txb_Name.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Gender", this.rdb_Male.Checked);
                            sqlCommand.Parameters.AddWithValue("@Age", this.nud_Age.Value);
                            sqlCommand.Parameters.AddWithValue("@BirthDay", this.dtp_Birthday.Value);
                            sqlCommand.Parameters.AddWithValue("@Identification", this.txb_Identification.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Telephone", this.txb_Telephone.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Email", this.txb_Email.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@ProvinceNo", (int)this.cmb_Province.SelectedValue);
                            sqlCommand.Parameters.AddWithValue("@MedicalCard", this.txb_MedicalCard.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Avatar", photoBytes);
                            sqlConnection.Open();
                            int rowAffected = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                            if (rowAffected == 1)
                            {
                                MessageBox.Show("更新成功！");
                            }
                            else
                            {
                                MessageBox.Show("更新失败，可再次尝试！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("QQ邮箱格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txb_Identification.Focus();
                            this.txb_Identification.SelectAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机号格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txb_Identification.Focus();
                        this.txb_Identification.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("身份证号格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txb_Identification.Focus();
                    this.txb_Identification.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("加*为必填项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// 点击打开照片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg;*png;*gif"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.ptb_Avatar.Image = Image.FromFile(fileName);
            }
        }
    }
}
