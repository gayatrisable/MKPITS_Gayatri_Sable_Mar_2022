using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.vowel_or_consonant
{//16. Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Character: ");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U' )
            {
                Console.WriteLine("The alphabet is a Vowel!");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant!");
            }
            Console.ReadLine();
        }
    }
}
