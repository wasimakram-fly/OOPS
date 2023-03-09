using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ex23
{
    internal class Program
    {
        public abstract class employee
        {
            protected int eid, eage;
            protected string ename, eaddress;
            public double bonus, ca;
            public abstract void DisplayManagerData();
            public void GetEmpDetails()
            {
                Console.WriteLine("Enter employee id: ");
                eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee name: ");
                ename = Console.ReadLine();
                Console.WriteLine("Employee bonus is: ");
                bonus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter ca: ");
                ca = Convert.ToDouble(Console.ReadLine());
            }
        }
        public class salary:employee
        {
            public override void DisplayManagerData()
            {
                Console.WriteLine("Manager id is: " + eid);
                Console.WriteLine("Manager name is: " + ename);
                Console.WriteLine("Manager ca is: " + ca);
            }
        }
        static void Main(string[] args)
        {
            salary s1 = new salary();
            s1.GetEmpDetails();
            s1.DisplayManagerData();
            Console.ReadLine();
        }
    }
}
