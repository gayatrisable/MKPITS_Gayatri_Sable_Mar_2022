using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_1_to_10_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to print no from 1 to 10 using while loop
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadLine();
        }
    }
}
