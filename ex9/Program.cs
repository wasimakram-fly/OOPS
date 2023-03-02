using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Program
    {
        // Access Modifiers
        public class abc
        {
            public int a = 20, b = 30, c;
            private int x = 30, y = 40, z;
            protected int p = 40, q = 30, r;
            internal int i = 25, j = 56, k;
            public void Add()
            {
                c = a + b;
            }
        }

        public class abc2 : abc
        {
            public void Add()
            {
                c = a + b;
                // z = x + y;       // it showing error, bcoz these variables are private so can't acces them to another class.
            }
        }


        public class abc3       // no inhitance is done here (this is nonderived class
        {                       // see how we can access public variale here by using class object & re-assign values.
            abc obj = new abc();        // create object of class 'abc'.

            void Add()
            {
                obj.a = 10;
                obj.b = 20;
            }
        }
        static void Main(string[] args)
        {
            //here we are not giving anything bcoz we just checking how to access variable with different modifiers. 

        }
    }
}
