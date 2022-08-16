using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Enter_integer_display_name
{//20. Write a program in C# Sharp to read any day number in integer and display day name in the word.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number 1 to 7 : ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("SUNDAY!");
            }
            else if (num == 2)
            {
                Console.WriteLine("MONDAY!");
            }
            else if (num == 3)
            {
                Console.WriteLine("TUESDAY!");
            }
            else if (num == 4)
            {
                Console.WriteLine("WEDNESDAY!");
            }
            else if (num == 5)
            {
                Console.WriteLine("SUNDAY!");
            }
            else if (num == 6)
            {
                Console.WriteLine("FRIDAY!");
            }
            else if (num == 7)
            {
                Console.WriteLine("SATURDAY!");
            }
            else
            {
                Console.WriteLine("Please Enter the number between 1 to 7!");
            }
            Console.ReadLine();
        }
    }
}
