using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 批量修改文件名
{
    class Program
    {
        //static public string directoryPath = @"C:\Users\Ezong\Desktop\111";

        static void Main(string[] args)
        {
            Console.WriteLine("开始运行，本程序...");
            Console.WriteLine("输入文件夹路径");
            string directoryPath = Console.ReadLine();
            // 判断给定的目录是否存在  
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("给定的目录不存在");
                Console.WriteLine("程序结束，按任意键退出本程序结束...");
                Console.ReadKey();
                return;
            }

            // 返回当前按下目录下的文件列表  
            DirectoryInfo di = new DirectoryInfo(directoryPath);
            FileInfo[] files = di.GetFiles();
            // 遍历这个目录  
            int index = 0;
            foreach (var item in files)
            {
                item.MoveTo(Path.Combine(directoryPath, index+".jpg"));
                index++;
            }
            int count = 0;
            foreach (FileInfo f in files)
            {
                // 获取一个文件的名字，并解析这个名字。  
                string fileName = f.Name;
                // 方法1  
                /*// 解析这个名字,以空格符来拆分文件名： 
                // 如： “不可思议的旅程(11) 130130 标清.flv” ==> “不可思议的旅程(11)”、“130130”、“标清.flv” 
                string[] nameFragments = fileName.Split(' '); 
                if (nameFragments.Length == 3) 
                { 
                    count++; 
                    // 重命名,将第2段前置 
                    string newFileName = nameFragments[1] + " " + nameFragments[0] + " " + nameFragments[2]; 
                    // 将第3段前置 
                    //string newFileName = nameFragments[2] + " " + nameFragments[0] + " " + nameFragments[1] + " " + nameFragments[3]; 
                    // 将第4段前置 
                    //string newFileName = nameFragments[3] + " " + nameFragments[0] + " " + nameFragments[1] + " " + nameFragments[2] + " " + nameFragments[4]; 
                    f.MoveTo(Path.Combine(directoryPath, newFileName)); 
                }*/
                // 方法2  
                // 解析这个名字,以空格符和'.'字符来拆分文件名：  
                // 如： “不可思议的旅程(11) 130130 标清.flv” ==> “不可思议的旅程(11)”、“130130”、“标清"、“flv”  
                //string[] nameFragments = fileName.Split(' ', '.');
                //if (nameFragments.Length >= 4)
                //{
                //    count++;
                //    // 重命名,将倒数第3段前置  
                //    int dateIndex = nameFragments.Length - 3;
                //    string newFileName = nameFragments[dateIndex];
                //    for (int i = 0; i < nameFragments.Length; i++)
                //    {
                //        if (i == dateIndex) continue;
                //        if (i != nameFragments.Length - 1)
                //        {
                //            newFileName += " " + nameFragments[i];
                //        }
                //        else
                //        {
                //            newFileName += "." + nameFragments[i];
                //        }
                //    }
                //    f.MoveTo(Path.Combine(directoryPath, newFileName));
                //}
            }

            Console.WriteLine("已经成因的修改了{0}个文件名", index);
            Console.WriteLine("程序结束，按任意键退出本程序结束...");
            Console.ReadKey();
        }
    }
}
