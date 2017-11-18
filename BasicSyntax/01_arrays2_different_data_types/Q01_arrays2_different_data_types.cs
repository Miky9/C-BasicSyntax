using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // for ArrayList

//všechny datové typy přímo či nepřímo dědí z objektového typu

namespace _101_arrays2_different_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = "string"; //error-int pole

            ///pole objektů
            
            object[] array = new object[3]; //velikost pole, 3 -> pozice 0,1,2
            array[0] = 1;
            array[1] = "string"; 

            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Chester";
            array[2] = c;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();



            ///kolekce - ArrayList

            ArrayList array2 = new ArrayList();
            array2.Add(1);
            array2.Add("string");
            array2.Add(c);

            foreach (object obj in array2)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }

        class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }
        }





    }
}
