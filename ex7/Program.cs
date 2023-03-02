using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        public class a
        {
            public void add()
            {
                Console.WriteLine("I am without parameterized method");
            }
            public void add(int x)
            {
                Console.WriteLine("I am single parameterized method");
            }
            public void add(int x, int y)
            {
                int t = x + y;
                Console.WriteLine(t);
                Console.WriteLine("I am two parameterised method");
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter x, y values: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            a a1 = new a();
            a1.add();
            a1.add(x);
            a1.add(x, y);
            Console.ReadLine();

        }
    }
}
