using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {           // example of multilevel inheritance
        public class branches       // base class
        {
            public int bcode;
            public string bname, baddress;
            public void getdata()
            {
                Console.Write("Enter branch code: ");
                bcode = int.Parse(Console.ReadLine());
                Console.Write("Enter branch name: ");
                bname = Console.ReadLine();
                Console.Write("Enter branch address: ");
                baddress = Console.ReadLine();
            }
            public void displaydata()
            {
                Console.WriteLine("Branch Code is: " + bcode);
                Console.WriteLine("Branch name is: " + bname);
                Console.WriteLine("Branch address is: " + baddress);
            }
        }

        public class employee : branches      // inheriting branches class here
        {
            public int empid, empage;
            public string empname, empaddress;
            public void getempdata()
            {
                Console.Write("Enter employee Id: ");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                empname = Console.ReadLine();
                Console.Write("Enter employee age: ");
                empage = int.Parse(Console.ReadLine());
                Console.Write("Enter employee address: ");
                empaddress = Console.ReadLine();
            }
            public void displayempdata()
            {
                Console.WriteLine("Branch Code is: " + bcode);
                Console.WriteLine("Branch name is: " + bname);
                Console.WriteLine("Branch address is: " + baddress);
                Console.WriteLine("Employee Id: " + empid);
                Console.WriteLine("Employee Name: " + empname);
                Console.WriteLine("Employee age: " + empage);
                Console.WriteLine("Employee address: " + empaddress);
            }
        }
        public class salary : employee
        {
            public double basic, da, hra, gross;
            public void getsaldetails()
            {
                Console.Write("Enter basic salary: ");
                basic=double.Parse(Console.ReadLine());
            }
            public void calculate()
            {
                da = 0.4 * basic;
                hra = 0.3 * basic;
                gross = basic + da + hra;
            }
            public void displaysaldetails()
            {
                Console.WriteLine("Branch Code is: " + bcode);
                Console.WriteLine("Branch name is: " + bname);
                Console.WriteLine("Branch address is: " + baddress);
                Console.WriteLine("Employee Id: " + empid);
                Console.WriteLine("Employee Name: " + empname);
                Console.WriteLine("Employee age: " + empage);
                Console.WriteLine("Employee address: " + empaddress);
                Console.WriteLine("Employee basic salary: " + basic);
                Console.WriteLine("Employee da is: " + da);
                Console.WriteLine("Employee hra is: " + hra);
                Console.WriteLine("Employee gross salary: " + gross);
            }
        }
        static void Main(string[] args)
        {
            salary sa = new salary();
            sa.getdata();
            sa.getempdata();
            sa.displaydata();
            sa.displayempdata();
            sa.getsaldetails();
            sa.calculate();
            sa.displaysaldetails();
            Console.ReadLine();
        }
    }
}
