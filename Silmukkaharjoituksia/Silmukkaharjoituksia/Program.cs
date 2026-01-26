namespace Silmukkaharjoituksia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TakaisinMaksu();
            //Kertoma();
            //EnsimmainenEsiintyma(); 
            //KaannaSana();
            //Maksimi();
            //Keskiarvo();
            //IsoTaulukko();
            //SeitsemasPariton();
            //ToiseksiSuurin();
            //SanaTulostus();
            //Fibonacci();
            //Palidromi();
            //FibonacciParillistenSumma();
            //FibonacciParittomienSumma();
            //SuurinNimittaja();
            Pilkut();
        }
        static void TakaisinMaksu()
        {
            int laina = 5000;
            float korko = 0.02f;
            int vuodet = 2;
            float maksu = laina;
            for(int i = 0; i < vuodet; i++) 
            {
                maksu = maksu + maksu * korko;
            }
            Console.WriteLine("Maksettavaa tulee yhteensä: {0} euroa", maksu);
        }
        static void Kertoma()
        {
            Console.Write("Anna luku, jonka kertoman kerron sinulle: ");
            int luku = int.Parse(Console.ReadLine());
            int kertoma = 1;
            for(int i = 1; i<= luku; i++) 
            {
                kertoma *= i;
            }
            Console.WriteLine("Luvun {0} kertoma on {1}", luku, kertoma);
        }
        static void EnsimmainenEsiintyma()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            int esiintyma = 0;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] == 3)
                {
                    esiintyma = i;
                    break;
                }
            }
            Console.WriteLine("Luvun 3 ensimmäinen esiintymä on kohdassa {0}", esiintyma);
        }
        static void KaannaSana()
        {
            Console.Write("Anna sana, joka käännetään toisinpäin: ");
            string sana = Console.ReadLine();
            for(int i = sana.Length -1; i >= 0; i--)
            {
                Console.Write(sana[i]);
            }
        }
        static void Maksimi()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1 };
            int maksimi = 0;
            for(int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] > maksimi)
                {
                    maksimi = taulukko[i];
                }
            }
            Console.WriteLine("Taulukon {0} maksimiarvo on {1}", string.Join(", ", taulukko), maksimi);
        }
        static void Keskiarvo()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1 };
            int summa = 0;
            for(int i = 0; i < taulukko.Length; i++) 
            {
                summa+= taulukko[i];
            }
            Console.WriteLine("Taulukon {0} keskiarvo on {1}", string.Join(", ", taulukko), (float)summa / taulukko.Length);
        }
        static void IsoTaulukko()
        {
            char[] taulukko = { 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] uusiTaulukko = new char[6];
            for (int i = 0; i < taulukko.Length; i++)
            {
                uusiTaulukko[i] = char.ToUpper(taulukko[i]);
            }
            Console.WriteLine("taulukon [{0}] kirjaimet isoina ovat [{1}]", string.Join(", ", taulukko), string.Join(", ", uusiTaulukko));
        }
        static void SeitsemasPariton()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            int laskuri = 0;
            int seitsemas = 0;
            for(int i = 0; i < taulukko.Length; i++) 
            {
                if (taulukko[i] % 2 != 0)
                {
                    laskuri++;
                    if(laskuri == 7)
                    {
                        seitsemas = taulukko[i];
                        break;
                    }
                }
            }
            Console.WriteLine("Taulukon [{0}] seitsemäs pariton on {1}", string.Join(", ", taulukko), seitsemas);
        }
        static void ToiseksiSuurin()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            Array.Sort(taulukko);
            Console.WriteLine("Taulukon [{0}] toiseksi suurin jäsen on {1}", string.Join(", ", taulukko), taulukko[taulukko.Length - 2]);
        }
        static void SanaTulostus()
        {
            for(int i = 1; i <= 100; i++) 
            {
                if(i % 15 == 0)
                {
                    Console.Write("Viisitoista ");
                }
                else if(i % 5 == 0)
                {
                    Console.Write("Viisi ");
                }
                else if(i % 3 == 0)
                {
                    Console.Write("Kolme ");
                }
                else 
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        static void Fibonacci()
        {
            int[] fibo = new int[10];
            fibo[0] = 0;
            fibo[1] = 1;
            for(int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i-1] + fibo[i-2];
            }
            Console.WriteLine("10 ensimmäistä Fibonaccin lukua ovat [{0}]", string.Join(", ", fibo));
        }
        static void Palidromi()
        {
            Console.Write("Anna sana, jonka tarkastan (kirjoita kaikki pienillä): ");
            string sana = Console.ReadLine();
            char[] annettusana = sana.ToCharArray();
            Array.Reverse(annettusana);
            string muutettu = new string(annettusana);
            if(sana == muutettu)
            {
                Console.WriteLine("Sana on palidromi");
            }
            else
            {
                Console.WriteLine("Sana ei ole palidromi");
            }          
        }
        static void FibonacciParillistenSumma()
        {
            int[] fibo = new int[10];
            fibo[0] = 0;
            fibo[1] = 1;
            int summa = 0;
            for (int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                if (fibo[i] % 2 == 0)
                {
                    summa += fibo[i];
                }
            }
            Console.WriteLine("10 ensimmäistä Fibonaccin lukua ovat [{0}] ja niiden summa {1}", string.Join(", ", fibo), summa);
        }
        static void FibonacciParittomienSumma()
        {
            int[] fibo = new int[10];
            fibo[0] = 0;
            fibo[1] = 1;
            int summa = 0;
            for (int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                if (fibo[i] % 2 != 0)
                {
                    summa += fibo[i];
                }
            }
            Console.WriteLine("10 ensimmäistä Fibonaccin lukua ovat [{0}] ja niiden summa {1}", string.Join(", ", fibo), summa+1);
        }
        static void SuurinNimittaja()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int eka, toka, temp;
            Console.Write("Anna isompi muuttuja: ");
            eka = Int32.Parse(Console.ReadLine());
            Console.Write("Anna pienempi muuttuja: ");
            toka = Int32.Parse(Console.ReadLine());
            while (toka != 0)
            {
                Console.WriteLine(toka);
                temp = toka;
                toka = eka % toka;
                eka = temp;
            }
            Console.WriteLine("Muuttujien suurin yhteinen nimittäjä on {0}", eka);
        }
        static void Pilkut()
        {
            Console.WriteLine("Anna numeroita pilkulla erotettuna, niin tulostan ne ilman pilkkua: ");
            string numerot = Console.ReadLine();
            string[] merkkijono = numerot.Split(",");
            
            Console.WriteLine("Antamasi merkkijono {1} ilman pilkkuja {0}", string.Join(" ", merkkijono), numerot);
        }
    }
}