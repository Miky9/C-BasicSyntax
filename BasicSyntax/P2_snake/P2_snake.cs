using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace P2_snake
{
    class P2_snake
    {
        #region Metody
        static bool pokracovat = true;
        static List<int> SouradniceX = new List<int>();
        static List<int> SouradniceY = new List<int>();
        static int CisloCyklu = 0;
        static int score = 0;
        static int X = Console.WindowWidth;
        static int Y = Console.WindowHeight;
        static int a;
        static int b;
        static int PocetClanku = 1;
        static Random random = new Random();
        static ConsoleKey klavesa;
        static ConsoleKey pomocna;

        static void Main(string[] args)
        {

            Console.ReadKey();
            Zacatek();
            while (pokracovat)
            {
                while (klavesa == ConsoleKey.UpArrow)
                {
                    Y--;
                    Pohyb();
                    PotravaSezrana();
                    RychlostY();
                    if (!Console.KeyAvailable) // nestisknutá klávesa = opakování cyklu
                    {
                        continue;
                    }
                    pomocna = Console.ReadKey().Key; //stisknutá klávesa se uloží do pomocné 
                    if (pomocna == ConsoleKey.RightArrow || pomocna == ConsoleKey.LeftArrow) //pokud pomocná bude šipka, která není protisměrná nebo probíhající, zapíše se hodnota do proměné klavesa a cyklus bude přerušen
                    {
                        klavesa = pomocna;
                        break;
                    }
                }
                // u ostatních cyklů jsou parametry stejné, jenom se přičítá nebo odečítá příslušná souřadnice
                while (klavesa == ConsoleKey.DownArrow)
                {
                    Y++;
                    Pohyb();
                    PotravaSezrana();
                    RychlostY();
                    if (!Console.KeyAvailable)
                    {
                        continue;
                    }
                    pomocna = Console.ReadKey().Key;
                    if (pomocna == ConsoleKey.RightArrow || pomocna == ConsoleKey.LeftArrow)
                    {
                        klavesa = pomocna;
                        break;
                    }
                }
                while (klavesa == ConsoleKey.LeftArrow)
                {
                    X--;
                    Pohyb();
                    PotravaSezrana();
                    RychlostX();
                    if (!Console.KeyAvailable)
                    {
                        continue;
                    }
                    pomocna = Console.ReadKey().Key;
                    if (pomocna == ConsoleKey.UpArrow || pomocna == ConsoleKey.DownArrow)
                    {
                        klavesa = pomocna;
                        break;
                    }
                }
                while (klavesa == ConsoleKey.RightArrow)
                {
                    X++;
                    Pohyb();
                    PotravaSezrana();
                    RychlostX();
                    if (!Console.KeyAvailable)
                    {
                        continue;
                    }
                    pomocna = Console.ReadKey().Key;
                    if (pomocna == ConsoleKey.UpArrow || pomocna == ConsoleKey.DownArrow)
                    {
                        klavesa = pomocna;
                        break;
                    }
                }
            }

        }

        static void Score() // vypisuje skóre
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 0);
                Console.WriteLine("SCORE: {0} ", score);
            }

        static void Potrava() //generuje potravu
        {
            a = random.Next(1, Console.WindowWidth - 2); // vygeneruje náhodnou souřadnici pro potravu a (a = X) do Pole()
            b = random.Next(3, Console.WindowHeight - 2); // vygeneruje náhodnou souřadnici pro potravu b (b = Y) do Pole()
            if (a == X && b == Y) // zabraňuje náhodnému generování polohu X a Y 
            {
                Potrava();
            }
            for (int k = 0; k <= PocetClanku + 1; k++) // zabraňuje generování potravy do těla hada a jedno pole za hadem
            {
                if ((CisloCyklu - k) - 1 >= 0) // SouradniceX[] a SouradniceY[] nejsou při prvním generování nadefinované a CisloCyklu = 0
                {
                    if (a == SouradniceX[(CisloCyklu - k) - 1] && b == SouradniceY[(CisloCyklu - k) - 1]) // SouradniceX[(CisloCyklu - k) - 1] a SouradniceY[(CisloCyklu - k) - 1] vyhazují momentální polohu hada a jedno pole za ním
                    {
                        Potrava(); // generování se opakuje
                    }
                }
            }
            Console.SetCursorPosition(a, b); // nastaví kurzor na místo, kde bude potrava
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("0"); // Zapíše na konzoli
        }

        static void PotravaSezrana()
        {
            if (a == X && b == Y) // souřadnice potravy = souřadnice hada
            {
                if (PocetClanku == 1) // při prvním sežrání zvuk hraje pouze při delším sleepingu
                {
                    Console.Beep(7000, 100);
                }
                Console.Beep(7000, 70);
                Potrava();
                score = score + 100;
                Score();
                PocetClanku++;
            }
        }

        static void Pole() // vytvoří herní pole
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int x = 1; x < Console.WindowWidth; x++)
            {
                Console.SetCursorPosition(x, Console.WindowHeight - 1); //výpis dolní hranice
                Console.Write("-");
                Console.SetCursorPosition(x, 2);//výpis horní hranice
                Console.Write("-");
            }
            for (int y = 2; y < Console.WindowHeight; y++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 1, y);//výpis dolní hranice
                Console.Write("|");
                Console.SetCursorPosition(0, y);//výpis horní hranice
                Console.Write("|");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void Pohyb()
        {
            SouradniceX.Add(X); // přidá do listu mometální souřadnici, kterou uloží
            SouradniceY.Add(Y); // přidá do listu mometální souřadnici, kterou uloží
            Console.SetCursorPosition(X, Y); // nastaví kurzor na aktuální souřadnice
            CisloCyklu++;
            Console.Write("O");
            if ((CisloCyklu - PocetClanku) - 2 >= 0) // první dva průběhy metody se tělo hada "načítá" = není co mazat     
            {
                Console.SetCursorPosition(SouradniceX[(CisloCyklu - PocetClanku) - 2], SouradniceY[(CisloCyklu - PocetClanku) - 2]); // dá kurzor za poslední hadovu část 
                Console.Write(" "); // vymaže znak "O" a had má tělo dlouhé pouze podle proměné PocetClanku
                Console.SetCursorPosition(X, Y); // vrátí kurzor na hlavičku hada
            }
            for (int k = 0; k <= PocetClanku; k++)
            {
                if ((CisloCyklu - k) - 2 >= 0) // první dva průběhy metody se tělo hada "načítá"
                {
                    if (X == SouradniceX[(CisloCyklu - k) - 2] && Y == SouradniceY[(CisloCyklu - k) - 2]) // porovná aktuální souřadnice (hadova hlava) se souřadnicemi hadova těla
                    {
                        KonecHry();
                    }
                }
            }
            if (X == Console.WindowWidth - 1 || X == 0 || Y == Console.WindowHeight - 1 || Y == 2) // porovná aktuální souřadnice (hadova hlava) s herním polem
            {
                KonecHry();
            }
        }

        static void KonecHry()
        {
            Console.Beep(100, 700);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, (Console.WindowHeight / 2) - 2);
            Console.WriteLine("Konec hry!");
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, Console.WindowHeight / 2);
            Console.WriteLine("SCORE: {0} ", score);
            Console.SetCursorPosition(1, (Console.WindowHeight / 2) + 4);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Pro novou hru stiskněte enter, pro ukončení escape!");
            KonecHryVyber();
        }
        static void KonecHryVyber()
        {
            ConsoleKey pomocna = Console.ReadKey().Key;
            if (pomocna == ConsoleKey.Enter)
            {
                Zacatek();
            }
            else if (pomocna == ConsoleKey.Escape)
            {
                Environment.Exit(0); // nebo také: pokracovat = false; klavesa = ConsoleKey.Escape;
            }
            else // pokud klávesa není enter nebo escape, zadání se opakuje
            {
                KonecHryVyber();
            }
            }

        static void RychlostY()
        {
            if (Console.WindowWidth <= 80 && Console.WindowHeight <= 25) // rychlost hada se zvýší pokud okno bude mít větší rozměry než 80 x 25
            {
                System.Threading.Thread.Sleep(150);
            }
            else
            {
                System.Threading.Thread.Sleep(100);
            }
        }

        static void RychlostX() // osa x má menší mezery mezi znaky = vyšší rychlost
        {
            if (Console.WindowWidth <= 80 && Console.WindowHeight <= 25)
            {
                System.Threading.Thread.Sleep(100);
            }
            else
            {
                System.Threading.Thread.Sleep(50);
            }
        }

        static void Zacatek()
        {
            Console.Clear();
            PocetClanku = 1;
            score = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, Console.WindowHeight / 2);
            Console.WriteLine("FUNNY SNAKE");
            Console.ReadKey();
            Console.Clear();
            X = Console.WindowWidth / 2;
            Y = Console.WindowHeight / 2;
            Potrava(); // nová potrava
            Pole(); // vykreslí herní pole
            Score(); // vypíše skóre
            Console.SetCursorPosition(X, Y); // kurzor na střed
            PrvniZadani();
        }

        static void PrvniZadani()
        {
            klavesa = Console.ReadKey().Key;
            if (klavesa != ConsoleKey.UpArrow && klavesa != ConsoleKey.DownArrow && klavesa != ConsoleKey.LeftArrow && klavesa != ConsoleKey.RightArrow) //pokud klavesa není jakákoliv šipka, zadání se opakuje
            {
                PrvniZadani();
            }
        }
        #endregion Metody

            
        
    }
}




