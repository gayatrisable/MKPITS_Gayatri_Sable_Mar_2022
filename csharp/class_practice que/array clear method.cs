﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 2, 4 };

            Array.Clear(num, 0, 2);

            //display the values of array
            for (int i = 0; i < num.Length; i++)
            {

                Console.Write(num[i] + "\t");

            }
            Console.ReadLine();
        }
    }
}
