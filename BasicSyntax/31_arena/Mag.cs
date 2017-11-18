using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_arena
{
    class Mag : Bojovnik
    {
        private int mana;
        private int maxMana;
        private int magickyUtok;

        public Mag(string jmeno, int zivot, int utok, int obrana, Kostka kostka, int mana, int magickyUtok) : base(jmeno, zivot, utok, obrana, kostka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magickyUtok = magickyUtok;
        }

        //public override void Utoc(Bojovnik souper) //override = přepisování zděděné metody
        //{
        //    int uder = 0;
        //    // Mana není naplněna
        //    if (mana < maxMana)
        //    {
        //        mana += 10;
        //        if (mana > maxMana)
        //            mana = maxMana;
        //        uder = utok + kostka.hod();
        //        NastavZpravu(String.Format("{0} útočí s úderem za {1} hp", jmeno, uder));
        //    }
        //    else // Magický útok
        //    {
        //        uder = magickyUtok + kostka.hod();
        //        NastavZpravu(String.Format("{0} použil magii za {1} hp", jmeno, uder));
        //        mana = 0;
        //    }
        //    souper.BranSe(uder);
        //}

        public override void Utoc(Bojovnik souper) ///použití base - volání na předkovi
        {
            // Mana není naplněna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utoc(souper);
            }
            else // Magický útok
            {
                int uder = magickyUtok + kostka.hod();
                NastavZpravu(String.Format("{0} použil magii za {1} hp", jmeno, uder));
                souper.BranSe(uder);
                mana = 0;
            }
        }

        public string GrafickaMana()
        {
            return GrafickyUkazatel(mana, maxMana);
        }

    }






    }
