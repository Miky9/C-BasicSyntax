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

        public override void Utoc(Bojovnik souper) //override = přepisování zděděné metody






    }






}
