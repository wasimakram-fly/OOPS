using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class employee
    {
        int empid;
        string empname;
        double bassal, da, hra, tsal;
        
        public void SetValues()
        {
            Console.Write("Enter employee Id: ");
            empid = int.Parse(Console.ReadLine());
            Console.Write("Enter employee Name: ");
            empname = Console.ReadLine();
            Console.Write("Enter employee basic Salary: ");
            bassal=double.Parse(Console.ReadLine());
        }

        public void CalTotalSal()
        {
            da = 0.2 * bassal;
            hra = 0.4 * bassal;
            tsal = da + hra + bassal;
        }

        public void DisplayTotal()
        {
            Console.Write("Employee total Salary is: " + tsal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.SetValues();
            emp.CalTotalSal();
            emp.DisplayTotal();
            Console.ReadLine();
        }
    }
}
