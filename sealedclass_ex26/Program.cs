using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedclass_ex26
{
    internal class Program
    {
        public class employee
        {
            protected int eid, eage;
            public virtual void getemdata()
            {
                Console.WriteLine("Enter emp id ");
                eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter emp age ");
                eage = Convert.ToInt32(Console.ReadLine());
            }
            public virtual void displayemdata()
            {
                Console.WriteLine("Emp id is " + eid);
                Console.WriteLine("Emp age is " + eage);
            }
        }
        //sealed class
        public sealed class manager:employee
        {
            double bonus, ca;
            public override void getemdata()
            {
                Console.WriteLine("Enter eid details ");
                eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter bonus details ");
                bonus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter ca details ");
                ca = Convert.ToDouble(Console.ReadLine());
            }
            public override void displayemdata() 
            {
                Console.WriteLine("emp id is: " + eid);
                Console.WriteLine("manager bonus is: " + bonus);
                Console.WriteLine("ca is: " + ca);
            }
        }

        //sealed class won't allows us to inherit the sealed class

        //public class test:manager     // here it will show error
        //{

        //}
        static void Main(string[] args)
        {
            manager m1 = new manager();
            m1.getemdata();
            m1.displayemdata();
            Console.ReadLine();
        }
    }
}
