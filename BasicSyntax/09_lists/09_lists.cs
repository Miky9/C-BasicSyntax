using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use collection initializer.
            List<string> list1 = new List<string>()
            {
            "carrot",
            "fox",
            "explorer"
            };

            // Use var keyword with collection initializer.
            var list2 = new List<string>()
            {
            "carrot",
            "fox",
            "explorer"
            };

            // Use new array as parameter.
            string[] array = { "carrot", "fox", "explorer" };
            List<string> list3 = new List<string>(array);

            // Use capacity in constructor and assign.
            List<string> list4 = new List<string>(3);
            list4.Add(null); // Add empty references (BAD).
            list4.Add(null);
            list4.Add(null);
            list4[0] = "carrot"; // Assign those references.
            list4[1] = "fox";
            list4[2] = "explorer";

            // Use Add method for each element.
            List<string> list5 = new List<string>();
            list5.Add("carrot");
            list5.Add("fox");
            list5.Add("explorer");

            // Make sure they all have the same number of elements.
            Console.WriteLine(list1.Count);
            Console.WriteLine(list2.Count);
            Console.WriteLine(list3.Count);
            Console.WriteLine(list4.Count);
            Console.WriteLine(list5.Count);

            Console.ReadKey();
        }
    }
}
