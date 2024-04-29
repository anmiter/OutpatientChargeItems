using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutpatientCharges2._0
{
    /// <summary>
    /// 验证函数
    /// </summary>
    internal class CheckFunction
    {
        /// <summary>
        ///  验证QQ邮箱
        /// </summary>
        /// <param name="mail">邮箱</param>
        /// <returns></returns>
        public static bool CheckMail(string mail)
        {
            string str = @"^[1-9][0-9]{4,}@qq.com$";
            Regex mReg = new Regex(str);

            if (mReg.IsMatch(mail))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 检查手机号的格式是否错误
        /// </summary>
        /// <param name="Telephone"></param>
        /// <returns></returns>
        public static bool CheckTelephone(string Telephone)
        {
            string pattern = "^1[34578]\\d{9}$"; // 正则表达式模式  
            bool isValid = Regex.IsMatch(Telephone, pattern);
            return isValid;
        }
        /// <summary>
        /// 检查密码格式是否符号要求
        /// </summary>
        /// <param name="Telephone"></param>
        /// <returns></returns>
        public static bool CheckPassword(string Password)
        {
            string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{8,}$"; // 正则表达式模式  
            bool isValid = Regex.IsMatch(Password, pattern);
            return isValid;
        }
        /// <summary>
        /// 检查身份证号格式是否符号要求
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static bool CheckID(string Id)
        {
            string pattern = "^\\d{18}$"; // 正则表达式模式  
            bool isValid = Regex.IsMatch(Id, pattern);
            return isValid;
        }
        /// <summary>
        /// 检查手机号是否被注册
        /// </summary>
        /// <param name="Telephone"></param>
        /// <returns></returns>
        public static bool IsExistTelephone(string Telephone)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
            $@"SELECT COUNT(1) FROM tb_Patient WHERE Telephone=@account";

            sqlCommand.Parameters.AddWithValue("@account", Telephone);//向SQL命令的参数集合添加参数的名称、值；

            sqlConnection.Open();//打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
            sqlConnection.Close();//关闭SQL连接；

            if (rowCount == 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 检查邮箱是否被注册
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public static bool IsExistQQEmail(string Email)
        {
            SqlConnection sqlConnection = new SqlConnection(); //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString; //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
            $@"SELECT COUNT(1) FROM tb_Patient WHERE Email=@Email";

            sqlCommand.Parameters.AddWithValue("@Email", Email);//向SQL命令的参数集合添加参数的名称、值；

            sqlConnection.Open();//打开SQL连接；
            int rowCount = (int)sqlCommand.ExecuteScalar();//调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
            sqlConnection.Close();//关闭SQL连接；

            if (rowCount == 1)
            {
                return true;
            }
            return false;
        }
    }
}
