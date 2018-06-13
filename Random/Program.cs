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
            System.Random r = new System.Random();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i+"==");
                double result = r.NextDouble();
                Console.WriteLine(result.ToString());
            }

        }
    }
}
