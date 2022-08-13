﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a8.object_hra_da
{
    public class Employee
    {//A5.8 create a class employee having fields empno,empname ,designation , basicsalary and method calcuatesalary to display
     //hra ie 32% of basicsalary, da ie 43%of basicsalary, ta ie 45% of basicsalary and totalsalary(ie hra+da+ta+basicsalary)
        public int emp_num;
        public string emp_name;
        public string designation;
        public double basic_salary;

        public void calculate_salary(int emp_num, string emp_name, string designation, double basic_salary)
        {
            this.emp_num = emp_num;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basic_salary = basic_salary;

            double hra = .32 * basic_salary;
            double da = .43 * basic_salary;
            double ta = .45 * basic_salary;

            double total_salary = hra + da + ta + basic_salary;
            Console.WriteLine("");
            Console.WriteLine("Employee number: " + emp_num);
            Console.WriteLine("Employee name: " + emp_name);
            Console.WriteLine("Employee designation: " + designation);
            Console.WriteLine("Total Salary: " + total_salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter number: ");
            int emp_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name: ");
            string emp_name = Console.ReadLine();
            Console.Write("Enter employee designation: ");
            string designation = Console.ReadLine();
            Console.Write("Enter basic salary: ");
            double basic_salary = Convert.ToSingle(Console.ReadLine());
            emp.calculate_salary(emp_num, emp_name, designation, basic_salary);
            Console.ReadLine();
        }
    }
}
