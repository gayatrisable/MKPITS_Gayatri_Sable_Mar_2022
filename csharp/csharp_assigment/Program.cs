using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_reactangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the Length:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int a = num1 * num2;
            Console.WriteLine("Area of Rectangle:"+ a);
            Console.ReadLine();
        }
    }
}
