using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Profit_loss
{//17. Write a C# Sharp program to calculate profit and loss on a transaction.
    internal class Program
    {
        static void Main(string[] args)
        {
            int cost, sell;
            Console.WriteLine("Enter the cost price:");
            cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the selling price:");
            sell = Convert.ToInt32(Console.ReadLine());
            if (cost > sell)
            {
                int profit=cost-sell;
                Console.WriteLine("You can book your profit amount : " + profit);
            }
            else if (cost < sell)
            {
                int loss = sell - cost;
                Console.WriteLine("You can book your loss amount : " + loss);
            }
            else
            {
                Console.WriteLine("no profit no loss");
            }
            Console.ReadLine();
        }
    }
}
