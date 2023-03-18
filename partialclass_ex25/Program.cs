using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass_ex25
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            Console.WriteLine("Full name: {0} {1}", person.FirstName, person.LastName);
            Console.ReadLine();
        }
    }
}
