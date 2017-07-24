using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_math_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pí: {0} \ne: {1}\n", Math.PI, Math.E);



            //Min(), Max() prameters: two numbers
            //Console.WriteLine(Math.Min(10, 20));



            double a = -10.5;
            Console.WriteLine("Zadané číslo je: {0}\n", a);

            //Round() k nejbližšímu sudému číslu (vrací sice celé číslo, ale stále uložené v typu double)
            Console.Write("Round()-k nejbližšímu sudému číslu: ");
            Console.WriteLine(Math.Round(a));

            //klasické zaokrouhlování
            Console.Write("Round() ,MidpointRoundin­g.AwayFromZero-klasické zaokrouhlování: ");
            Console.WriteLine(Math.Round(a, MidpointRoundin­g.AwayFromZero));

            //Ceiling() vždy nahoru
            Console.Write("Ceiling() vždy nahoru: ");
            Console.WriteLine(Math.Ceiling(a));

            //Floor() vždy dolů; zaokrouhlí na číslo více do mínusu 
            Console.Write("Floor() vždy dolů: ");
            Console.WriteLine(Math.Floor(a));

            //Truncate() odtrhne desetinnou část; zaokrouhlí záporné číslo k nule
            Console.Write("Truncate() odtrhne desetinnou část; zaokrouhlí záporné číslo k nule: ");
            Console.WriteLine(Math.Truncate(a));

            double d = 2.72;
            int b = (int)Math.Round(d);
            Console.Write("Round() z {0} převedený na int: ", d);
            Console.WriteLine(b);



            //Abs() vrátí absolutní hodnotu
            Console.Write("Abs() vrátí absolutní hodnotu: ");
            Console.WriteLine(Math.Abs(a));

            //Sign() vrátí podle znaménka -1, 0 nebo 1 (pro záporné číslo, nulu a kladné číslo)
            Console.Write("Sign() vrátí podle znaménka -1, 0 nebo 1: ");
            Console.WriteLine(Math.Sign(a));



            //Sin(), Cos(), Tan()
            //Klasické goniometrické funkce, jako parametr berou úhel typu double, který považují v radiánech, nikoli ve stupních.
            //Pro konverzi stupňů na radiány stupně vynásobíme * (Math.PI / 180).Výstupem je opět double.

            //Acos(), Asin(), Atan()
            //Klasické cyklometrické funkce(arkus funkce), které podle hodnoty goniometrické funkce vrátí daný úhel. 
            //Parametrem je hodnota v double, výstupem úhel v radiánech(také double).
            //Pokud si přejeme mít úhel ve stupních, vydělíme radiány / (180 / Math.PI).



            //Pow() mocnění - dva parametry typu double, první je základ mocniny a druhý exponent
            Console.Write("Pow() mocnění 2^3: ");
            Console.WriteLine(Math.Pow(2, 3));

            //Sqrt() vrátí druhou odmocninu z daného čísla typu double (zkratka ze square root) 
            Console.Write("Sqrt() vrátí druhou odmocninu z daného čísla - {0}: ", 25);
            Console.WriteLine(Math.Sqrt(25));

            //libovolná odmocnina
            Console.Write("Třetí odmocnina z osmi = 8^(1/3): ");
            Console.WriteLine(Math.Pow(8, (1.0 / 3.0)));



            //Dělení
            //Programovací jazyky se často odlišují tím, jak v nich funguje dělení čísel. 
            //Tuto problematiku je nutné dobře znát, abyste nebyli poté(nepříjemně) překvapeni

            Console.Write("int a1 = 5 / 2: ");
            int a1 = 5 / 2;
            Console.WriteLine(a1);

            Console.Write("double b = 5 / 2: ");
            double a2 = 5 / 2;
            Console.WriteLine(a2);

            Console.Write("double a3 = 5.0 / 2: ");
            double a3 = 5.0 / 2;
            Console.WriteLine(a3);

            Console.Write("double a4 = 5 / 2.0: ");
            double a4 = 5 / 2.0;
            Console.WriteLine(a4);

            double a5 = 5.0 / 2.0;
            Console.WriteLine("double a5 = 5.0 / 2.0: {0}", a5);

            //nelze: int f = 5 / 2.0;

            int soucet = 10;
            int pocet = 4;
            double prumer = (double)soucet / pocet;
            Console.WriteLine("double prumer = (double)10/4: {0}", prumer);



            //Zbytek po celočíselném dělení - modulo
            Console.WriteLine("modulo z 5%2: {0}", (5 % 2)); 



            Console.ReadKey();
        }
    }
}
