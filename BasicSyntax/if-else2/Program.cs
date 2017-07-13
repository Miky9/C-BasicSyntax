using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej nějaké číslo");
            int a = int.Parse(Console.ReadLine());
            if (a > 5)
                Console.WriteLine("Zadal jsi číslo větší než 5!");
            Console.WriteLine("Děkuji za zadání");
            Console.ReadKey();
        }
    }
}
