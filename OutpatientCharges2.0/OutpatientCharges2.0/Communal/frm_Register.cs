using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OutpatientCharges2._0.Communal
{
    /// <summary>
    /// 注册窗体
    /// </summary>
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//本窗体启动位置设为屏幕中央
        }
        /// <summary>
        /// 单击注册按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, EventArgs e)
        {
            //判断电话号码是否为空->判断QQ邮箱是否为空->判断密码是否为空->判断手机号是否注册->判断手机号格式是否正确->判断邮箱格式是否正确->判断邮箱是否被其他手机号注册->检查密码格式是否符号要求
            if (string.IsNullOrWhiteSpace(this.txb_Telephone.Text.Trim()))//判断电话号码是否为空
            {
                MessageBox.Show("请输入电话号码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Telephone.Focus();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(this.txb_QQEmail.Text.Trim())) //判断QQ邮箱是否为空
                {
                    MessageBox.Show("请输入QQ邮箱！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txb_QQEmail.Focus();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(this.txb_Password.Text.Trim()))//判断密码是否为空
                    {
                        MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txb_Password.Focus();
                    }
                    else
                    {
                        if (!CheckFunction.IsExistTelephone(this.txb_Telephone.Text.Trim())) //判断该手机号是否注册
                        {
                            if (CheckFunction.CheckTelephone(this.txb_Telephone.Text.Trim()))//判断手机号格式是否正确
                            {
                                if (CheckFunction.CheckMail(this.txb_QQEmail.Text.Trim()))//判断邮箱格式是否正确
                                {
                                    if (!CheckFunction.IsExistQQEmail(this.txb_QQEmail.Text.Trim()))//判断邮箱是否被其他手机号注册
                                    {
                                        if (CheckFunction.CheckPassword(this.txb_Password.Text.Trim()))//检查密码格式是否符号要求
                                        {
                                            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
                                            sqlConnection.ConnectionString =
                                                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

                                            SqlCommand sqlCommand = sqlConnection.CreateCommand();
                                            sqlCommand.Connection = sqlConnection;
                                            sqlCommand.CommandText =
                                                $@"INSERT tb_Patient
	                                                (Telephone,Email,Password)
	                                                VALUES
	                                                (@Telephone,@Email,HASHBYTES('MD5',@Password))";

                                            sqlCommand.Parameters.AddWithValue("@Telephone", this.txb_Telephone.Text.Trim());//向SQL命令的参数集合添加参数的名称、值；
                                            sqlCommand.Parameters.AddWithValue("@Email", this.txb_QQEmail.Text.Trim());
                                            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
                                            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;//将密码参数的类型设为变长字符串；
                                                                                                             //SQL参数自动识别类型；若参数值为字符串，则类型自动设为NVARCHAR，且可在执行时自动转换；
                                                                                                             //但对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;

                                            sqlConnection.Open();//打开SQL连接
                                            int rowAffected = sqlCommand.ExecuteNonQuery();//调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                                            sqlConnection.Close();//关闭SQL连接；

                                            if (rowAffected == 1)//若查得所输用户号相应的1行记录；
                                            {
                                                MessageBox.Show("注册成功！");
                                                Communal.frm_LoginByPassword frm_LoginByPassword = new Communal.frm_LoginByPassword(this.txb_Telephone.Text.Trim());
                                                frm_LoginByPassword.ShowDialog();
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.txb_Password.Focus(); //密码文本框获得焦点；
                                                this.txb_Password.SelectAll();//密码文本框内所有文本被选中；
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("密码必须至少8个字符，至少一个大写字母，一个小写字母，一个数字和一个特殊字符！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txb_Password.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("该QQ邮箱已被注册！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Communal.frm_LoginByEmail frm_LoginByEmail = new frm_LoginByEmail();
                                        frm_LoginByEmail.ShowDialog();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("QQ邮箱格式错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.txb_QQEmail.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("手机号码格式错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txb_Telephone.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("该手机号已注册！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Communal.frm_LoginByPassword frm_LoginByPassword = new frm_LoginByPassword();
                            frm_LoginByPassword.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
