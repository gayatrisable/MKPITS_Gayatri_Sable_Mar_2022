using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table_vertically_from_1_to_n
{//7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n,j;
            Console.Write("Input upto the table number starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++) 
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - 1)
                    {
                        Console.Write("{0} * {1} = {2} ", j, i, (i * j));
                    }
                    else
                    {
                        Console.Write("{0} * {1} ={2}", j, i, (i * j));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
