using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.the_total_percentage_and_division
{
    internal class Program
    {//12. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        static void Main(string[] args)
        {
            int roll,phy,chem,comap;
            string name;
            Console.WriteLine("Enter roll No.: ");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter physics marks: ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cemistry marks: ");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Computer application Marks: ");
            comap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Roll NO : " + roll);
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Marks in Physics : " + phy);
            Console.WriteLine("Marks in Cheistry : " + chem);
            Console.WriteLine("Marks in Computer Application : " + comap);
            int total = phy + chem + comap;
            Console.WriteLine("total : " + total);
            float per = total / 3;
            Console.WriteLine("Persentage : " + per);
            if(per>=85)
            {
                Console.WriteLine("Grade : Division");
            }
            else if (per >= 75)
            {
                Console.WriteLine("Grade : first class");
            }
            else if (per >= 55)
            {
                Console.WriteLine("Grade : secound class");
            }
            else if (per >= 35)
            {
                Console.WriteLine("Grade : third class");
            }
            else
            {
                Console.WriteLine("Grade : fail!");
            }
            Console.ReadLine();
        }
    }
}
