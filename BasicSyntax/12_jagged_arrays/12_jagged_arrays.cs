using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //pole polí ("zubaté")
            int[][] kinosal = new int[5][];

            //inicializace - sloupečky musíme navkládat sami
            for (int i = 0; i < kinosal.Length; i++)
            {
                kinosal[i] = new int[5];
            }

            //zjištění velikosti pole
            int sloupcu = kinosal.Length;
            int radku = 0;
            if (sloupcu != 0)
                radku = kinosal[0].Length;

            Console.WriteLine("Rozměr 2D pole je {0} x {1}", sloupcu, radku);


            kinosal[4][2] = 1; // Obsazujeme sedadlo v 5. sloupci a 3. řadě


            Console.ReadKey();

            int[,] kinosal2 = new int[,] {
                { 0, 0, 0, 0, 1 },
                { 0, 0, 0, 1, 1 },
                { 0, 0, 1, 1, 1 },
                { 0, 0, 0, 1, 1 },
                { 0, 0, 0, 0, 1 }
            };

            int[][] zubatePole = new int[][] {
                new int[] {15, 2, 8, 5, 3},
                new int[] {3, 3, 7},
                new int[] {9, 1, 16, 13},
                new int[] {},
                new int[] {5}
            };

            Console.ReadKey();
        }
    }
}
