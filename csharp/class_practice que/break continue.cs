using System//;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The break statement jumps out of an iteration
            //The continue statement jumps to the next iteration
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);

                i++;
                if (i <= 20)
                    continue;
                else
                    break;
            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
