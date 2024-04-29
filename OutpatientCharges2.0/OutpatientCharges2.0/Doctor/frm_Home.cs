using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Doctor
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
        /// 医生编号
        /// </summary>
        int DoctorNo;
        /// <summary>
        /// 传参载入
        /// </summary>
        /// <param name="DoctorNo"></param>
        public frm_Home(int doctorNo) : this()
        {
            this.DoctorNo = doctorNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Doctor WHERE DoctorNo='{this.DoctorNo}'";

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.lbl_Name.Text = sqlDataReader["Name"].ToString();
                this.lbl_Telephone.Text = sqlDataReader["Telephone"].ToString();
            }
            sqlDataReader.Close();
        }
        /// <summary>
        /// 单击修改价目按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModifyPrice_Click(object sender, EventArgs e)
        {
            Doctor.frm_ModifyPrice frm_ModifyPrice = new Doctor.frm_ModifyPrice();
            frm_ModifyPrice.ShowDialog();
        }
    }
}
