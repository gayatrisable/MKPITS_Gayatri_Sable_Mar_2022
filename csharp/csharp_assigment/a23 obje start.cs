﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1.object_custno_custname_custaddress_custtelno
{
    //1- create a class customer having fields custno,custname,custaddress,custtelno
    public class Customer
    {
        public int number;
        public string name;
        public string address;
        public long tel_number;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.Write("Enter customer number: ");
            customer.number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name: ");
            customer.name = Console.ReadLine();

            Console.Write("Enter customer address: ");
            customer.address = Console.ReadLine();

            Console.Write("Enter customer telephone number: ");
            customer.tel_number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter customer number: " + customer.number);
            Console.WriteLine("Enter customer name: " + customer.name);
            Console.WriteLine("Enter customer address: " + customer.address);
            Console.WriteLine("Enter customer telephone number: " + customer.tel_number);
            Console.ReadLine();
        }
    }
}
