using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_enum
{
    enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    //By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
    enum Days2 { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
    //In this enumeration, the sequence of elements is forced to start from 1 instead of 0.
    enum Days3 : byte { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
    enum Range : long { Max = 2147483648L, Min = 255L };
    //The approved types for an enum are byte, sbyte, short, ushort, int (=default), uint, long, or ulong.

    //enum E is the value produced by the expression (E)0

    //An enumerator cannot contain white space in its name!
    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)Days.Sun;
            Console.WriteLine(x);

            Days day = (Days)3;
            Console.WriteLine(day);

            //string day = (Days)3;



            Array dayArray = Enum.GetValues(typeof(Days));
            // použijeme statickou metodu třídy výčtu GetValues. Třída výčtu vrátí hodnoty (indexy) položek výčtu ve formě nějakého pole. 
            //Třída výčtu má též metodu GetNames, která vrací textovou prezentaci položek výčtu 
            //(pozn. : Třída výčtu je jedna z mnoha tříd, které již C# implementuje v základním objektu System.Object, 
            //což je základní třída (base class).)
            foreach (Days day2 in dayArray) 
                Console.WriteLine("Number {1} of Days is {0}", day2, day2.ToString("d")); // 11.
                //Console.WriteLine(String.Format("Number {1} of Days is {0}", day, day.ToString("d")));


            Console.ReadKey();
        }
        
    }

}

