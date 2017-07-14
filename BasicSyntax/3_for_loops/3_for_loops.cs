using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Knock");
            //}
            //Console.WriteLine("Penny!");
            //Console.ReadKey();



            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i);
            //Console.ReadKey();



            //Console.WriteLine("Malá násobilka pomocí cyklu:");
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 2);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 3);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 4);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 5);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 6);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 7);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 8);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 9);
            //Console.WriteLine();
            //for (int i = 1; i <= 10; i++)
            //    Console.Write("{0} ", i * 10);
            //Console.ReadKey();

            //Console.WriteLine("Malá násobilka pomocí dvou cyklů:");
            //for (int j = 1; j <= 10; j++)
            //{
            //    for (int i = 1; i <= 10; i++)
            //        Console.Write("{0} ", i * j);
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



            Console.WriteLine("Mocninátor");
            Console.WriteLine("==========");
            Console.WriteLine("Zadejte základ mocniny: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte exponent: ");
            int n = int.Parse(Console.ReadLine());
            int vysledek = a;
            for (int i = 0; i < (n - 1); i++)
                vysledek = vysledek * a;
            Console.WriteLine("Výsledek: {0}", vysledek);
            Console.WriteLine("Děkuji za použití mocninátoru");
            Console.ReadKey();





        }
    }
}
