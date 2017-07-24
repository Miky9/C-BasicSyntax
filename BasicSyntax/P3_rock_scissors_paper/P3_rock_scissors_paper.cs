using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamen_nuzky
{
    enum Zbrane { kámen = 1, nůžky = 2, papír = 3 }
    class Program
    {
        static void Main(string[] args)
        {
            Zbrane Zbran1, Zbran2;
            string jmeno1 = "Petr";
            string jmeno2 = "Lucie";
            Hrac hrac1 = new Hrac(jmeno1);
            Hrac hrac2 = new Hrac(jmeno2);
            for (int i = 1; i < 10; i++)
            {
                Zbran1 = hrac1.ZvolZbran();
                Zbran2 = hrac2.ZvolZbran();
                Console.Write("{0} {1}", hrac1.jmeno, Zbran1);
                Console.WriteLine(" {0} {1}", hrac2.jmeno, Zbran2);
                Hra hra = new Hra(hrac1, hrac2, Zbran1, Zbran2);
                Console.WriteLine(hra.Vyhodnot());
                Console.ReadKey(true);
            }
        }
    }
}

namespace kamen_nuzky
{
    class Hrac
    {
        public string jmeno;
        public Zbrane zbran;

        private static Random random = new Random();

        public Hrac(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public Zbrane ZvolZbran()
        {
            int nahVolba = random.Next(1, 4);
            return zbran = (Zbrane)nahVolba;
            //return string.Format("{0} dává {1}.", jmeno, zbran);
        }
    }
}

namespace kamen_nuzky
{
    class Hra
    {
        //Hrac hrac1 = new Hrac("Petr"); //sem potřebuji propojení s proměnnou jmeno1
        //Hrac hrac2 = new Hrac("Lucie");//sem potřebuji propojení s proměnnou jmeno2
        private Zbrane Zbran1;
        private Zbrane Zbran2;
        private Hrac hrac1;
        private Hrac hrac2;

        public Hra(Hrac hrac1, Hrac hrac2, Zbrane Zbran1, Zbrane Zbran2)
        {
            this.hrac1 = hrac1;
            this.hrac2 = hrac2;
            this.Zbran1 = Zbran1;
            this.Zbran2 = Zbran2;
        }
        public string Vyhodnot()
        {
            if (Zbran1 == Zbrane.kámen && Zbran2 == Zbrane.kámen)
                return "remíza";
            else if (Zbran1 == Zbrane.kámen && Zbran2 == Zbrane.nůžky)
                return hrac1.jmeno;
            else if (Zbran1 == Zbrane.kámen && Zbran2 == Zbrane.papír)
                return hrac2.jmeno;
            else if (Zbran1 == Zbrane.nůžky && Zbran2 == Zbrane.nůžky)
                return "remíza";
            else if (Zbran1 == Zbrane.nůžky && Zbran2 == Zbrane.kámen)
                return hrac2.jmeno;
            else if (Zbran1 == Zbrane.nůžky && Zbran2 == Zbrane.papír)
                return hrac1.jmeno;
            else if (Zbran1 == Zbrane.papír && Zbran2 == Zbrane.papír)
                return "remíza";
            else if (Zbran1 == Zbrane.papír && Zbran2 == Zbrane.kámen)
                return hrac1.jmeno;
            else if (Zbran1 == Zbrane.papír && Zbran2 == Zbrane.nůžky)
                return hrac2.jmeno;
            return "";
        }
    }
}
