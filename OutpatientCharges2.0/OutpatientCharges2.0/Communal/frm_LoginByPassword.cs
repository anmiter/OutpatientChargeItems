using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Communal
{
    /// <summary>
    /// 密码登录窗体
    /// </summary>
    public partial class frm_LoginByPassword : Form
    {
        public frm_LoginByPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="Telephone"></param>
        public frm_LoginByPassword(string Telephone) : this()
        {
            this.txb_Account.Text = Telephone;
        }
        /// <summary>
        /// 单击登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //判断是否输入账号->判断是否输入密码->判断身份
            if (string.IsNullOrWhiteSpace(this.txb_Account.Text.Trim()))//如果账号为空
            {
                MessageBox.Show("请输入账号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txb_Account.Focus();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(this.txb_Password.Text.Trim()))//如果密码为空
                {
                    MessageBox.Show("请输入密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txb_Password.Focus();
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                    sqlConnection.ConnectionString =
                        ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                    SqlCommand sqlCommand = sqlConnection.CreateCommand();//调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
                    sqlCommand.Connection = sqlConnection;
                    //是医生->判断密码是否正确
                    if (this.rdb_Doctor.Checked && !this.rdb_Patient.Checked)
                    {
                        sqlCommand.CommandText =
                            $@"SELECT COUNT(1) FROM tb_Doctor WHERE DoctorNo=@DoctorNo AND Telephone=@Telephone";//指定SQL命令的命令文本；命令文本包含参数；
                        sqlCommand.Parameters.AddWithValue("@DoctorNo", this.txb_Account.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                        sqlCommand.Parameters.AddWithValue("@Telephone", this.txb_Password.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                        sqlConnection.Open();//打开SQL连接；
                        int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）
                        sqlConnection.Close();//关闭SQL连接；
                        if (rowCount == 1)
                        {
                            Doctor.frm_Home frm_Home = new Doctor.frm_Home(int.Parse(this.txb_Account.Text.Trim()));
                            frm_Home.ShowDialog();
                            this.Close();
                        }
                        else
                            {
                                MessageBox.Show("密码有误，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txb_Password.Focus(); //密码文本框获得焦点；
                                this.txb_Password.SelectAll();//密码文本框内所有文本被选中；
                            }
                    }
                    //是患者->判断手机号是否被注册->判断密码是否正确
                    if (!this.rdb_Doctor.Checked && this.rdb_Patient.Checked)
                    {
                        if (CheckFunction.IsExistTelephone(this.txb_Account.Text.Trim()))//判断手机号是否被注册
                        {
                            sqlCommand.CommandText =
                                $@"SELECT COUNT(1) FROM tb_Patient WHERE Telephone=@telephone AND Password=HASHBYTES('MD5',@Password)";//指定SQL命令的命令文本；命令文本包含参数；

                            sqlCommand.Parameters.AddWithValue("@telephone", this.txb_Account.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
                            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;//将密码参数的类型设为变长字符串；
                                                                                             //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；
                                                                                             //但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
                            sqlConnection.Open();//打开SQL连接；
                            int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）
                            sqlConnection.Close();//关闭SQL连接；

                            if (rowCount == 1)//若查得所输用户号相应的1行记录；
                            {
                                MessageBox.Show("登录成功！");
                                Patient.frm_Home frm_Home = new Patient.frm_Home(this.txb_Account.Text.Trim());
                                frm_Home.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("密码有误，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txb_Password.Focus(); //密码文本框获得焦点；
                                this.txb_Password.SelectAll();//密码文本框内所有文本被选中；
                            }
                        }
                        else
                        {
                            MessageBox.Show("账号有误或账号不存在，请重新输入！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txb_Account.Focus();
                            this.txb_Account.SelectAll();
                        }
                    }
                    //没选择身份
                    if (!this.rdb_Doctor.Checked && !this.rdb_Patient.Checked)
                    {
                        MessageBox.Show("请选择身份！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// 单击注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            Communal.frm_Register frm_Register = new Communal.frm_Register();
            frm_Register.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// 单击短信登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LoginByEmail_Click(object sender, EventArgs e)
        {
            Communal.frm_LoginByEmail frm_LoginByEmail = new frm_LoginByEmail();
            frm_LoginByEmail.ShowDialog();
            this.Close();
        }
    }
}
