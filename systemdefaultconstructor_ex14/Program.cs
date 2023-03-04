using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemdefaultconstructor_ex14
{
    internal class Program
    {
        public class employee
        {
            int empno, empid;
            string empname, empaddress;

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
