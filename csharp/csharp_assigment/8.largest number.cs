using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.largest_number
{//8-Write a C# Sharp program to find the largest of three numbers.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter 1 st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2 nd number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3 rd number:");
            c = Convert.ToInt32(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("The 1st Number is the greatest among three!");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The 2nd Number is the greatest among three!");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three!");
            }
            Console.ReadLine();
        }
    }
}
