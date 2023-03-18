using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ex24
{
    internal class Program
    {
        interface nokia // interface 1
        {
            void sendsms();
            void call();
           // void display();
        }

        interface newnokia  // interface 2
        {
            void bluetooth();   // method 1
            void wifi();        // method 2
        }

        // creating a class

        public class nokia1100:nokia   // one interface     
        {
            public void sendsms()
            {
                Console.WriteLine("We can send sms");
            }

            public void call()
            {
                Console.WriteLine("We can make a call");
            }

        }

        public class nokia3500:nokia,newnokia   // two interfaces
        {
            public void sendsms()
            {
                Console.WriteLine("we can send sms..");
            }
            public void call()
            {
                Console.WriteLine("we can make conference call");
            }

            public void bluetooth()
            {
                Console.WriteLine("we can use bluetooth");
            }

            public void wifi()
            {
                Console.WriteLine("We can use wifi");
            }
        }

        //public class nokia7210:nokia1100,nokia
        //{
        //    public void sendsms()
        //    {
        //        Console.WriteLine("I am from nokia7210 class");
        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("first class is nokia1100");
            Console.WriteLine("second class is nokia3500");

           
            nokia3500 obj2 = new nokia3500();
            obj2.sendsms();
            obj2.call();
            obj2.bluetooth();
            obj2.wifi();

            Console.ReadLine();

        }
    }
}
