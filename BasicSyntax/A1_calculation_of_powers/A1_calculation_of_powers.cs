using System;

namespace A1_calculation_of_powers
{
    class A1_calculation_of_powers
    {

        static int mocnenikladnym(int a, int b)
        {
            int c = a;
            for (int i = 1; i < b; i++)
            {
                c = c * a;
            }
            return c;
        }

        static int mocneni(int a, int b) //Vrati 'a' umocnene na 'b'.
        {
            if (b > 0)
            {
                return mocnenikladnym(a, b);
            }
            else
            if (b < 0)
            {
                return (1 / mocnenikladnym(a, Math.Abs(b)));
            }
            else
            return 1;
        }

        static void Main(string[] args)
        {
            ////Math.Pow(100.00, 3.00); // 100.00 ^ 3.00

            Console.WriteLine("Calculation of powers");
            Console.Write("Enter Base: ");
            int Base = int.Parse(Console.ReadLine());
            Console.Write("Enter Exponent: ");
            int Exp = int.Parse(Console.ReadLine());
            Console.Write("Result: ");
            Console.Write(A1_calculation_of_powers.mocneni(Base, Exp));
            Console.ReadKey();













        }
    }
}
