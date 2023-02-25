using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        public class student
        {
            int sid;
            string sname;

            public void setvalues()
            {
                sid = 101;
                sname = "John Smith";
            }

            public void display()
            {
                Console.WriteLine("Student Id is: " + sid);
                Console.Write("Student Name is: " + sname);
            }
        }
        static void Main(string[] args)
        {
            student std = new student();
            std.setvalues();
            std.display();
            Console.ReadLine();
        }
    }
}
