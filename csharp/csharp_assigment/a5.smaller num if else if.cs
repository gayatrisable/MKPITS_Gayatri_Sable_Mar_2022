using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a5.smaller_num_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 wap to accept 3 no. and display smaller no. by if else if else
            int num1, num2, num3;
            Console.WriteLine("Enter the 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1 + " is smaller number");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2 + " is smaller  number");
            }
            else
            {
                Console.WriteLine(num3 + " is smaller number!");
            }
            Console.ReadLine();
        }
    }
}
