using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_arena
{
    class Program
    {
        static void Main(string[] args)
        {
            // vytvoření
            Kostka sestistenna = new Kostka();
            Kostka desetistenna = new Kostka(10);

            Console.WriteLine(sestistenna.VratPocetSten());
            Console.WriteLine("{0}\n",desetistenna.VratPocetSten());
   

            // hod šestistěnnou
            Console.WriteLine(sestistenna); //defaultní metoda ToString: bez override se vypíše cesta k třídě
            for (int i = 0; i < 10; i++)
                Console.Write(sestistenna.hod() + " ");

            // hod desetistěnnou
            Console.WriteLine("\n\n" + desetistenna);
            for (int i = 0; i < 10; i++)
                Console.Write(desetistenna.hod() + " ");

            //// hra
            //Kostka kostka = new Kostka(10);
            //Bojovnik bojovnik = new Bojovnik("Zalgoren", 100, 20, 10, kostka);

            //Console.WriteLine("\n\nBojovník: {0}", bojovnik); // test ToString();
            //Console.WriteLine("Naživu: {0}", bojovnik.Nazivu()); // test Nazivu();
            //Console.WriteLine("Život: {0}", bojovnik.GrafickyZivot()); // test GrafickyZivot();

            //// test útoku
            //bojovnik.Utoc(bojovnik); 
            //Console.WriteLine("\nŽivot po útoku: {0}", bojovnik.GrafickyZivot());

            //// útok na našeho bojovníka
            //Bojovnik souper = new Bojovnik("\nShadow", 60, 18, 15, kostka);
            //souper.Utoc(bojovnik);
            //Console.WriteLine(souper.VratPosledniZpravu());
            //Console.WriteLine(bojovnik.VratPosledniZpravu());

            //Console.WriteLine("Život: {0}", bojovnik.GrafickyZivot());

            Console.WriteLine("\n\n");


           // vytvoření objektů
           Kostka kostka = new Kostka(10);
            Bojovnik zalgoren = new Bojovnik("Zalgoren", 100, 20, 10, kostka);
            Bojovnik shadow = new Bojovnik("Shadow", 60, 18, 15, kostka);
            Arena arena = new Arena(zalgoren, shadow, kostka);
            
            // zápas
            arena.Zapas();
            Console.ReadKey();



















            Console.ReadKey();





        }
    }
}
