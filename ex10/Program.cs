using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dec = 389.5m;
            bool isSharpFun = true;
            bool isFishTasty = false;
            DateTime today = DateTime.Now;
            Guid obj = Guid.NewGuid();
            var a = 'f';
            var b = "test";
            var c = 30.67;
            var d = false;
            var e = 54544;
            //e = "45";     here we can't change dynamically value of e

            dynamic val1 = "test";
            val1 = 3234; // here we can change the value of 'val1' dynamically, just by using dynamic datatype.

            // Get the actual type of dynamic variables using GetType() method.
            Console.WriteLine("Type of 'a' is: {0}", a.GetType());
            Console.WriteLine(e);
            Console.WriteLine("Guid is: " + obj.ToString());
            DateTime date1 = new DateTime(2015, 12, 25);
            Console.WriteLine(date1.ToString());
            Console.WriteLine(dec);
            Console.WriteLine(isSharpFun);
            Console.WriteLine(isFishTasty);
            Console.WriteLine(today);
            Console.ReadLine();
        }
    }
}
