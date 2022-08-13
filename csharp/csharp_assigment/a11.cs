using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a11.switch_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 example to accept 2 no . and opertor
            int s1, s2;
            char op;
            int res = 0;
            Console.WriteLine("enter num1 ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator like + - * ");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res = s1 + s2;
                    break;
                case '-':

                    res = s1 - s2;
                    break;
                case '*':
                    res = s1 * s2;
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            Console.WriteLine("result = " + res);
            Console.ReadLine();
        }
    }
}
