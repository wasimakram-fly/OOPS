using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Employee
    {
        public int Empid;
        public string Empname;
        public double GrossPay;
        double TaxDeduction = 0.1; // 10%
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            this.Empid = Eid;
            this.Empname = Ename;
            this.GrossPay = Egrosspay;
        }

        private void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is: {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is: {0}", GrossPay);
            }
        }
        public void showDetails()
        {
            this.CalculateSalary();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                        
        }
    }
}
