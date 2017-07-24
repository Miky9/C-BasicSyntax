using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_reference_types
{
    class Uzivatel
    {
        public int vek;
        public string jmeno;

        public Uzivatel(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }

        public override string ToString()
        {
            return jmeno;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // založení proměnných
            int a = 56;
            int b = 28;
            Uzivatel u = new Uzivatel("Jan Novák", 28);
            Uzivatel v = new Uzivatel("Josef Nový", 32);
            Console.WriteLine("a: {0}\nb: {1}\nu: {2}\nv: {3}\n", a, b, u, v);
            // přiřazování
            a = b;
            u = v;
            Console.WriteLine("a: {0}\nb: {1}\nu: {2}\nv: {3}\n", a, b, u, v);

            // změna
            v.jmeno = "John Doe";
            Console.WriteLine("u: {0}\nv: {1}\n", u, v);

            // změna
            v.jmeno = "John Doe";
            v = null;
            Console.WriteLine("u: {0}\nv: {1}\n", u, v);

            //null: reference neukazuje na žádná data, když nastavíme proměnnou v na null, zrušíme pouze tu jednu referenci

            Console.ReadKey();
        }
    }
}
