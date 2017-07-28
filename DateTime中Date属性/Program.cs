using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime中Date属性
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = "9/30/2017 10:56:54 AM";
            DateTime date1 = DateTime.Parse(dateString,
                System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date1.ToString(CultureInfo.InvariantCulture));

            // Get date-only portion of date, without its time.
            DateTime dateOnly = date1.Date;
            // Display date using short date string.
            Console.WriteLine(dateOnly);
        }
    }
}
