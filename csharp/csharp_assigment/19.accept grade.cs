using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.accept_a_grade
{//19. Write a program in C# Sharp to accept a grade and declare the equivalent description :
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Input Grade:");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='A')
            {
                Console.WriteLine("You have chosen : Average!");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("You have chosen : Excellent!");
            }
            else if (ch == 'v' || ch == 'V')
            {
                Console.WriteLine("You have chosen : Very Good!");
            }
            else if (ch == 'g' || ch == 'G')
            {
                Console.WriteLine("You have chosen : Good!");
            }
            else if (ch == 'f' || ch == 'F')
            {
                Console.WriteLine("You have chosen : Fail!");
            }
            else
            {
                Console.WriteLine("You have chosen : invaid grade!");
            }
            Console.ReadLine();
        }
    }
}
