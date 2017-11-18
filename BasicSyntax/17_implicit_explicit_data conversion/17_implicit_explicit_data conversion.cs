using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_implicit_explicit_data_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Implicit Type Conversion
            //byte b = 1; //1 byte of memory (byte = 8 bits = 8 x 0/1 = binary representation)
            //int i = b; //4 bytes of memory

            ///chance for data loss ->won't compile
            //int i = 1;
            //byte b = i;

            ///Explicit Data conversion (casting)
            //int i = 1;
            //byte b = (byte)i

            //float f = 1.0f;
            //int i = (int)f; //we are aware of data loss

            ///Non-compatible types
            //string s = "1";
            //int i = (int)s; //won't compile

            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);




            Console.ReadKey();
        }
    }
}
