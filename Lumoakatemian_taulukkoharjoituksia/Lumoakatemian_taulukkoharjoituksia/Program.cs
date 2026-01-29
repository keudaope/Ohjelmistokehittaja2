using System.Collections.Generic;

namespace Lumoakatemian_taulukkoharjoituksia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kauppalista();
            //Nimet();
            //TaulukonPituus();
            //LisaaNimiTaulukkoon();
            //YhdistaTaulukot();
            //Parilliset();
            //Lajittelu();
            //Kaannos();
            //Merkkijonoksi();
            //AlkionPoisto();
            //TiettyAlkio();
            //KopioiOsaTaulukosta();
            //TaulukonJasenenMuutos();
            //TaulukonSumma();
            //TaulukonLukujenKeskiarvo();
            //KolmeKertaaKopio();
            //Uniikit();
            //TaulukonArvojenVaihto();
            //IsotKirjaimet();
            PoistaNeljaaPienemmat();
        }
        static void Kauppalista()
        {
            string[] kauppalista = { "Maito", "Leipä", "Omenat" };
            foreach(string tuote in kauppalista)
            {
                Console.WriteLine("- {0}", tuote);
            }
        }
        static void Nimet()
        {
            string[] nimet = { "Mikko", "Maija", "Kyllikki", "Kalle", "Noora" };
            foreach(string nimi in nimet)
            {
                Console.WriteLine("- {0}", nimi);
            }
        }
        static void TaulukonPituus()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };
            int pituus = numerot.Length;
            Console.WriteLine("taulukon [{0}] pituus on {1}", string.Join(", ", numerot), pituus);
        }
        static void LisaaNimiTaulukkoon()
        {
            List<string> taulukko = new List<string> { "Matti", "Anna", "Eeva" };
            taulukko.Add("Pekka");
            foreach (string nimi in taulukko)
            {
                Console.WriteLine("- {0}", nimi);
            }
        }
        static void YhdistaTaulukot()
        {
            int[] taul1 = { 1, 2, 3 };
            int[] taul2 = { 4, 5, 6 };
            int[] yhdistetty = taul1.Concat(taul2).ToArray();
            foreach (int numero in yhdistetty)
            {
                Console.WriteLine("- {0}", numero);
            }
        }
        static void Parilliset()
        {
            int[] numerot = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] parilliset = numerot.Where(numero => numero % 2 == 0).ToArray();
            foreach (int numero in parilliset)
            {
                Console.WriteLine("- {0}", numero);
            }
        }
        static void Lajittelu()
        {
            int[] numerot = { 5, 2, 9, 1, 5, 8, 3 };
            Array.Sort(numerot);
            Console.WriteLine("Taulukko lajiteltuna: {0}", string.Join(", ", numerot));
        }
        static void Kaannos()
        {
            int[] taulukko = { 1, 2, 3, 4, 5 };
            int[] uusitaulukko = taulukko.Reverse().ToArray();
            Console.WriteLine("Taulukko {0} käännettynä on {1}", string.Join(", ", taulukko), string.Join(", ", uusitaulukko));
        }
        static void Merkkijonoksi()
        {
            string[] taulukko = { "Matti", "Anna", "Eeva" };
            string merkkijono = string.Join(", ", taulukko);
            Console.WriteLine("Taulukko [{0}] merkkijonona on {1}", string.Join(", ", taulukko), merkkijono);
        }
        static void AlkionPoisto()
        {
            List<int> numerot = new List<int>{ 1, 2, 3, 4, 5 };
            numerot.RemoveAt(2);
            Console.WriteLine(string.Join(", ", numerot));           
        }
        static void TiettyAlkio()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            int index = num.Find(x => x == 3);
            Console.WriteLine("Numeron 3 taulukosta {1} indeksi on {0}", index, string.Join(", ", num));
        }
        static void KopioiOsaTaulukosta()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            List<int> uusi = new List<int>();
            uusi.Add(num.Count-1);
            uusi.Add(num.Count);
            Console.WriteLine("taulukon [{0}] kaksi viimeistä jäsentä uudessa taulukossa [{1}]", string.Join(", ", num), string.Join(", ", uusi));
        }
        static void TaulukonJasenenMuutos()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            num[num.Count / 2] = 6;
            Console.WriteLine("Taulukko muutettuna [{0}] ", string.Join(", ", num));
        }
        static void TaulukonSumma()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            int summa = 0;
            for(int i = 0; i <num.Count; i++) 
            {
                summa+= num[i];
            }
            Console.WriteLine("Taulukon [{0}] lukujen summa on {1}", string.Join(", ", num), summa);
        }
        static void TaulukonLukujenKeskiarvo()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            int summa = 0;
            double keskiarvo = 0;
            for (int i = 0; i < num.Count; i++)
            {
                summa += num[i];
            }
            keskiarvo = (double)summa / num.Count;
            Console.WriteLine("Taulukon [{0}] lukujen keskiarvo on {1}", string.Join(", ", num), keskiarvo);
        }
        static void KolmeKertaaKopio()
        {
            int[] num = { 1, 2, 3 };
            
            int[] yhdistetty = num.Concat(num).ToArray().Concat(num).ToArray();
            Console.WriteLine("Yhdistetty [{0}]", string.Join(", ", yhdistetty));
        }
        static void Uniikit()
        {
            List<int> num = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            List<int> uni = num.Distinct().ToList();
            Console.WriteLine("Listan [{0}] yksilölliset arvot [{1}]", string.Join(", ", num), string.Join(", ", uni));
        }
        static void TaulukonArvojenVaihto()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };
            int temp = num[num.Count - 1];
            num[num.Count - 1] = num[0];
            num[0] = temp;
            Console.WriteLine("Uusi taulukko, jossa 1. ja viimeiset arvot vaihtaneet paikkaa: [{0}]", string.Join(", ", num));
        }
        static void IsotKirjaimet()
        {
            List<string> nimet = new List<string> { "Matti", "Anna", "Eeva" };
            List<string> isot = nimet.ConvertAll(x => x.ToUpper());
            Console.WriteLine("Taulukon [{0}] arvot isoita [{1}]", string.Join(", ", nimet), string.Join(", ", isot));
        }
        static void PoistaNeljaaPienemmat()
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int[] neljaaPienemmat = num.Where(numero => numero >= 4).ToArray();
            Console.WriteLine("Taulusta [{0}] poistettu neljää pienemmät [{1}]", string.Join(", ", num), string.Join(", ", neljaaPienemmat));
        }
    }
}