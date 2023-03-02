﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex4
{
    internal class Program
    {
        public class branches
        {
            public int bcode;
            public string bname, baddress;
            public void getdata()
            {
                Console.Write("Enter branch code: ");
                bcode=int.Parse(Console.ReadLine());
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

        public class employee:branches      // inheriting branches class here
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
        
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata();
            emp.getempdata();
            emp.displaydata();
            emp.displayempdata();
            Console.ReadLine();
        }
    }
}
