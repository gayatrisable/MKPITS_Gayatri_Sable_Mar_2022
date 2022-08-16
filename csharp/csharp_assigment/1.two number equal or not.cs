using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.two_number_equal_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
            int a,b;
            Console.WriteLine("enter the 1st number:");
           a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2st number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a==b)
            {
                Console.WriteLine(a+ " and " +b+ " equal number!");
            }
            else
            {
                Console.WriteLine(a+ " and " +b+ " are not equal number!");
            }
            Console.ReadLine();
        }
    }
}
