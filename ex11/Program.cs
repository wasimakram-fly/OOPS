using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    internal class Program
    {
        public class test
        {
            public static int x;    // static variable
            public int abc;         //non-static variable & instance variable
            public static void Add()
            {
                x = 10;             // here we are accessing static variable
                //abc = 20;           // we are try tp acces instance variable inside static method, so it will show error
            }

            public void Add2()
            {
                abc = 20;           // here we can access both static and non-static variables.
                x = 10;
            }
        }

        
        static void Main(string[] args)
        {
            test t1 = new test();
            test.Add();             // classname.methodname() because of static method.
            t1.Add2();              //objectname.methodname() because of instance variable.
            Console.ReadLine();
        }
    }
}
