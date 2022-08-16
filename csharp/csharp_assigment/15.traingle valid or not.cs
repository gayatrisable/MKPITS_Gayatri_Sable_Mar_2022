using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.triangle_valid_or_not
{//15. Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 1 st angle measure:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 nd angle measure:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3 rd angle measure:");
            c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            if (sum == 180)
            {
                Console.WriteLine("The triangle is valid!");
            }
            else
            {
                Console.WriteLine("The triangle is not valid!");
            }
            Console.ReadLine();
        }
    }
}
