using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace properties_ex21
{
    internal class Program
    {
        public class student
        {
            int num1, num2, result;
            public int pnum1       // write only property
            {
                set
                {
                    num1 = value;
                }
            }
            public int pnum2    // write only property
            {
                set
                {
                    num2 = value;
                }
            }

            public int presult  // read only property
            {
                get
                {
                    return result;
                }
            }
            public void add()
            {
                result = num1 + num2;
            }
            public void multiply()
            {
                result = num1 * num2;
            }
        }
        static void Main(string[] args)
        {
            student s = new student();
            Console.WriteLine("Enter any two numbers ");
            s.pnum1 = Convert.ToInt32(Console.ReadLine());
            s.pnum2 = Convert.ToInt32(Console.ReadLine());
            s.add();
            Console.WriteLine("Sum is: " + s.presult);
            s.multiply();
            Console.WriteLine("Multiplication is: " + s.presult);
            Console.ReadLine();
        }
    }
}
