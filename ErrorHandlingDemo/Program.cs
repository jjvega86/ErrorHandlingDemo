﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(list1[6]);
            Console.ReadLine();

        }
    }
}