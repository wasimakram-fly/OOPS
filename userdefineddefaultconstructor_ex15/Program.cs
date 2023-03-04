using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdefineddefaultconstructor_ex15
{
    internal class Program
    {
        public class employee
        {
            int empno, empid;
            string empname, empaddress;

            public employee()   // user-defined constructor
            {
                empno = 1;
                empid = 101;
                empname = "Smith";
                empaddress = "Street no. 101, Road No.4, LA, US";
            }

            public void display()
            {
                Console.WriteLine("Employee No.: " + empno);
                Console.WriteLine("Employee Id.: " + empid);
                Console.WriteLine("Employee Name: " + empname);
                Console.WriteLine("Employee Address: " + empaddress);
            }
        }
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.display();
            Console.ReadLine();
        }
    }
}
