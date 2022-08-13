﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2.obj_getcustomerdata_and_displaycustomerdata
{//2- create a class customer having fields custno,custname,custaddress,custtelno and methods getcustomerdata and displaycustomerdata
    public class Customer
    {
        public int number;
        public string name;
        public string address;
        public long tel_number;


        public void get_customer_data(int number, string name, string address, long tel_number)
        {
            this.number = number;
            this.name = name;
            this.address = address;
            this.tel_number = tel_number;
        }
        public void display_customer_data()
        {
            Console.WriteLine("Enter customer number: " + number);
            Console.WriteLine("Enter customer name: " + name);
            Console.WriteLine("Enter customer address: " + address);
            Console.WriteLine("Enter customer telephone number: " + tel_number);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.Write("Enter customer number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter customer address: ");
            string address = Console.ReadLine();

            Console.Write("Enter customer telephone number: ");
            long tel_number = Convert.ToInt64(Console.ReadLine());
            customer.get_customer_data(number, name, address, tel_number);
            Console.WriteLine();
            customer.display_customer_data();
        }
    }
}
