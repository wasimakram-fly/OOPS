using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_ex22
{
    internal class Program
    {
        public class employee
        {
            int empid, empage;
            public int pempid
            {
                set
                {
                    empid = value;
                }
                get
                {
                    return empid;
                }
            }
            public int pempage
            {
                set
                {
                    empage = value;
                }
                get
                {
                    return empage;
                }
            }
        }
        static void Main(string[] args)
        {
            employee e1 = new employee();
            Console.WriteLine("Enter employee id: ");
            e1.pempid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee age: ");
            e1.pempage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee id is: " + e1.pempid);
            Console.WriteLine("Employee age is: " + e1.pempage);
            Console.ReadLine();
        }
    }
}
