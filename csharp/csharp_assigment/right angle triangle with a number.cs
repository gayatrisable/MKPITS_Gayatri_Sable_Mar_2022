using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle_with_a_number
{//10. Write a program in C# Sharp to display the pattern like right angle triangle with a number.
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
                    Console.Write(j);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
