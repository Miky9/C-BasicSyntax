using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////2D
            //int[,] kinosal = new int[5, 5];

            //kinosal[2, 2] = 1; // Prostředek
            //for (int i = 1; i < 4; i++) // 4. řádek
            //{
            //    kinosal[i, 3] = 1;
            //}
            //for (int i = 0; i < 5; i++) // Poslední řádek
            //{
            //    kinosal[i, 4] = 1;
            //}

            //for (int j = 0; j < kinosal.GetLength(1); j++)
            //{
            //    for (int i = 0; i < kinosal.GetLength(0); i++)
            //    {
            //        Console.Write(kinosal[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //3D
            int[,,] kinosaly = new int[5, 5, 3];
            Console.Write("Počet kinosálů: ");
            Console.WriteLine(kinosaly.GetLength(2));
            Console.Write("Počet řad v kinosálu: ");
            Console.WriteLine(kinosaly.GetLength(0));
            Console.Write("Počet sedadel v řadě kinosálu: ");
            Console.WriteLine(kinosaly.GetLength(1));

            kinosaly[3, 2, 1] = 1; // Druhý kinosál, třetí řada, čtvrtý sloupec


            Console.ReadKey();
        }
    }
}
