using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.leap_year_or_not
{
    internal class Program
    {//4. Write a C# Sharp program to find whether a given year is a leap year or not.
        static void Main(string[] args)
        {
            Console.WriteLine("----------------whether a given year is a leap year or not.------------");
            int a;
            Console.WriteLine("Enter the year:");
            a = Convert.ToInt32(Console.ReadLine());
            if( a % 4 == 0 )//or (a % 400==0 || a % 4 == 0 || a % 100 == 0)
            {
                Console.WriteLine(a + " leap year!");
            }
            else
            {
                Console.WriteLine(a + " not leap  year!");
            }
            Console.ReadLine();
        }
    }
}
