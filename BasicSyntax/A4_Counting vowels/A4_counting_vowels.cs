using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4_Counting_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            // řetězec, který chceme analyzovat
            string s = "Programátor se zasekne ve sprše, protože instrukce na šampónu byly: Namydlit, omýt, opakovat.";
            Console.WriteLine(s);
            s = s.ToLower();

            // inicializace počítadel
            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;

            // definice typů znaků
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";

            // hlavní cyklus
            foreach (char c in s)
            {
                if (samohlasky.Contains(c))
                    pocetSamohlasek++;
                else
                if (souhlasky.Contains(c))
                    pocetSouhlasek++;
            }
            Console.WriteLine("Samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Nepísmenných znaků: {0}", s.Length - (pocetSamohlasek + pocetSouhlasek));

            Console.ReadKey();



        }
    }
}
