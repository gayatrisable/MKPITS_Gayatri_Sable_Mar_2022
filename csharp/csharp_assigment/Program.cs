using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a14.vowel_by_switch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //11- wap to accept character from the user and display whether it is vowel or not.
            char ch;
            Console.WriteLine("enter character");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Entered character is vowel");
                    break;
                case 'e':
                    Console.WriteLine("Entered character is vowel");
                    break;
                case 'i':
                    Console.WriteLine("Entered character is vowel");
                    break;
                case 'o':
                    Console.WriteLine("Entered character is vowel");
                    break;
                case 'u':
                    Console.WriteLine("Entered character is vowel");
                    break;
                default:
                    Console.WriteLine("enter character is not vowel");
                    break;
            }
            Console.ReadLine();
        }
    }
}
