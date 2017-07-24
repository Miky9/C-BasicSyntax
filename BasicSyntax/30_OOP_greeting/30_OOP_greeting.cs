using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Zdravic zdravic;
            zdravic = new Zdravic();

            zdravic.text = "Ahoj uživateli";
            Console.WriteLine(zdravic.Pozdrav("Petr"));
            zdravic.text = "Vítám tě tu programátore";
            Console.WriteLine(zdravic.Pozdrav("Richard"));
            Console.ReadKey();

        }
    }
}
