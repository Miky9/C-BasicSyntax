using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _31_arena
{
    class Arena
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private Kostka kostka;

        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kostka kostka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kostka = kostka;
        }

        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            Console.WriteLine("Zdraví bojovníků: \n");
            Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.GrafickyZivot());
            Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.GrafickyZivot());
        }

        private void VypisZpravu(string zprava)
        {
            Console.WriteLine(zprava);
            Thread.Sleep(1000); // uspí vlákno programu na daný počet milisekund
        }

        public void Zapas()
        {
            // původní pořadí
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Dnes se utkají {0} s {1}! \n", bojovnik1, bojovnik2);
            // prohození bojovníků
            bool zacinaBojovnik2 = (kostka.hod() <= kostka.VratPocetSten() / 2);
            if (zacinaBojovnik2)
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }
            Console.WriteLine("Začínat bude bojovník {0}! \nZápas může začít...", b1);
            Console.ReadKey();
            // cyklus s bojem
            while (b1.Nazivu() && b2.Nazivu())
            {
                b1.Utoc(b2);
                Vykresli();
                VypisZpravu(b1.VratPosledniZpravu()); // zpráva o útoku
                VypisZpravu(b2.VratPosledniZpravu()); // zpráva o obraně
                if (b2.Nazivu())
                {
                    b2.Utoc(b1);
                    Vykresli();
                    VypisZpravu(b2.VratPosledniZpravu()); // zpráva o útoku
                    VypisZpravu(b1.VratPosledniZpravu()); // zpráva o obraně
                }
                Console.WriteLine();
            }
        }



    }
}
