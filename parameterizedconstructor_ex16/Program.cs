using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterizedconstructor_ex16
{
    internal class Program
    {
       public class employee
        {
            int eno, eage;
            string ename, eaddress;

            public employee(int id, string s1, string s2, int age)
            {
                eno = id;
                eage = age;
                ename = s1;
                eaddress = s2;
            }

            public void display()
            {
                Console.WriteLine("employee no is: " + eno);
                Console.WriteLine("employee name is: " + ename);
                Console.WriteLine("employee age is: " + eage);
                Console.WriteLine("employee address is: " + eaddress);
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            employee emp1 = new employee(101, "smith", "USA", 31);
            emp1.display();
            employee emp2 = new employee(102, "Abdul", "KSA", 33);
            emp2.display();
            employee emp3 = new employee(102, "Zokowich", "Russia", 36);
            emp3.display();
            Console.ReadLine();
        }
    }
}
