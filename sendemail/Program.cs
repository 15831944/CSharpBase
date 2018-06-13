using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace sendemail
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendEmail("2356678657");
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";//使用163的SMTP服务器发送邮件
            client.UseDefaultCredentials = true;
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("worldcup2O18@163.com", "a2151888");//163的SMTP服务器需要用163邮箱的用户名和密码作认证，如果没有需要去163申请个,
            //这里假定你已经拥有了一个163邮箱的账户，用户名为abc，密码为*******
            System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage();
            Message.From = new System.Net.Mail.MailAddress("worldcup2O18@163.com");//这里需要注意，163似乎有规定发信人的邮箱地址必须是163的，而且发信人的邮箱用户名必须和上面SMTP服务器认证时的用户名相同
            //因为上面用的用户名abc作SMTP服务器认证，所以这里发信人的邮箱地址也应该写为abc@163.com
            //Message.To.Add("123456@gmail.com");//将邮件发送给Gmail
            Message.To.Add("372364996@qq.com");//将邮件发送给QQ邮箱
            Message.Subject = "测试标体";
            Message.Body = "测试邮件体";
            Message.SubjectEncoding = System.Text.Encoding.UTF8;
            Message.BodyEncoding = System.Text.Encoding.UTF8;
            Message.Priority = System.Net.Mail.MailPriority.High;
            Message.IsBodyHtml = true;
            client.Send(Message);
            Console.WriteLine("发送成功");
        }
        public static void SendEmail(string msg)
        {
            var mg = new MailMessage();
            mg.To.Add("372364996@qq.com");
            mg.From = new MailAddress("worldcup2O18@163.com", "错误码" + msg, System.Text.Encoding.UTF8);
            mg.Subject = "验证码";
            mg.SubjectEncoding = Encoding.UTF8;//邮件标题编码 
            mg.Body = msg;//邮件内容 
            mg.BodyEncoding = Encoding.UTF8;//邮件内容编码 
            mg.IsBodyHtml = false;//是否是HTML邮件 
            mg.Priority = MailPriority.High;//邮件优先级
            var client = new SmtpClient
            {
                Credentials = new System.Net.NetworkCredential("worldcup2O18@163.com", "a2151888"),
                Host = "smtp.163.com"
            };
            try
            {
                client.Send(mg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
