﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace array_sort_method_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(12);
            ar.Add(13);
            //displaying values of arraylist
            Console.WriteLine("array list colection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }

            //sorting
            ar.Sort();
            Console.WriteLine("array list colection with sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            Console.ReadLine();
        }
    }
}

        
    

