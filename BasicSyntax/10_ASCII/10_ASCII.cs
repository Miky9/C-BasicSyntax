using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char c; // znak
            int i; // ordinální (ASCII) hodnota znaku
                   // převedeme znak na jeho ASCII hodnotu
            c = 'a';
            i = (int)c;
            Console.WriteLine("Znak {0} jsme převedli na ASCII hodnotu {1}", c, i);
            // Převedeme ASCII hodnotu na znak
            i = 98;
            c = (char)i;
            Console.WriteLine("ASCII hodnotu {1} jsme převedli na znak {0}", c, i);
            Console.ReadKey();

        }
    }
}
