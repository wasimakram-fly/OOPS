using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor_ex18
{
    public class a     
    {
        static a()            
        {
           Console.WriteLine("I am a static constructor.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("I am a static Main() method constructor.");
            Console.ReadLine();
        }
    }
}
