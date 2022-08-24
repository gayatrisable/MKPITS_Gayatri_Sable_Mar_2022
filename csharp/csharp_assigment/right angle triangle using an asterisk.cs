using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle_using_an_asterisk
{//9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            // Console.Write("Input number of rows : ");
            //rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 4; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
