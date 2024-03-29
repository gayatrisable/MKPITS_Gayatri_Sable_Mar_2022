﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Queue_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            q.Enqueue('E');
            q.Enqueue('F');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            Console.ReadLine();

        }
    }
}
