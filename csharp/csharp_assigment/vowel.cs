using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a9.vowel_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept character from the user and display whether it is vowel or not.
            char ch;
            Console.WriteLine("Enter the charachter");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel.");
            }
            else
            {
                Console.WriteLine("it is not vowel!");
            }

            Console.ReadLine();
          }
    }

     }

