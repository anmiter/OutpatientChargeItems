using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OutpatientCharges2._0.Patient
{
    /// <summary>
    /// 病历窗体
    /// </summary>
    public partial class frm_MedicalRecord : Form
    {
        public frm_MedicalRecord()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// 患者编号
        /// </summary>
        int PatientNo;
        /// <summary>
        /// 传参载入
        /// </summary>
        /// <param name="PatientNo"></param>
        public frm_MedicalRecord(int PatientNo) : this()
        {
            this.PatientNo = PatientNo;
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"";
        }
        private void frm_MedicalRecord_Load(object sender, EventArgs e)
        {
            /*USE OutpatientChargesBase
            SELECT* FROM tb_MedicalRecord AS MR
                JOIN tb_Patient AS P ON MR.PaitentNo = P.PaitentNo

    JOIN tb_Doctor AS D ON MR.DoctorNo = D.DoctorNo

    JOIN tb_Department AS De ON D.DepartmentNo = De.DepartmentNo

    JOIN tb_Title AS T ON D.TitleNo = T.TitleNo

    JOIN tb_Bill AS B ON P.PaitentNo = B.PaitentNo


    JOIN tb_ExamineList AS EList ON P.PaitentNo = EList.PaitentNo AND MR.Time = EList.Time

    JOIN tb_ExamineItemsList AS EIList ON EIList.ItemListNo = EList.ItemListNo
            */

        }
    }
}
