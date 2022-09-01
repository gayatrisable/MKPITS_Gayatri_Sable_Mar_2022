using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace sort_list_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("001", "neha");
            sl.Add("002", "nikita");
            sl.Add("007", "ram");
            sl.Add("006", "Om");
            sl.Add("008", "Gayatri");
            sl.Add("005", "Meena");
            sl.Add("009", "Ritesh Saikia");

            if (sl.ContainsValue("Dattuji"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("003", "Sable");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
            Console.ReadLine();
        }
    }
}
