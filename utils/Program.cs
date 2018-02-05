using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace utils
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Parse("2018-01-05");
            Console.WriteLine( dt.DateStringFromNow());
           
        }
    }
}
