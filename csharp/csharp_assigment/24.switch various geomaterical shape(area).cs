﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.switch__various_geomatrical_shape
{//24. Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various  geometrical shape.
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, r, l, w, b, h;
            double area = 0;
            Console.Write("Input 1 for area of circle\n");
            Console.Write("Input 2 for area of rectangle\n");
            Console.Write("Input 3 for area of triangle\n");
            Console.Write("Input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Input radius of the circle : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Input length  of the rectangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case 3:
                    Console.Write("Input the base of the triangle :");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = .5 * b * h;
                    break;
                default:
                    Console.WriteLine("please enter valid choice!");
                    break;
            }
            Console.Write("The area is : {0} ", area);
            Console.ReadLine();
        }
    }
}
