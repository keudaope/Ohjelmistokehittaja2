using System;

namespace Lumoakatemia_Perustehtavat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tehtava18();
        }
        static void Tehtava1()
        {
            Console.WriteLine("Hei maailma!");
        }
        static void Tehtava2(int x, int y)
        {
            Console.WriteLine("Lukujen {0} ja {1} summa on {2}", x, y, x + y);
        }
        static void Tehtava3(int x, int y)
        {
            Console.WriteLine("Lukujen {0} ja {1} erotus on {2}", x, y, x - y);
        }
        static void Tehtava4(int x, int y) 
        {
            Console.WriteLine("Lukujen {0} ja {1} tulo on {2}", x, y, x * y);
        }
        static void Tehtava5(double x, int y)
        {
            Console.WriteLine("Lukujen {0} ha {1} osamäärä on {2}", x, y, x / y);
        }
        static void Tehtava6()
        {
            Console.Write("Anna Celsiusasteet: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} astetta celsiusta on {1} astetta Fahrenheitia", celsius, celsius * 1.8 + 32);
        }
        static void Tehtava7()
        {
            Console.WriteLine("Anna Fahrenheitasteet: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} astetta fahrenheitia on {1} astetta celsiusta", fahrenheit, (fahrenheit - 32) / 1.8);
        }
        static void Tehtava8()
        {
            Console.Write("Anna mailimäärä: ");
            double mailit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} mailia on {1} kilometriä", mailit, mailit * 1.609);
        }
        static void Tehtava9()
        {
            Console.Write("Anna kilometrimäärä: ");
            double kilometrit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} kilometriä on {1} mailia", kilometrit, kilometrit / 1.609);
        }
        static void Tehtava10()
        {
            Console.Write("Anna tuumamäärä: ");
            double tuumat = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} tuumaa on {1} senttiä", tuumat, tuumat * 2.54);
        }
        static void Tehtava11()
        {
            Console.Write("Anna senttimäärä: ");
            double sentit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} senttiä on {1} tuumaa", sentit, sentit / 2.54);
        }
        static void Tehtava12()
        {
            Console.Write("Anna yardimäärä: ");
            double yardit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} yardia on {1} metriä", yardit, yardit * 0.9144);
        }
        static void Tehtava13()
        {
            Console.Write("Anna metrimäärä: ");
            double metrit = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} metriä on {1} yardia", metrit, metrit / 0.9144);
        }
        static void Tehtava14a()
        {
            int luku1, luku2;
            l1:
            Console.Write("Anna 1. yhteenlaskettava: ");
            bool success = int.TryParse(Console.ReadLine(),out luku1);
            if(!success )
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l1;
            }
            l2:
            Console.Write("Anna 2. yhteenlaskettava: ");
            success = int.TryParse(Console.ReadLine(), out luku2);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l2;
            }
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, luku1 + luku2);
        }
        static void Tehtava14b()
        {
            int luku1, luku2;
        l1:
            Console.Write("Anna vähennettävä: ");
            bool success = int.TryParse(Console.ReadLine(), out luku1);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l1;
            }
        l2:
            Console.Write("Anna vähentäjä: ");
            success = int.TryParse(Console.ReadLine(), out luku2);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l2;
            }
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, luku1 - luku2);
        }
        static void Tehtava14c()
        {
            int luku1, luku2;
        l1:
            Console.Write("Anna kerrottava: ");
            bool success = int.TryParse(Console.ReadLine(), out luku1);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l1;
            }
        l2:
            Console.Write("Anna kertoja: ");
            success = int.TryParse(Console.ReadLine(), out luku2);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l2;
            }
            Console.WriteLine("{0} * {1} = {2}", luku1, luku2, luku1 * luku2);
        }
        static void Tehtava14d()
        {
            int luku1, luku2;
        l1:
            Console.Write("Anna jaettava: ");
            bool success = int.TryParse(Console.ReadLine(), out luku1);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l1;
            }
        l2:
            Console.Write("Anna jakaja: ");
            success = int.TryParse(Console.ReadLine(), out luku2);
            if (!success)
            {
                Console.WriteLine("Et antanut numeroa!");
                goto l2;
            }
            Console.WriteLine("{0} / {1} = {2}", luku1, luku2, luku1 / luku2);
        }
        static void Tehtava15()
        {
            Console.Write("Anna ympyrän säde: ");
            double sade = double.Parse(Console.ReadLine());
            Console.WriteLine("Ympyrän ala on {1}, kun säde on {0}", sade, 3.1415 * sade * sade);
        }
        static void Tehtava16()
        {
            Console.Write("Anna neliön sivun pituus: ");
            int sivu = int.Parse(Console.ReadLine());
            Console.WriteLine("Neliön ala on {1}, kun sivun pituus on {0}", sivu, sivu * sivu);
        }
        static void Tehtava17()
        {
            Console.Write("Anna suorakulmion leveys: ");
            int leveys = int.Parse(Console.ReadLine());
            Console.Write("Anna suorakulmion pituus: ");
            int pituus = int.Parse(Console.ReadLine());
            Console.WriteLine("Suorakulmion ala on {2}, kun leveys on {0} ja pituus on {1}", leveys, pituus, leveys * pituus);
        }
        static void Tehtava18()
        {
            Console.Write("Anna päivien määrä: ");
            double paivat = int.Parse(Console.ReadLine());
            double vuodet = paivat / 365.25 - (paivat % 365.25)/365.25 ;
            paivat = paivat - (int)(365.25 * vuodet);
            double kuukaudet = (int)(paivat / 30.4166);
            double paiva = paivat - (int)(30.4166 * kuukaudet);
            Console.WriteLine("{0} päivää on {1} vuotta {2} kuukautta ja {3} päivää", paivat, vuodet, kuukaudet,paiva);
        }
    }
}