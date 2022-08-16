using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.an_integer_m
{
    internal class Program
    {//6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Enter the number:");
            m = Convert.ToInt32(Console.ReadLine());
            if(m==0)
            {
                Console.WriteLine("The value of n = 0");
            }
            else if  (m > 0)
            {
                Console.WriteLine("The value of n = 1");
            }
            else if (m < 0)
            {
                Console.WriteLine("The value of n = -1");
            }
            Console.ReadLine();
        }
    }
}
