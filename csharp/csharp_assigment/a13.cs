﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a._13product_name_by_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 wap to accept productname, productrate, quantity calculate totalamount, discount ie 50 % if totalamount > 2000 else discount = 10 % of total amount
            string p_name;
            int h = 0;
            float p_rate, p_qua, t_amt, discount = 0;
            Console.WriteLine("Enter product name");
            p_name = Console.ReadLine();
            Console.WriteLine("Enter product rate");
            p_rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product quantity");
            p_qua = Convert.ToInt32(Console.ReadLine());
            t_amt = p_rate * p_qua;
            if (t_amt > 2000)
            {
                h = 1;
            }
            switch (h)
            {
                case 1:
                    discount = t_amt - t_amt * (50 / 100.0f);
                    Console.WriteLine("total amount after discount: " + discount);
                    break;
                default:
                    discount = t_amt - t_amt * (10 / 100.0f);
                    Console.WriteLine("total amount after discount: " + discount);
                    break;
            }
            Console.ReadLine();
        }
    }
}
