using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        // Creating Class "addition"
        public class addition
        {
            // declaring variables
            int a = 20, b = 80, c;

            // declaring method
            public void add()
            {
                c = a + b;
                Console.Write("Sum is: " + c);
            }

        }
        static void Main(string[] args)
        {
            // creating an object for class
            addition obj1 = new addition();

            // calling a method
            obj1.add();
            Console.ReadLine();
        }
    }
}
