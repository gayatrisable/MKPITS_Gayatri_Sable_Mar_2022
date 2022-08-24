using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_increased_by_1
{//12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j,k=1;
            
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ",(k++));
                Console.Write("\n");
                
            }
            Console.ReadLine();
        }
    }
}
