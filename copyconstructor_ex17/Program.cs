using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor_ex17
{
    internal class Program
    {
        public class student
        {
            int sno;
            string sname;

            public student()    // user defined default constructor.
            {
                sno = 101;
                sname = "smith";
            }

            public student(student obj)     // copy constructor.
            {
                sno = obj.sno;
                sname = obj.sname;
            }

            public void display()
            {
                Console.WriteLine("Student number: " + sno);
                Console.WriteLine("Student Name: " + sname);
            }
        }
        static void Main(string[] args)
        {
            student std = new student();
            std.display();
            Console.ReadLine();
        }
    }
}
