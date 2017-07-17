using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_average_and_improving
{
    class P1_average_and_improving
    {
        static string PrintValues(int[] array)
        {
            string c = "";
            foreach (int i in array)
                c = c + i + " ";
            return c;
        }

        static string PrintValues2(System.Array a)
        {
            string c = "";
            foreach (System.Int32 i in a)
                c = c + i + " ";
            return c;
        }

        static string PrintValues3(System.Array a)
        {
            string c = "";
            foreach (System.Object i in a)
                c = c + i + " ";
            return c;
        }

        static string PrintValues4(float[] array)
        {
            string c = "";
            foreach (float i in array)
                c = c + i + " ";
            return c;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, spočítám ti průměr známek. Kolik známek zadáš?");
            int pocet = int.Parse(Console.ReadLine());
            float[] cisla = new float[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.Write("Zadejte {0}. číslo: ", i + 1);
                cisla[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Průměr tvých známek je: {0}", cisla.Average());
            double prumer = Math.Round(cisla.Average(), MidpointRounding.AwayFromZero);
            Console.WriteLine("Nejspíš dostaneš {0}ku", prumer);
            Console.WriteLine("Chceš poradit jak získat o stupeň lepší známku? A/N");
            string pokracovat = "N";
            pokracovat = Console.ReadLine();
            while (pokracovat == "A")
            {
                Console.WriteLine("Tvoje známky jsou: {0}\n...a tvůj průměr je: {1}", P1_average_and_improving.PrintValues4(cisla), cisla.Average());
                pokracovat = "N";
                int casex = Convert.ToInt32(Math.Round(cisla.Average(), MidpointRounding.AwayFromZero));
                string zprava = "";
                double rozdil = 0;
                switch (casex)
                {
                    case 1:
                        zprava = "Není třeba nic zlepšovat, jseš jednička!";
                        break;
                    case 2:
                        zprava = "1";
                        rozdil = prumer - 1.499;
                        break;
                    case 3:
                        zprava = "2";
                        rozdil = prumer - 2.499;
                        break;
                    case 4:
                        zprava = "3";
                        rozdil = prumer - 3.499;
                        break;
                    case 5:
                        zprava = "4";
                        rozdil = prumer - 4.499;
                        break;
                }
                double rozdil2 = Math.Round((Math.Round(rozdil, 1, MidpointRounding.AwayFromZero) * 5), MidpointRounding.AwayFromZero);
                if ((casex > 1) && (casex < 6))
                    Console.WriteLine("V tvých možnostech je {0}ka!\n...rozdíl je {1}", zprava, rozdil);
                else
                    Console.WriteLine("Není třeba nic zlepšovat, jseš jednička!");
                int add = 3;
                if (pocet < 5)
                {
                    switch (rozdil2)
                    {
                        case 1:
                            zprava = "";
                            break;
                        case 2:
                            zprava = "2x 1";
                            add = 2;
                            break;
                        case 3:
                            zprava = "2x 1";
                            add = 2;
                            break;
                        case 4:
                            zprava = "2x 1";
                            add = 2;
                            break;
                        case 5:
                            zprava = "2x 1";
                            add = 2;
                            break;
                    }
                }
                else
                {
                    switch (rozdil2)
                    {
                        case 1:
                            zprava = "";
                            break;
                        case 2:
                            zprava = "3x 1";
                            break;
                        case 3:
                            zprava = "3x 1";
                            break;
                        case 4:
                            zprava = "3x 1";
                            break;
                        case 5:
                            zprava = "3x 1";
                            break;
                    }
                }
                Array.Resize(ref cisla, cisla.Length + add);

                float[] newcisla = new float[(pocet + add)];
                Array.Copy(cisla, newcisla, newcisla.Length);

                if ((rozdil2 > 1) && (rozdil2 < 6))
                    Console.WriteLine("Měl bys dostat {0}!", zprava);
                foreach (int i in newcisla)
                    if (newcisla[i] == 0)
                        newcisla[i] = 1;
                Console.WriteLine("Pokud to zvládneš, tak budeš mít tyto známky {0}\n...a tvůj průměr bude: {1}", P1_average_and_improving.PrintValues4(newcisla), newcisla.Average(), MidpointRounding.AwayFromZero);
                double prumer2 = Math.Round(newcisla.Average(), MidpointRounding.AwayFromZero);
                int casex2 = Convert.ToInt32(Math.Round(newcisla.Average(), MidpointRounding.AwayFromZero));

                if (rozdil2 == casex2)
                    Console.WriteLine("Dokázal jsi to.");
                else
                    Console.WriteLine("Nedokázal jsi to.");

                pokracovat = "N";
                Console.ReadKey();
            }
        }
    }
}
