using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    internal class Program
    {
        public class date
        {
            static int day;
            static int month;
            static int year;
            int test;

            public void testmethod()
            {
                Console.WriteLine("Non static method");
            }

            public static void dateg()
            {
                day = DateTime.Now.Day;
                month = DateTime.Now.Month;
                year = DateTime.Now.Year;
            }

            public static void displaydate()
            {
                Console.WriteLine("{0}-{1}-{2}", day, month, year);
            }
        }
        static void Main(string[] args)
        {
            date obj = new date();
            obj.testmethod();   //non static method.
            date.dateg();       //static method.
            date.displaydate(); //static method
            Console.ReadLine();
        }
    }
}
