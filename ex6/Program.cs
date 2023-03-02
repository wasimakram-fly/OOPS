using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        public class simpleinterest
        {
            public int p, t, r;
            public float simple()
            {
                Console.Write("Enter p, t and r values: ");
                p = int.Parse(Console.ReadLine());
                t = int.Parse(Console.ReadLine());
                r = int.Parse(Console.ReadLine());
                float si = (p * t * r) / 100;
                return si;
            }
            public void Add()
            {
                r = p + t;
                Console.WriteLine("Sum is: " + r);
            }
        }
        static void Main(string[] args)
        {
            simpleinterest obj = new simpleinterest();
            float s;
            s = obj.simple();
            Console.WriteLine("Simple interest is: " + s);
            obj.Add();
            Console.ReadLine();
        }
    }
}
