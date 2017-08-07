using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The class whose members are inherited is called the base class, and the class that inherits those members is called the derived class. 
            A derived class can have only one direct base class. 
            Conceptually, a derived class is a specialization of the base class. For example,
            if you have a base class Animal, you might have one derived class that is named Mammal and another derived class that is named Reptile.

            Konstruktory se nedědí.
            V konstruktorech potomků je nutné vždy volat konstruktor předka.
            Konstruktor předka nevoláme pouze v případě, že žádný nemá.

            V C# .NET existuje klíčové slovo base, které je podobné námi již známému this. 
            Na rozdíl od this, které odkazuje na konkrétní instanci třídy, base odkazuje na předka.
            Pozn.: Stejně můžeme volat i jiný konstruktor v té samé třídě(ne předka), jen místo base použijeme this.

            override: Podobně jsme přepisovali metodu ToString() u našich objektů, každý objekt v C# je totiž odděděný od System.Object,     //prapředek?
            který obsahuje 4 metody, jedna z nich je i ToString(). Při její implementaci tedy musíme použít override.
            */



            Uzivatel uzivatel_1 = new Uzivatel("Jan Novák", 33);
            Administrator admin_1 = new Administrator("Jan KK", 33);

            //admin_1.Prihlasit(123);


            if (uzivatel_1.Validace("123") == true) uzivatel_1.Prihlasit();
            Console.WriteLine("Uzivatel {0} se prihlasil uspesne: {1}", "uzivatel_1",  uzivatel_1.prihlaseni);
            if (admin_1.Validace("124") == true) admin_1.Prihlasit();
            Console.WriteLine("Uzivatel {0} se prihlasil uspesne: {1}", "admin_1",  admin_1.prihlaseni);

            Console.ReadKey();



            //Datový typ při dědičnosti
            Uzivatel u = new Uzivatel("Jan Novák", 33);
            Administrator a = new Administrator("Josef Nový", 25);
            // Nyní do uživatele uložíme administrátora:
            u = a;
            Console.WriteLine(u.jmeno);
            // Vše je v pořádku, protože uživatel je předek
            // Zkusíme to opačně a dostaneme chybu:
            //a = u;



            Console.ReadKey();
        }
    }

    class Uzivatel
    {
        public string jmeno;
        protected string heslo;
        public int vek;
        public bool prihlaseni;

        public Uzivatel(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
            prihlaseni = (false);
        }

        public bool Validace(string heslo)
        {
            this.heslo = heslo;
            if (this.heslo == "123")
            {
                return (true);
            }
            else
                return (false);
        }

        public void Prihlasit()
        {
            prihlaseni = (true);
        }

        public void Odhlasit()
        {
            prihlaseni = (false);
        }

        public void NastavVahu(string zvire, int vaha)
        {
            // ...
        }
    }

    class Administrator : Uzivatel
    {
        //private string telefonniCislo;


        //The problem is that the base class foo has no parameterless constructor.So you must call constructor of the base class with parameters from constructor of the derived class:


        public Administrator(string jmeno, int vek) : base (jmeno, vek) 
        {
            this.jmeno = jmeno;
            this.vek = vek;
            prihlaseni = (false);
        }

        public void PridejZvire(string zvire)
        {

        }

        public void VymazZvire(string zvire)
        {

        }
    }


    
  

    

}
