using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte koeficienty kvadratické rovnice. ax^2 + bx + c = 0");

            float a, b, c;
            string t = "Neplatné číslo, zadejte prosím znovu:";

            Console.Write("Zadejte a: ");
            while (!float.TryParse(Console.ReadLine(), out a))
                Console.WriteLine(t);

            Console.Write("Zadejte b: ");
            while (!float.TryParse(Console.ReadLine(), out b))
                Console.WriteLine(t);

            Console.Write("Zadejte c: ");
            while (!float.TryParse(Console.ReadLine(), out c))
                Console.WriteLine(t);
            /* int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int c = int.Parse(Console.ReadLine());*/

            if (a == 0 && b == 0 && c == 0)
                Console.WriteLine("Rovnice = R");
            else
            {
                if (a == 0)
                {
                    if (b == 0)
                        Console.WriteLine("Toto není kvadratická rovnice!");
                    else
                    {
                        double x1 = -c / b;
                        Console.WriteLine("Rovnice je lineární. x1 = {0}", x1);
                    }
                }
                else
                {
                    double d = Math.Pow(b, 2) - (4 * a * c);
                    if (d > 0)
                    {
                        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine("Rovnice má 2 kořeny x1 = {0}, x2 = {1}", x1, x2);
                    }
                    else
                    {
                        if (d < 0)
                            Console.WriteLine("Rovnice nemá řešení!");
                        else
                        {
                            double x1 = -b / (2 * a);
                            Console.WriteLine("x1 = {0}", x1);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}














