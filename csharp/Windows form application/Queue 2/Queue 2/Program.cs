using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Queue_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Neha");
            q.Enqueue("Mona");
            q.Enqueue("Gayatri");
            q.Enqueue("Gagan");

            Console.WriteLine("Current queue: ");
            foreach (string c in q)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            q.Enqueue("ram");
            q.Enqueue("Himesh");
            Console.WriteLine("Current queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            string ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            ch = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.ReadLine();
        }
    }
}
