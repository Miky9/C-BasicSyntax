using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (15 > 5)
            //    Console.WriteLine("Pravda");
            //Console.WriteLine("Program zde pokračuje dál");
            //Console.ReadKey();



            //Console.WriteLine("Zadej nějaké číslo");
            //int a = int.Parse(Console.ReadLine());
            //if (a > 5)
            //    Console.WriteLine("Zadal jsi číslo větší než 5!");
            //Console.WriteLine("Děkuji za zadání");
            //Console.ReadKey();



            //Console.WriteLine("Zadej nějaké číslo, ze kterého spočítám odmocninu:");
            //int a = int.Parse(Console.ReadLine());
            //if (a > 0)
            //{
            //    Console.WriteLine("Zadal jsi číslo větší než 0, to znamená, že ho mohu odmocnit!");
            //    double o = Math.Sqrt(a);
            //    Console.WriteLine("Odmocnina z čísla " + a + " je " + o);
            //}
            //if (a <= 0) //else
            //    Console.WriteLine("Odmocnina ze záporného čísla neexistuje!");
            //Console.WriteLine("Děkuji za zadání");
            //Console.ReadKey();



            //bad code:
            //int a = 0; // do a si přiřadíme na začátku 0
            //if (a == 0) // pokud je a 0, dáme do něj jedničku
            //    a = 1;
            //if (a == 1) // pokud je a 1, dáme do něj nulu
            //    a = 0;
            //Console.WriteLine(a);
            //Console.ReadKey();

            //good code:
            //int a = 0; // do a si přiřadíme na začátku 0
            //if (a == 0) // pokud je a 0, dáme do něj jedničku
            //    a = 1;
            //else // pokud je a 1, dáme do něj nulu
            //    a = 0;
            //Console.WriteLine(a);
            //Console.ReadKey();



            //A zároveň   &&
            //Nebo        ||



            //Console.WriteLine("Zadejte číslo v rozmezí 10-20:");
            //int a = int.Parse(Console.ReadLine());
            //if ((a >= 10) && (a <= 20))
            //    Console.WriteLine("Zadal jsi správně");
            //else
            //    Console.WriteLine("Zadal jsi špatně");
            //Console.ReadKey();



            //Console.WriteLine("Zadejte číslo v rozmezí 10-20 nebo 30-40:");
            //int a = int.Parse(Console.ReadLine());
            //if (((a >= 10) && (a <= 20)) || ((a >= 30) && (a <= 40)))
            //    Console.WriteLine("Zadal jsi správně");
            //else
            //    Console.WriteLine("Zadal jsi špatně");
            //Console.ReadKey();



            //Without Switch:
            //Console.WriteLine("Vítejte v kalkulačce");
            //Console.WriteLine("Zadejte první číslo:");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Zadejte druhé číslo:");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Zvolte si operaci:");
            //Console.WriteLine("1 - sčítání");
            //Console.WriteLine("2 - odčítání");
            //Console.WriteLine("3 - násobení");
            //Console.WriteLine("4 - dělení");
            //int volba = int.Parse(Console.ReadLine());
            //float vysledek = 0;
            //if (volba == 1)
            //    vysledek = a + b;
            //else                            //if it happens, other if statements won't be processedd
            //if (volba == 2)
            //    vysledek = a - b;
            //else
            //if (volba == 3)
            //    vysledek = a * b;
            //else
            //if (volba == 4)
            //    vysledek = a / b;
            //if ((volba > 0) && (volba < 5))
            //    Console.WriteLine("Výsledek: {0}", vysledek);
            //else
            //    Console.WriteLine("Neplatná volba");
            //Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
            //Console.ReadKey();

            //Switch:
            //Console.WriteLine("Vítejte v kalkulačce");
            //Console.WriteLine("Zadejte první číslo:");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Zadejte druhé číslo:");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Zvolte si operaci:");
            //Console.WriteLine("1 - sčítání");
            //Console.WriteLine("2 - odčítání");
            //Console.WriteLine("3 - násobení");
            //Console.WriteLine("4 - dělení");
            //int volba = int.Parse(Console.ReadLine());
            //float vysledek = 0;
            //switch (volba)
            //{
            //    case 1:
            //        vysledek = a + b;
            //        break;
            //    case 2:
            //        vysledek = a - b;
            //        break;
            //    case 3:
            //        vysledek = a * b;
            //        break;
            //    case 4:
            //        vysledek = a / b;
            //        break;
            //}
            //if ((volba > 0) && (volba < 5))
            //    Console.WriteLine("Výsledek: {0}", vysledek);
            //else
            //    Console.WriteLine("Neplatná volba");
            //Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
            //Console.ReadKey();











        }
    }
}
