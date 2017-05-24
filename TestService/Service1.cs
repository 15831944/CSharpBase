using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public  void OnStart()
        {
            Console.WriteLine("启动了------");
            for (int i = 0; i < 100; i++)
            {
                AddTextLine(string.Format("输入第{0}次", i));
            }
            Console.ReadKey();
        }
        protected override void OnStop()
        {
            //服务结束执行代码
        }
        protected override void OnPause()
        {
            //服务暂停执行代码
            base.OnPause();
        }
        protected override void OnContinue()
        {
            //服务恢复执行代码
            base.OnContinue();
        }
        protected override void OnShutdown()
        {
            //系统即将关闭执行代码
            base.OnShutdown();
        }
        private void PrintExceptions(Exception exc)
        {
            Exception current = exc;
            while (current != null)
            {
                this.AddTextLine(current.Message);
                this.AddTextLine(current.StackTrace);

                current = current.InnerException;
            }
        }

        private void AddTextLine(string line)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\TeamWorldServiceLog.txt", FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter m_streamWriter = new StreamWriter(fs);

                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);

                m_streamWriter.WriteLine(line + "\r\n");

                m_streamWriter.Flush();

                m_streamWriter.Close();

                fs.Close();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
