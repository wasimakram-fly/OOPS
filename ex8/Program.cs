using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Program
    {
        public class parent
        {
            public virtual void sum()
            {
                int x = 10, y = 20, z;
                z = x + y;
                Console.WriteLine("The sum fo x & y is: " + z);
            }
            public void display()
            {
                Console.WriteLine("I am from display()");
            }
        }
        public class child : parent
        {
            public override void sum()
            {
                base.sum();
                int x = 100, y = 200, z = 300, res;
                res = x + y + z;
                Console.WriteLine("The sum of x, y and z values is: " + res);
            }
        }
        static void Main(string[] args)
        {
            child c1 = new child();
            c1.sum();
            c1.display();
            Console.ReadLine();
        }
    }
}
