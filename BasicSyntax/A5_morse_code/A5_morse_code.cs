using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_morse_code
{
    class A5_morse_code
    {
        static void Main(string[] args)
        {
            //// řetězec, který chceme dekódovat
            //string s = ".. - -. . - .-- --- .-. -.-";
            //Console.WriteLine("Původní zpráva: {0}", s);
            //// řetězec s dekódovanou zprávou
            //string zprava = "";

            //// vzorová pole
            //string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            //string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            //"..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            //"...-", ".--", "-..-", "-.--", "--.."};

            //// rozbití řetězce na znaky morzeovky
            //string[] znaky = s.Split(' ');

            //// iterace znaků morzeovky
            //foreach (string morseuvZnak in znaky)
            //{
            //    char abecedniZnak = '?';
            //    int index = Array.IndexOf(morseovyZnaky, morseuvZnak);
            //    if (index >= 0) // znak nalezen
            //        abecedniZnak = abecedniZnaky[index];
            //    zprava += abecedniZnak;
            //}
            //Console.WriteLine("Dekódovaná zpráva: {0}", zprava);
            //Console.ReadKey();



            //převod stringu na morse code
            Console.WriteLine("Zadej text, který chceš zakódovat do Morseovy abecedy");
            string vstup = Console.ReadLine();  //načte vstupní text z konzole
            vstup = vstup.ToLower().Trim();  //převede vstupní text na malé písmena a odstraní mezery na začátku a konce řetězce
            string zakodovanytext = ""; //vysledny zakódovaný text do morseovky
     
            //vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
            "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--.." };

            //iterace abecedních znaků
            foreach (char abecedniZnak in vstup)
            {
                string morseuvZnak = "?";
                int index = Array.IndexOf(abecedniZnaky.ToCharArray(), abecedniZnak);
                if (index >= 0)  //znak nalezen
                    morseuvZnak = morseovyZnaky[index];
                zakodovanytext += morseuvZnak;
            }
            Console.WriteLine("Dekódovaná zpráva: " + zakodovanytext);
            Console.ReadKey();
        }
    }
}
