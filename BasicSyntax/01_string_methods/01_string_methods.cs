using System;

namespace _1_string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ////StartsWith() EndsWith() a Contains()
            //string s = "Krokonosohroch";
            //Console.WriteLine(s.StartsWith("krok"));
            //Console.WriteLine(s.EndsWith("hroch"));
            //Console.WriteLine(s.Contains("nos"));
            //Console.WriteLine(s.Contains("roh"));
            //Console.ReadKey();


            ////ToUpper() a ToLower()

            //string konfig = "Fullscreen shaDows autosave";
            //konfig = konfig.ToLower();
            //Console.WriteLine("Poběží hra ve fullscreenu?");
            //Console.WriteLine(konfig.Contains("fullscreen"));
            //Console.WriteLine("Budou zapnuté stíny?");
            //Console.WriteLine(konfig.Contains("shadows"));
            //Console.WriteLine("Přeje si hráč vypnout zvuk?");
            //Console.WriteLine(konfig.Contains("nosound"));
            //Console.WriteLine("Přeje si hráč hru automaticky ukládat?");
            //Console.WriteLine(konfig.Contains("autosave"));
            //Console.ReadKey();



            ////Trim(), TrimStart() a StrimEnd()

            //Console.WriteLine("Zadejte text:");
            //string s = Console.ReadLine();
            //Console.WriteLine("Zadal jste text: " + s);
            //Console.WriteLine("Text po funkci trim: " + s.Trim());
            //int a = int.Parse(s);
            //Console.WriteLine("Převedl jsem zadaný text na číslo parsováním, zadal jste: " + a);
            //Console.ReadKey();


            ////Replace()

            //string s = "Java je nejlepší!";
            //s = s.Replace("Java", "C#");
            //Console.WriteLine(s);
            //Console.ReadKey();



            ////Format()
            //int a = 10;
            //int b = 20;
            //int c = a + b;
            //string s = string.Format("Když sečteme {0} a {1}, dostaneme {2}", a, b, c);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //int a = 10;
            //int b = 20;
            //int c = a + b;
            //Console.WriteLine("Když sečteme {0} a {1}, dostaneme {2}", a, b, c);
            //Console.ReadKey();



            ////PadLeft() a PadRight() //add space



            ////Vlastnost Length
            //Console.WriteLine("Zadejte vaše jméno:");
            //string jmeno = Console.ReadLine();
            //Console.WriteLine("Délka vašeho jména je: {0}", jmeno.Length);
            //Console.ReadKey();



            //string s = "Ahoj ITnetwork";
            //Console.WriteLine(s);
            //Console.WriteLine(s[2]);
            //Console.ReadKey();



            //First(), Last(), IndexOf()
            //Insert()
            //Console.WriteLine("Já bych všechny ty internety zakázala".Insert(29, "ne"));
            //Console.ReadKey();



            //Remove() 1.od x pozice 2. počet znaků
            //Console.WriteLine("Kdo se směje naposled, ten je admin.".Remove(12, 9)); 
            //Console.ReadKey();

            //Substring() //vrátí podřetězec 1.od x pozice 2. počet znaků
            //Console.WriteLine("Kdo se směje naposled, ten je admin.".Substring(13, 8));
            //Console.ReadKey();



            //CompareTo()
            //Umožňuje porovnat dva řetězce podle abecedy. Vrací - 1 pokud je první řetězec před řetězcem v parametru, 
            //0 pokud jsou stejné a 1 pokud je za ním:
            //Console.WriteLine("akát".CompareTo("blýskavice"));
            //Console.WriteLine("akát".CompareTo("akát"));
            //Console.WriteLine("bz".CompareTo("bs"));
            //Console.ReadKey();



            //Split(), Join()
            //..morse code



            Console.WriteLine("Toto je zpětné lomítko: \\");
            Console.WriteLine("Toto je uvozovka: \"");
            Console.WriteLine(@"C:\Users\sdraco\Dropbox\itnetwork");

            Console.ReadKey();



        }
    }
}
