using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_arena
{
    class Bojovnik
    {
        /// <summary>
        /// Jméno bojovníka
        /// </summary>
        protected string jmeno;
        /// <summary>
        /// Život v HP
        /// </summary>
        protected int zivot;
        /// <summary>
        /// Maximální zdraví
        /// </summary>
        protected int maxZivot;
        /// <summary>
        /// Útok v HP
        /// </summary>
        protected int utok;
        /// <summary>
        /// Obrana v HP
        /// </summary>
        protected int obrana;
        /// <summary>
        /// Instance hrací kostky
        /// </summary>
        protected Kostka kostka;

        private string zprava;

        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }

        public override string ToString()
        {
            return jmeno;
        }

        //public bool Nazivu()
        //{
        //    if (zivot > 0)
        //        return true;
        //    else
        //        return false;
        //}

        public bool Nazivu()
        {
            return (zivot > 0);
        }

        //public string GrafickyZivot() //nahrazena Graficky ukazatel
        //{
        //    string s = "[";
        //    int celkem = 20;
        //    double pocet = Math.Round(((double)zivot / maxZivot) * celkem);
        //    if ((pocet == 0) && (Nazivu()))
        //        pocet = 1;
        //    for (int i = 0; i < pocet; i++)
        //        s += "#";
        //    s = s.PadRight(celkem + 1);
        //    s += "]";
        //    return s;
        //}

        protected string GrafickyUkazatel(int aktualni, int maximalni)
        {
            string s = "[";
            int celkem = 20;
            double pocet = Math.Round(((double)aktualni / maximalni) * celkem);
            if ((pocet == 0) && (Nazivu()))
                pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkem + 1);
            s += "]";
            return s;
        }

        public string GrafickyZivot()
        {
            return GrafickyUkazatel(zivot, maxZivot);
        }

        public void BranSe(int uder)
        {
            int zraneni = uder - (obrana + kostka.hod());
            if (zraneni > 0)
            {
                zivot -= zraneni;
                zprava = String.Format("{0} utrpěl poškození {1} hp", jmeno, zraneni);
                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }
            } else
                zprava = String.Format("{0} odrazil útok", jmeno);
            NastavZpravu(zprava);
        }

        public virtual void Utoc(Bojovnik souper) //virtual = lze ji v potomkovi přepsat, jinak to není možné
        {
            int uder = utok + kostka.hod();
            NastavZpravu(String.Format("{0} útočí s úderem za {1} hp", jmeno, uder));
            souper.BranSe(uder);
        }


        protected void NastavZpravu(string zprava)
        {
            this.zprava = zprava;
        }

        public string VratPosledniZpravu()
        {
            return zprava;
        }

    }
}
