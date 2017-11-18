using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_arrays
{
    class _8_arrays
    {
        static string PrintValues(int[] array)
        {
            string c = "";
            foreach (int i in array)
                c = c + i + " ";
            return c;
        }

        static string PrintValues2(System.Array a)
        {
            string c = "";
            foreach (System.Int32 i in a)
                c = c + i + " ";
            return c;
        }

        static string PrintValues3(System.Array a)
        {
            string c = "";
            foreach (System.Object i in a)
                c = c + i + " ";
            return c;
        }

        static string PrintValues4(float[] array)
        {
            string c = "";
            foreach (float i in array)
                c = c + i + " ";
            return c;
        }

        static void Main(string[] args)
        {
            //kolekce je obecný název pro struktury, které obsahují více prvků



            //int[] pole = new int[10];
            //pole[0] = 1;
            //for (int i = 0; i < 10; i++)
            //    pole[i] = i + 1;

            //for (int i = 0; i < pole.Length; i++)
            //    Console.Write("{0} ", pole[i]);
            //Console.ReadKey();



            //int[] pole = new int[10];
            //pole[0] = 1;
            //for (int i = 0; i < 10; i++)
            //    pole[i] = i + 1;

            //foreach (int i in pole)
            //    Console.Write("{0} ", i);
            //Console.ReadKey();

            //Console.Write(_8_arrays.PrintValues(pole));
            //Console.ReadKey();


            //Reverse()
            //string[] simpsonovi = { "Homer", "Marge", "Bart", "Lisa", "Meggie" };
            //Array.Sort(simpsonovi);
            //Array.Reverse(simpsonovi);
            //foreach (string s in simpsonovi)
            //    Console.Write("{0} ", s);
            //Console.ReadKey();



            //IndexOf() a LastIndexOf()
            //string[] simpsonovi = { "Homer", "Marge", "Bart", "Lisa", "Meggie" };
            //Console.WriteLine("Ahoj, zadej svého oblíbeného Simpsna (z rodiny Simpsů): ");
            //string simpson = Console.ReadLine();
            //int pozice = Array.IndexOf(simpsonovi, simpson);
            //if (pozice >= 0)
            //    Console.WriteLine("Jo, to je můj {0}. nejoblíbenější Simpson!", pozice + 1);
            //else
            //    Console.WriteLine("Hele, tohle není Simpson!");
            //Console.ReadKey();



            //Copy()
            // Creates and initializes a new Array of type Int32.
            //Array myIntArray = Array.CreateInstance(typeof(System.Int32), 5);
            //for (int i = myIntArray.GetLowerBound(0); i <= myIntArray.GetUpperBound(0); i++)
            //    myIntArray.SetValue(i + 1, i);

            //// Creates and initializes a new Array of type Object.
            //Array myObjArray = Array.CreateInstance(typeof(System.Object), 5);
            //for (int i = myObjArray.GetLowerBound(0); i <= myObjArray.GetUpperBound(0); i++)
            //    myObjArray.SetValue(i + 26, i);

            //// Displays the initial values of both arrays.
            //Console.WriteLine("Int32 array:");
            //Console.WriteLine(_8_arrays.PrintValues2(myIntArray));
            //Console.WriteLine("Object array:");
            //Console.WriteLine(_8_arrays.PrintValues3(myObjArray));

            //// Copies the first element from the Int32 array to the Object array.
            //Array.Copy(myIntArray, myIntArray.GetLowerBound(0), myObjArray, myObjArray.GetLowerBound(0), 1);

            //// Copies the last two elements from the Object array to the Int32 array.
            //Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

            //// Displays the values of the modified arrays.
            //Console.WriteLine("Int32 array - Last two elements should now be the same as Object array:");
            //Console.WriteLine(_8_arrays.PrintValues2(myIntArray));
            //Console.WriteLine("Object array - First element should now be the same as Int32 array:");
            //Console.WriteLine(_8_arrays.PrintValues3(myObjArray));
            //Console.ReadKey();
            //This code produces the following output.
            //Int32 array:
            //    1    2    3    4    5
            //Object array:
            //    26    27    28    29    30
            //Int32 array - Last two elements should now be the same as Object array:
            //    1    2    3    29    30
            //Object array - First element should now be the same as Int32 array:
            //    1    27    28    29    30


            //Array.Copy(original, copied, 5);   //original.Length



            //Particular array methods
            //Length
            //Min(), Max(), Average(), Sum(), First(), Last()
            //Concat(), Intersect(), Union()
            //Všechny tyto metody vrátí na výstupu nové pole a jako parametr mají druhé pole. 
            //Concat() vykoná nám již známou konkatenaci, tedy k našemu poli připojí druhé pole a takto vzniklé nové pole vrátí.
            //Intersect() vykoná průnik obou polí, tedy sestaví pole s prvky, které jsou oběma polím společné. 
            //Union() naopak vykoná sjednocení, funguje tedy podobně jako Concat(), 
            //jen prvky, které byly v obou polích, jsou v novém poli jen jednou.
            //Take(), Skip()
            //Obě tyto metody berou jako parametr počet prvků. Take vrátí pole s daným počtem prvků zkopírovaných od začátku původního pole. 
            //Skip naopak vrátí pole bez těchto prvních prvků.
            //Contains()
            //Metoda vrací true / false podle toho, zda se prvek, uvedený v parametru metody, v daném poli nachází.
            //Reverse()
            //Metodu Reverse známe již z třídy Array, pokud ji ale voláme na konkrétním poli, tak se prvky v něm neotočí, 
            //nýbrž je vytvořeno nové otočené pole a to je vráceno.Metoda nemá žádné parametry.
            //Distinct()
            //Distinct je metoda bez parametrů a zajistí, aby byl v poli každý prvek jen jednou, 
            //tedy vymaže duplicitní prvky a unikátní pole vrátí jako návratovou hodnotu metody, opět tedy nemodifikuje dané pole.

            //Mnoho metod nemění přímo naše pole, ale vrátí pouze pole nové(jsou to metody Concat, Intersect, Union, Reverse a Distinct), 
            //ve kterém jsou provedeny požadované změny. Pokud chceme modifikovat původní pole, musíme do něj dosadit. 
            //Tyto metody bohužel z důvodů, které pochopíme až později, nevrací přímo pole, ale typ IEnumerable.
            //Aby bylo dosazení výsledku zpět do pole možné, musíme ho ještě převést na pole metodou ToArray().

            //int[] cisla = { 1, 2, 3, 3, 3, 5 };
            //cisla = cisla.Distinct().ToArray();
            //Console.WriteLine(_8_arrays.PrintValues(cisla));
            //Console.ReadKey();












            }
        }
    }
