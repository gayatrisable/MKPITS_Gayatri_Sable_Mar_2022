using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeat_a_number_in_a_row
{//11. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
           
            for (i = 1; i <= 8; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(i);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
