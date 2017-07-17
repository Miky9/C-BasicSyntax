using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Copying an array involves index-by-index copying.For this to work we shall know the length of array in advance, 
which we shall use in iteration.Another array of same length shall be required, to which the array will be copied.

Algorithm → Pseudocode → Implementation

step-by-step procedure of this 
START
   Step 1 → Take two arrays A, B

   Step 2 → Store values in A

   Step 3 → Loop for each value of A

   Step 4 → Copy each index value to B array at the same index location
STOP

pseudocode of this algorithm −
procedure copy_array(A, B)

   SET index to 1

   FOR EACH value in A DO
      
      B[index] = A[index]
   
      INCREMENT index
   
   END FOR
   
end procedure
*/

namespace A2_copy_array
{
    class A2_copy_array
    {
        static string PrintValues(int[] array)
        {
            string c = "";
            foreach (int i in array)
                c = c + i + " ";
            return c;
        }

        static void Main(string[] args)
        {
            int [] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int [] copied= new int[10];

            for (int i = 0; i < 10; i++)
            {
                copied[i] = original[i];
            }

            //Array.Copy(original, copied, 5);   //original.Length

            Console.WriteLine("original");
            Console.WriteLine(A2_copy_array.PrintValues(original));
            Console.WriteLine("-> copied");
            Console.WriteLine(A2_copy_array.PrintValues(copied));
            Console.ReadKey();






        }
    }
}
