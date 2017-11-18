using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_properties_get_set
{
    class Program
    {

        class Student
        {
            public string jmeno;
            public bool muz;
            public int vek;
            public bool plnolety;

            public Student(string jmeno, bool pohlavi, int vek)
            {
                this.jmeno = jmeno;
                this.muz = pohlavi;
                this.vek = vek;
                plnolety = true;
                if (vek < 18)
                    plnolety = false;
            }

            public override string ToString()
            {
                string jsemPlnolety = "jsem";
                if (!plnolety)
                    jsemPlnolety = "nejsem";
                string pohlavi = "muž";
                if (!muz)
                    pohlavi = "žena";
                return String.Format("Jsem {0}, {1}. Je mi {2} let a {3} plnoletý.", jmeno, pohlavi, vek, jsemPlnolety);
            }


            static void Main(string[] args)
            {
                Student s = new Student("Pavel Hora", true, 20);
                Console.WriteLine(s);

                Console.ReadKey();
            }

        }
    }
}
