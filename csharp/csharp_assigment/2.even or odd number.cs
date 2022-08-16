using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.even_odd
{
    internal class Program
    {//2. Write a C# Sharp program to check whether a given number is even or odd.
        static void Main(string[] args)
        {
            Console.WriteLine("---------check number the even or odd---------");
            int a, res;
            Console.WriteLine("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
            res = a % 2;
            if (res==0)
            {
                Console.WriteLine(a + " This number is even!");
            }
            else
            {
                Console.WriteLine(a + " This number is odd!");
            }
            Console.ReadLine();
        }
    }
}
