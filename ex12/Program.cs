using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        public class parent
        {
            static int a = 20, b = 30, c;
            int x = 20, y = 30, z;

            public static void add()
            {
                c = a + b;
                Console.WriteLine(a + b);
            }

            public void div()
            {
                z = x + y;
                c = a + b;
                Console.WriteLine(a + b);
            }

            public void sub()
            {
                z = x + y;
                Console.WriteLine(a + b);
                c = a + b;
            }
        }
        static void Main(string[] args)
        {
            parent obj = new parent();
            obj.div();
            parent.add();
            Console.ReadLine();
        }
    }
}
