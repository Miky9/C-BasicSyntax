using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_overflowing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.ReadKey();

            //byte number = 255; ///throws error
            //number += 1;

            //Console.ReadKey();

            //checked ///throws exception
            //{
            //    byte number = 255;   ///byte = 0-255
            //    number += 1;
            //}



        }
    }
}
