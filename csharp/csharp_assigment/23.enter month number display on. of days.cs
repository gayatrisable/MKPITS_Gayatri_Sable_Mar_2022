using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Enter_month_number_display_no.of_days
{//23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month number:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num==1 || num==3 || num==5 || num==7 ||num==8 || num==10 || num == 12)
            {
                Console.WriteLine("month have 31 days!");
            }
            else if (num == 2)
            {
                Console.WriteLine("the 2nd month is a february and have 28 days.");
                Console.WriteLine("In leap year the february month have 29 days.");
            }
            else if(num==4 || num==6 || num==9 || num == 11)
            {
                Console.WriteLine("month have 30 days!");
            }
            else
            {
                Console.WriteLine("invalid month!");
            }
            Console.ReadLine();
        }
    }
}
