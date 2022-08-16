using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Month_number_display_number
{//22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month number:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("JANUARY");
            }
            else if (num == 2)
            {
                Console.WriteLine("FEBRUARY");
            }
            else if (num == 3)
            {
                Console.WriteLine("MARCH");
            }
            else if (num == 4)
            {
                Console.WriteLine("APRIL");
            }
            else if (num == 5)
            {
                Console.WriteLine("MAY");
            }
            else if (num == 6)
            {
                Console.WriteLine("JUNE");
            }
            else if (num == 7)
            {
                Console.WriteLine("JULY");
            }
            else if (num == 8)
            {
                Console.WriteLine("AUGEST");
            }
            else if (num == 9)
            {
                Console.WriteLine("SEPETEMBER");
            }
            else if (num == 10)
            {
                Console.WriteLine("OCTOMBER");
            }
            else if (num == 11)
            {
                Console.WriteLine("NOVEMBER");
            }
            else if (num == 12)
            {
                Console.WriteLine("DECEMBER");
            }
            else
            {
                Console.WriteLine("invalid month");
            }
            Console.ReadLine();
        }
    }
}
