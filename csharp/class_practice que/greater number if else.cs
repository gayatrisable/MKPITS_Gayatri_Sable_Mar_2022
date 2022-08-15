using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_number_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to accept 2 no. and print greater no.by if else
            int a, b;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a+" is greater number");

            }
            else
            {
                Console.WriteLine(b + " is greater number");
            }
            Console.ReadLine();
        }
    }
}
