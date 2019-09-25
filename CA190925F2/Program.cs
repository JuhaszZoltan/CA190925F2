using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190925F2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 16. feladat
            //Console.Write("kinti hőmérséklet: ");
            //int c = int.Parse(Console.ReadLine());
            //if (c <= 0)
            //{
            //    Console.WriteLine("fagy van odakint!");
            //}
            #endregion
            #region 17. feladat
            //Console.WriteLine("Szeretsz programozni?");
            //string valasz = Console.ReadLine();
            //if(valasz == "igen")
            //{
            //    Console.WriteLine("Még sokra viszed az életben!");
            //}
            //Console.WriteLine("Viszlát!");
            #endregion
            #region 18. feladat
            //Console.Write("szám: ");
            //int szam = int.Parse(Console.ReadLine());
            //if (szam % 2 == 0)
            //{
            //    Console.WriteLine("ez a szám páros!");
            //}
            //else
            //{
            //    Console.WriteLine("ez a szám páratlan!");
            //}
            #endregion
            #region 19. feladat
            //Console.Write("szám: ");
            //int szam = int.Parse(Console.ReadLine());
            //if (szam % 3 == 0)
            //{
            //    Console.WriteLine("osztható hárommal");
            //}
            //else
            //{
            //    Console.WriteLine("NEM osztható hárommal :(");
            //}
            #endregion
            #region 20. feladat
            //Console.Write("szám: ");
            //int szam = int.Parse(Console.ReadLine());
            //     if (szam < 0) Console.WriteLine("ez a szám negatív");
            //else if (szam > 0) Console.WriteLine("ez a szám pozitív");
            //else               Console.WriteLine("ez a szám nulla!");
            #endregion
            #region 21. feladat
            //Console.Write("első szám: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("második szám: ");
            //int b = int.Parse(Console.ReadLine());
            //if (a == b) Console.WriteLine($"{a} = {b}");
            //else if (a > b) Console.WriteLine($"{a} > {b}");
            //else Console.WriteLine($"{a} < {b}");
            #endregion
            #region 22. feladat
            //Console.Write("szám: ");
            //int szam = int.Parse(Console.ReadLine());
            //if (-30 < szam && szam < 40)
            //    Console.WriteLine("ez a szám -30 és 40 között van");
            //else
            //    Console.WriteLine("a szám nincs a megadott intervallumban");
            #endregion
            #region 23. feladat
            //Console.Write("pontszám: ");
            //int p = int.Parse(Console.ReadLine());
            //if (p < 0 || p > 100) Console.WriteLine("valami nem stimmel");
            //else if (p < 43) Console.WriteLine("elégtelen");
            //else if (p < 58) Console.WriteLine("elégséges");
            //else if (p < 73) Console.WriteLine("közepes");
            //else if (p < 88) Console.WriteLine("jó");
            //else Console.WriteLine("jeles");
            #endregion
            #region 24. feladat
            //Console.Write("település neve: ");
            //string nev = Console.ReadLine();
            //Console.Write("lélekszám: ");
            //int l = int.Parse(Console.ReadLine());
            //if (l <= 0) Console.WriteLine("rossz adat!");
            //else if (l < 5000) Console.WriteLine($"{nev} egy község");
            //else if (l < 20000) Console.WriteLine($"{nev} egy kisváros");
            //else if (l < 100000) Console.WriteLine($"{nev} egy középváros");
            //else if (l < 1000000) Console.WriteLine($"{nev} egy nagyváros");
            //else Console.WriteLine($"{nev} egy metropolisz");
            #endregion
            #region 25. feladat
            //Console.Write("a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("művelet: ");
            //char m = char.Parse(Console.ReadLine());
            //if (m == '*')
            //    Console.WriteLine($"{a}*{b}={a * b}");
            //else if (m == '+')
            //    Console.WriteLine($"{a}+{b}={a + b}");
            //else if (m == '-')
            //    Console.WriteLine($"{a}-{b}={a - b}");
            //else if (m == '/')
            //    Console.WriteLine($"{a}/{b}={a / (float)b}");
            //else
            //    Console.WriteLine("nincs ilyern művelet :(");
            #endregion
            #region 10. feladat
            //Console.Write("testsúly (kg): ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("magasság (cm): ");
            //float h = int.Parse(Console.ReadLine()) / 100F;
            //double tti = m / Math.Pow(h, 2);
            //if (tti < 16) Console.WriteLine("súlyos soványság");
            //else if (tti < 17) Console.WriteLine("mérsékelt soványság");
            //else if (tti < 18.5) Console.WriteLine("enyhe soványság");
            //else if (tti < 25) Console.WriteLine("normál testsúly");
            //else if (tti < 30) Console.WriteLine("túlsúlyos");
            //else if (tti < 35) Console.WriteLine("I. fokú elhízás");
            //else if (tti < 40) Console.WriteLine("II. fokú elhízás");
            //else Console.WriteLine("III. fokú (súlyos) elhízás");
            #endregion
            #region 29. feladat
            //Console.Write("termék ára: ");
            //int ar = int.Parse(Console.ReadLine());
            //Console.Write("ennyi db-ot szeretnék venni: ");
            //int db = int.Parse(Console.ReadLine());
            //Console.Write("ennyi pénzem van: ");
            //int ft = int.Parse(Console.ReadLine());
            //if(ar * db <= ft)
            //{
            //    Console.WriteLine("meg tudom venni");
            //    Console.WriteLine($"{ft -(ar * db)} Ft-om marad");
            //}
            //else
            //{
            //    Console.WriteLine($"csak {ft / ar} db-ot tudok venniennyi pénzből :(");
            //}
            #endregion
            #region 30. feladat
            ////1963
            ////2004
            ////1700
            ////2000
            //Console.Write("ev: ");
            //int ev = int.Parse(Console.ReadLine());
            ////1. verzió
            //if( ev % 400 == 0) Console.WriteLine("szökőév");
            //else if (ev % 100 == 0) Console.WriteLine("nem szökőév");
            //else if (ev % 4 == 0) Console.WriteLine("szökőév");
            //else Console.WriteLine("nem szökőév");
            ////2. verzió
            //if((ev % 100 == 0 || ev % 4 != 0) && ev % 400 != 0)
            //    Console.WriteLine("NEM szökőév");
            //else Console.WriteLine("szökőév");
            ////3. verzió
            //if((ev % 100 != 0 && ev % 4 == 0) || ev % 400 == 0)
            //    Console.WriteLine("szökőév");
            //else Console.WriteLine("NEM szökőév");
            #endregion
            #region 13. feladat
            Console.Write("ennyi Ft-ot szeretnék felvenni: ");
            int ft = int.Parse(Console.ReadLine());
            if (ft >= 300000)
                Console.WriteLine("maximum 300K Ft-ot tud kiadni az automata :(");
            else if (ft < 0)
                Console.WriteLine("ennél az automatánál nem tudsz befizetni");
            else if (ft == 0)
                Console.WriteLine("akkor cső");
            else if (ft % 1000 != 0)
                Console.WriteLine("csak kerek 1000es összeget tudsz felvenni!");
            else
            {
                int p20 = ft / 20000;
                ft = ft % 20000;
                int p10 = ft / 10000;
                ft = ft % 10000;
                int p5 = ft / 5000;
                ft = ft % 5000;
                int p2 = ft / 2000;
                ft = ft % 2000;
                int p1 = ft / 1000;

                Console.WriteLine("Kiadott bankjegyek: ");

                if (p20 != 0) Console.WriteLine("{0,2} * 20 000 = {1, 6} Ft", p20, 20000 * p20);
                if (p10 != 0) Console.WriteLine("{0,2} * 10 000 = {1, 6} Ft", p10, 10000 * p10);
                if (p5  != 0) Console.WriteLine("{0,2} *  5 000 = {1, 6} Ft", p5,   5000 * p5 );
                if (p2  != 0) Console.WriteLine("{0,2} *  2 000 = {1, 6} Ft", p2,   2000 * p2 );
                if (p1  != 0) Console.WriteLine("{0,2} *  1 000 = {1, 6} Ft", p1,   1000 * p1 );
                Console.WriteLine("-----------------------");
                Console.WriteLine("Össesen:      {0, 6} Ft", 
                    20000 * p20 + 
                    10000 * p10 + 
                     5000 *  p5 + 
                     2000 *  p2 + 
                     1000 *  p1);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
