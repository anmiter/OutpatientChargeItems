﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientCharges2._0
{
    /// <summary>
    /// 发送邮箱函数
    /// </summary>
    internal class SendFunction
    {
        /// <summary>
        ///  生成随机验证码
        /// </summary>
        /// <param name="CodeLength">验证码长度</param>
        public static string CreateRandomMailCode(int CodeLength)
        {
            int randNum;
            char code;
            string randomCode = String.Empty;//随机验证码

            //生成一定长度的随机验证码       
            //Random random = new Random();//生成随机数对象
            for (int i = 0; i < CodeLength; i++)
            {
                //利用GUID生成6位随机数      
                byte[] buffer = Guid.NewGuid().ToByteArray();//生成字节数组
                int seed = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
                Random random = new Random(seed);//以生成的整数作为随机种子
                randNum = random.Next();

                //randNum = random.Next();                
                if (randNum % 3 == 1)
                {
                    code = (char)('A' + (char)(randNum % 26));//随机大写字母
                }
                else if (randNum % 3 == 2)
                {
                    code = (char)('a' + (char)(randNum % 26));//随机小写字母
                }
                else
                {
                    code = (char)('0' + (char)(randNum % 10));//随机数字
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }
        /// <summary>
        ///  发送邮件验证码
        /// </summary>
        /// <param name="MyEmailAddress">发件人邮箱地址</param>
        /// <param name="RecEmailAddress">收件人邮箱地址</param>
        /// <param name="Subject">邮件主题</param>
        /// <param name="MailContent">邮件内容</param>
        /// <param name="AuthorizationCode">邮箱授权码</param>
        /// <returns></returns>
        public static bool SendMailMessage(string MyEmailAddress, string RecEmailAddress, string Subject, string Body, string AuthorizationCode)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(MyEmailAddress);//发件人邮箱地址
            mail.To.Add(new MailAddress(RecEmailAddress));//收件人邮箱地址
            mail.Subject = Subject;//邮件标题
            mail.Body = Body;  //邮件内容  
            mail.Priority = MailPriority.High;//优先级

            SmtpClient client = new SmtpClient();//qq邮箱:smtp.qq.com；126邮箱:smtp.126.com              
            client.Host = "smtp.qq.com";
            client.Port = 587;//SMTP端口465或587
            client.EnableSsl = true;//使用安全加密SSL连接  
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(MyEmailAddress, AuthorizationCode);//验证发件人身份(发件人邮箱，邮箱授权码);                   

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
