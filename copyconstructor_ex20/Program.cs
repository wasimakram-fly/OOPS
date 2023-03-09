using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor_ex20
{
    internal class Program
    {
        public class a
        {
            public a()
            {
                Console.WriteLine("I am default constructor.");
            }
            public a(int x)
            {
                Console.WriteLine("I am single parameterized constructor");
            }
            public a(int x, int y)
            {
                Console.WriteLine("I am two parameterized constructor");
            }
        }
        static void Main(string[] args)
        {
            a a1 = new a();
            a a2 = new a(10);
            a a3 = new a(20,10);
            Console.ReadLine();
        }
    }
}
