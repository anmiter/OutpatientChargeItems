using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Patient
{
    /// <summary>
    /// 首页窗体
    /// </summary>
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 电话号码
        /// </summary>
        string Telephone;
        /// <summary>
        /// 患者编号
        /// </summary>
        int PaitentNo;
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="telephone"></param>
        public frm_Home(string telephone) : this()
        {
            this.Telephone = telephone;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Patient WHERE Telephone='{this.Telephone}'";

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.PaitentNo = int.Parse(sqlDataReader["PaitentNo"].ToString());
                this.lbl_PaitentID.Text = sqlDataReader["Identification"].ToString();
                this.lbl_Telephone.Text = sqlDataReader["Telephone"].ToString();
                if (sqlDataReader["Telephone"] == DBNull.Value || sqlDataReader["Name"] == DBNull.Value || sqlDataReader["MedicalCard"] == DBNull.Value || sqlDataReader["Email"] == DBNull.Value || sqlDataReader["Identification"] == DBNull.Value)
                {
                    frm_PersonalCenter frm_PersonalCenter = new frm_PersonalCenter(this.PaitentNo);
                    MessageBox.Show("请完善个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_PersonalCenter.ShowDialog();
                }
                if (sqlDataReader["Avatar"] != DBNull.Value)
                {
                    byte[] photoBytes = (byte[])sqlDataReader["Avatar"];
                    MemoryStream memoryStream = new MemoryStream(photoBytes);//内存流
                    this.ptb_Avatar.Image = Image.FromStream(memoryStream);
                }
            }
            sqlDataReader.Close();
        }
        /// <summary>
        /// 个人中心窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PersonalCenter_Click(object sender, EventArgs e)
        {
            Patient.frm_PersonalCenter frm_PersonalCenter = new Patient.frm_PersonalCenter(this.PaitentNo);
            frm_PersonalCenter.ShowDialog();
        }
        /// <summary>
        /// 单击查看病历按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowMedicalRecord_Click(object sender, EventArgs e)
        {
            Patient.frm_MedicalRecord frm_MedicalRecord = new frm_MedicalRecord(this.PaitentNo);
            frm_MedicalRecord.ShowDialog();
        }
        /// <summary>
        /// 单击价目查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PriceSearch_Click(object sender, EventArgs e)
        {
            Patient.frm_PriceSearch frm_PriceSearch = new frm_PriceSearch();
            frm_PriceSearch.ShowDialog();
        }
        private void frm_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
