﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a5.object_addition_substraction
{//5- create a class calculate having fields num1,num2 and 4 methods addition,substraction, multiplication and division
    public class Calculate
    {
        public float num1;
        public float num2;


        public void addition(float num1, float num2)
        {
            Console.WriteLine("Addition: " + (num1 + num2));
        }
        public void substraction(float num1, float num2)
        {
            Console.WriteLine("substraction: " + (num1 - num2));
        }
        public void multiplication(float num1, float num2)
        {
            Console.WriteLine("multiplication: " + (num1 * num2));
        }
        public void division(float num1, float num2)
        {
            Console.WriteLine("division: " + (num1 / num2));
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.Write("Enter first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
            calc.addition(num1, num2);
            Console.WriteLine("");
            calc.substraction(num1, num2);
            Console.WriteLine("");
            calc.multiplication(num1, num2);
            Console.WriteLine("");
            calc.division(num1, num2);
            Console.ReadLine();
        }
    }
}
