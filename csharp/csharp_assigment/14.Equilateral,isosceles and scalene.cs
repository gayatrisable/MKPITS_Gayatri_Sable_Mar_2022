using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equilateral__Isosceles_or_Scalene
{//14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 1st angle: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd angle: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd angle: ");
            c = Convert.ToInt32(Console.ReadLine());
            if(a==b && b==c && a==c)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if(a==b || b == c)
            {
                Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is Scalene triangle.");
            }
            Console.ReadLine();
        }
    }
}
