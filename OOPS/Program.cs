﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(" + " + " ");
                    }
                    else
                    {
                        Console.Write(" - " + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
