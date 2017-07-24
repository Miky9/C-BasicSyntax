using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_arena
{
    /// <summary>
    /// Třída reprezentuje hrací kostku
    /// </summary>
    class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetSten;

        //konstruktor
        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        //Pomocí this jsme specifikovali, že levá proměnná pocetSten náleží instanci, pravou C# chápe jako z parametru. 


        //stary konstruktor 2
        //public Kostka(int aPocetSten)
        //{
        //    pocetSten = aPocetSten;
        //    random = new Random();
        //}


        //konstruktor 2 - default

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }

        //stary konstruktor
        //public Kostka()
        //{
        //    pocetSten = 6;
        //    random = new Random();
        //}

        /// <summary>
        /// Vrátí počet stěn hrací kostky
        /// </summary>
        /// <returns>počet stěn hrací kostky</returns>
        public int VratPocetSten()
        {
            return pocetSten;
        }

        /// <summary>
        /// Vykoná hod kostkou
        /// </summary>
        /// <returns>Číslo od 1 do počtu stěn</returns>
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }

        //Next(): Varianta bez parametru vrací náhodné číslo v celém rozsahu datového typu int;
        //Next(Do): Vrací nezáporná čísla menší než mez Do.random.Next(100) tedy vrátí číslo od 0 do 99.
        //Next(Od, Do): Vrátí náhodné číslo v zadané mezi, přičemž Od do intervalu patří a Do již ne.
        //Tedy náhodné číslo od 1 do 100 by bylo random.Next(1, 101);

        /// <summary>
        /// Vrací textovou reprezentaci kostky
        /// </summary>
        /// <returns>Textová reprezentace kostky</returns>
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami", pocetSten);
        }


    }
}
