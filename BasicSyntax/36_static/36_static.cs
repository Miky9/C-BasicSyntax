using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Uzivatel
    {
        public string jmeno; //vyjímečně public
        public string heslo;
        internal bool prihlaseny;
        private int id;
        public static int minimalniDelkaHesla = 6; //statický atribut náleží třídě, není na instanci objektu
        private static int dalsiId = 1;


        public Uzivatel(string jmeno, string heslo)
        {
            this.jmeno = jmeno;
            this.heslo = heslo;
            prihlaseny = false;
            id = dalsiId;
            dalsiId++;
        }

        public bool PrihlasSe(string zadaneHeslo)
        {
            if (zadaneHeslo == heslo)
            {
                prihlaseny = true;
                return true;
            }
            else
                return false; // hesla nesouhlasí
        }

        public int VratId()
        {
            return id;
        }

        //statické metody
        public static bool ZvalidujHeslo(string heslo) //Díky tomu, že metoda ZvalidujHeslo() náleží třídě, nemůžeme v ní přistupovat k žádným instančním atributům.
        {
            if (heslo.Length >= minimalniDelkaHesla)
            {
                // podrobnou logiku validace hesla vynecháme
                return true;
            }
            return false;
        }

        public static int VratMinimalniDelkuHesla()
        {
            return minimalniDelkaHesla;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Uzivatel.minimalniDelkaHesla);
            Console.WriteLine(Uzivatel.ZvalidujHeslo("heslojeveslo"));
            Console.ReadKey();

            Uzivatel u = new Uzivatel("Tomáš Marný", "heslojeveslo2");
            Console.WriteLine("ID prvního uživatele: {0}", u.VratId());
            Uzivatel v = new Uzivatel("Olí Znusinudle", "csfd");
            Console.WriteLine("ID druhého uživatele: {0}", v.VratId());
            Console.WriteLine("Minimální délka hesla uživatele je: {0}", Uzivatel.VratMinimalniDelkuHesla());
            Console.WriteLine("Validnost hesla uživatele {0} je: {1}", u.jmeno, Uzivatel.ZvalidujHeslo(u.heslo));
            Console.WriteLine("Validnost hesla uživatele {0} je: {1}", v.jmeno, Uzivatel.ZvalidujHeslo(v.heslo));
            //
            //Console.WriteLine("Uzivatel {0} zadal heslo: {1}", u.jmeno, "blbost");
            ////Console.WriteLine("Uzivatele {0} je/není přihlášen: {1}", u.jmeno, (u.PrihlasSe("heslojeveslo2")).ToString());
            //if ((u.PrihlasSe("blbost")) == true)
            //    Console.WriteLine("Uzivatele {0} je přihlášen", u.jmeno);
            //else
            //    Console.WriteLine("Uzivatele {0} není přihlášen", u.jmeno);

            //Console.WriteLine("Uzivatel {0} zadal heslo: {1}", u.jmeno, "heslojeveslo2");
            //if (u.PrihlasSe("heslojeveslo2"))
            //    Console.WriteLine("Uzivatele {0} je přihlášen", u.jmeno);
            //else
            //    Console.WriteLine("Uzivatele {0} není přihlášen", u.jmeno);

            u.prihlaseny = u.PrihlasSe("blbost");
            Console.WriteLine("Uzivatel {0} zadal heslo: {1}", u.jmeno, "blbost");
            if (u.prihlaseny)
                Console.WriteLine("Uzivatel {0} je přihlášen", u.jmeno);
            else
                Console.WriteLine("Uzivatel {0} není přihlášen", u.jmeno);

            u.prihlaseny = u.PrihlasSe("heslojeveslo2");
            Console.WriteLine("Uzivatel {0} zadal heslo: {1}", u.jmeno, "heslojeveslo2");
            if (u.prihlaseny)
                Console.WriteLine("Uzivatel {0} je přihlášen", u.jmeno);
            else
                Console.WriteLine("Uzivatel {0} není přihlášen", u.jmeno);

            Console.ReadKey();
        }
    }
}


//namespace _41_static_register
//{
//    static class Nastaveni
//    {
//        private static string jazyk = "CZ";
//        private static string barevneSchema = "cervene";
//        private static bool spustitPoStartu = true;

//        public static string Jazyk()
//        {
//            return jazyk;
//        }

//        public static string BarevneSchema()
//        {
//            return barevneSchema;
//        }

//        public static bool SpustitPoStartu()
//        {
//            return spustitPoStartu;
//        }

//    }

//    class Kalendar
//    {

//        public string VratNastaveni()
//        {
//            string s = "";
//            s += String.Format("Jazyk: {0}\n", Nastaveni.Jazyk());
//            s += String.Format("Barevné schéma: {0}\n", Nastaveni.BarevneSchema());
//            s += String.Format("Spustit po startu: {0}\n", Nastaveni.SpustitPoStartu());
//            return s;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Kalendar kalendar = new Kalendar();
//            Console.WriteLine(kalendar.VratNastaveni());
//            Console.ReadKey();
//        }
//    }
//}

//Většina předávání dat do instance probíhá pomocí parametru v konstruktoru, nikoli přes statiku.