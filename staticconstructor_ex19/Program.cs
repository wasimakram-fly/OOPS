using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor_ex19
{
    public class date
    {
        static int day;
        static int month;
        static int year;

        static date()   // static constructor
        {
            day = System.DateTime.Now.Day;
            month = System.DateTime.Now.Month;
            year = System.DateTime.Now.Year;
        }
        static void displaydate()
        {
            Console.WriteLine("{0}-{1}-{2}", day, month, year);
        }
        static void Main(string[] args)
        {
            date.displaydate();     // classname.method()
            Console.ReadLine();
        }
    }
}
