using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
               
                //int day = random.Next(14, 20);
                //int hour = random.Next(0, 24);
                //int minute = random.Next(0, 60);
                //int second = random.Next(0, 60);
                //string tempStr =
                //    $"{DateTime.Now:yyyy}-{DateTime.Now:MM}-{day} {hour}:{minute}:{second}";
                //DateTime rTime = Convert.ToDateTime(tempStr);
                Console.WriteLine(random.Next(0,2));
            }

        }
    }
}
