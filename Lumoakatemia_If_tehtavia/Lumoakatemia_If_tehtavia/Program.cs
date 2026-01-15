namespace Lumoakatemia_If_tehtavia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tehtava18();

        }
        static void Tehtava01()
        {
            int suurin;
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if(luku1 >= luku2) 
            {
                suurin = luku1;
            }
            else 
            { 
                suurin = luku2;
            }
            Console.WriteLine("Luvuista {0} ja {1} suurin on {2}", luku1, luku2, suurin);
        }
        static void Tehtava02()
        {
            int suurin;
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. luku: ");
            int luku3 = int.Parse(Console.ReadLine());
            if(luku1 >= luku2 && luku1 >= luku3)
            {
                suurin = luku1;
            }
            else if(luku2 >= luku3)
            {
                suurin = luku2;
            }
            else
            { suurin = luku3;}
            Console.WriteLine("Annetuista luvuista {0}, {1} ja {2} suurin on {3}", luku1, luku2, luku3, suurin);
        }
        static void Tehtava03()
        {
            Console.Write("Anna luku, niin tarkistan sen etumerkin: ");
            int luku = int.Parse(Console.ReadLine());
            if(luku < 0)
            {
                Console.WriteLine("Luku on negatiivinen");
            }
            else if (luku == 0) 
            {
                Console.WriteLine("Luku on nolla");
            }
            else
            {
                Console.WriteLine("Luku on positiivinen");
            }
        }
        static void Tehtava04()
        {
            Console.Write("Anna luku, niin tarkistan sen jaollisuuden: ");
            int luku = int.Parse(Console.ReadLine()) ;
            if(luku % 11 == 0 && luku % 5 == 0)
            {
                Console.WriteLine("Luku on jaollinen sekä 11:sta, että 5:llä.");
            }
            else if(luku % 11 == 0)
            {
                Console.WriteLine("Luku on jaollinen 11:sta.");
            }
            else if(luku % 5  == 0)
            {
                Console.WriteLine("Luku on jaollinen 5:llä.");
            }
            else
            {
                Console.WriteLine("Luku ei ole jaollinen 11:sta eikä 5:llä.");
            }
        }
        static void Tehtava05()
        {
            Console.Write("Anna vuosiluku, niin tarkastan, onko se karkausvuosi: ");
            int vuosi = int.Parse(Console.ReadLine());
            if(vuosi % 400 == 0) 
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            else if(vuosi % 4 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
        }
        static void Tehtava06()
        {
            Console.Write("Anna luku, niin tarkistan, onko se parillinen vai pariton: ");
            int luku = int.Parse(Console.ReadLine());
            if(luku % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen.");
            }
            else
            {
                Console.WriteLine("Luku on pariton.");
            }
        }
        static void Tehtava07() 
        {
            Console.Write("Anna merkki, niin tarkistan onko se kirjain vai ei: ");
            char merkki = char.Parse(Console.ReadLine());
            if(Char.IsLetter(merkki)) 
            {
                Console.WriteLine("Annettu merkki on kirjain.");
            }
            else
            {
                Console.WriteLine("Annettu merkki ei ole kirjain.");
            }
        }
        static void Tehtava08() 
        {
            Console.Write("Anna merkki, niin tarkistan, onko se vokaali: ");
            char merkki = char.Parse(Console.ReadLine());
            merkki = Char.ToLower(merkki);
            if(merkki == 'a' || merkki == 'e' || merkki == 'i' || merkki == 'o' || merkki == 'u' || merkki == 'y' || merkki == 'å' || merkki == 'ä' || merkki == 'ö')
            {
                Console.WriteLine("Annettu merkki on vokaali.");
            }
            else
            {
                Console.WriteLine("Annettu merkki ei ole vokaali");
            }
        }
        static void Tehtava09() 
        {
            Console.Write("Anna merkki, niin tarkistan, millainen merkki se on: ");
            char merkki = char.Parse(Console.ReadLine());
            if(char.IsLetter(merkki)) 
            {
                Console.WriteLine("Annettu merkki on kirjain.");
            }
            else if(char.IsNumber(merkki))
            {
                Console.WriteLine("Annettu merkki on numero.");
            }
            else 
            {
                Console.WriteLine("Annettu merkki on erikoismerkki.");
            }
        }
        static void Tehtava10()
        {
            Console.Write("Anna kirjain, niin tarkistan, onko se iso vai ei: ");
            char kirjain = char.Parse(Console.ReadLine());
            if(Char.IsUpper(kirjain)) 
            {
                Console.WriteLine("Annettu kirjain on iso kirjain.");
            }
            else if(Char.IsLower(kirjain))
            {
                Console.WriteLine("Annettu kirjain on pieni kirjain.");

            }
            else 
            {
                Console.WriteLine("Annettu merkki ei ollut kirjain.");
            }
        }
        static void Tehtava11()
        {
            Console.Write("Anna, miten paljon myynneistä on kertynyt: ");
            double myynnit = double.Parse(Console.ReadLine());
            Console.Write("Anna, paljonko ostoista on kertynyt: ");
            double ostot = double.Parse(Console.ReadLine());
            if(myynnit>= ostot) 
            {
                Console.WriteLine("Olet tehnyt voittoa {0} euroa", myynnit - ostot);
            }
            else
            {
                Console.WriteLine("Olet tehnyt tappiota {0} euroa", myynnit - ostot);
            }
        }
        static void Tehtava12() 
        {
            string[] aineet = { "Ma", "KeFy", "Äi", "Ru", "En" };
            int[] arvosanat = new int[5];
            
            for(int i = 0; i < aineet.Length; i++) 
            {
                Console.Write("Anna {0} arvosana: ", aineet[i]);
                arvosanat[i] = int.Parse(Console.ReadLine());
                if (arvosanat[i] >= 90)
                {
                    Console.WriteLine("{0}:n arvosana K5", aineet[i]);
                }
                else if (arvosanat[i] >= 80)
                {
                    Console.WriteLine("{0}:n arvosana H4", aineet[i]);
                }
                else if (arvosanat[i] >= 70)
                {
                    Console.WriteLine("{0}:n arvosana H3", aineet[i]);
                }
                else if (arvosanat[i] >= 60)
                {
                    Console.WriteLine("{0}:n arvosana T2", aineet[i]);
                }
                else if (arvosanat[i] >= 50)
                {
                    Console.WriteLine("{0}:n arvosana T1", aineet[i]);
                }
                else
                {
                    Console.WriteLine("{0}:n arvosana on Hylätty", aineet[i]);
                }
            }
        }
        static void Tehtava13()
        {
            Console.Write("Anna viikonpäivän numero (1-7), niin tulostan viikonpäivän nimen: ");
            int vknro = int.Parse(Console.ReadLine());
            switch (vknro) 
            {
                case 1:
                    Console.WriteLine("Maanantai");
                    break;
                case 2: Console.WriteLine("Tiistai");
                    break;
                case 3: Console.WriteLine("Keskiviikko");
                    break;
                case 4: Console.WriteLine("Torstai");
                    break;
                case 5: Console.WriteLine("Perjantai");
                    break;
                case 6: Console.WriteLine("Lauantai");
                    break;
                case 7: Console.WriteLine("Sunnuntai");
                    break;
                default:
                    Console.WriteLine("Et antanut numeroa välillä 1-7");
                    break;
            }
        }
        static void Tehtava14() 
        {
            Console.Write("Anna 1. kokonaisluku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. kokonaisluku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if(luku1 == luku2)
            {
                Console.WriteLine("Luvut ovat samat");
            }
            else
            {
                Console.WriteLine("Luvut eivät ole samat.");
            }
        }
        static void Tehtava15() 
        {
            Console.Write("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());
            if(ika >= 18)
            {
                Console.WriteLine("Voit äänestää.");
            }
            else
            {
                Console.WriteLine("Et voi äänestää.");
            }
        }
        static void Tehtava16()
        {
            Console.Write("Anna kuukauden numero (1-12) : ");
            int kknro = int.Parse(Console.ReadLine());
            switch(kknro)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Kuukaudessa on 31 päivää");
                    break;
                case 2:
                    Console.WriteLine("Kuukaudessa on 28/29 päivää");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Kuukaudessa on 30 päivää");
                    break;
                default:
                    Console.WriteLine("Et antanut lukua välillä 1-12");
                    break;
            }
        }
        static void Tehtava17() 
        {
            Console.Write("Anna rahasumma: ");
            double rahasumma = double.Parse(Console.ReadLine());
            Console.WriteLine("500 euron seteleitä on: {0} kpl", (int)(rahasumma) / 500);
            rahasumma -= ((int)(rahasumma) / 500)*500;
            Console.WriteLine("200 euron seteleitä on: {0} kpl", (int)(rahasumma) / 200);
            rahasumma -= ((int)(rahasumma) / 200)*200;
            Console.WriteLine("100 euron seteleitä on: {0} kpl", (int)(rahasumma) / 100);
            rahasumma -= ((int)(rahasumma) / 100) * 100;
            Console.WriteLine("50 euron seteleitä on: {0} kpl", (int)rahasumma / 50);
            rahasumma -= ((int)(rahasumma) / 50) * 50;
            Console.WriteLine("20 euron seteleitä on: {0} kpl", (int)rahasumma / 20);
            rahasumma -= ((int)(rahasumma) / 20) * 20;
            Console.WriteLine("10 euron seteleitä on: {0} kpl", (int)rahasumma / 10);
            rahasumma -= ((int)(rahasumma) / 10) * 10;
            Console.WriteLine("5 euron seteleitä on: {0} kpl", (int)rahasumma / 5);
            rahasumma -= ((int)(rahasumma) / 5) * 5;
            Console.WriteLine("2 euron kolikoita on: {0} kpl", (int)rahasumma / 2);
            rahasumma -= ((int)(rahasumma) / 2) * 2;
            Console.WriteLine("1 euron kolikoita on: {0} kpl", (int)rahasumma / 1);
            rahasumma -= ((int)(rahasumma) / 1) * 1;
            rahasumma *= 100;
            Console.WriteLine("50 centin kolikoita on: {0} kpl", (int)rahasumma / 50);
            rahasumma -= ((int)(rahasumma) / 50) * 50;
            Console.WriteLine("20 centin kolikoita on: {0} kpl", (int)rahasumma / 20);
            rahasumma -= ((int)(rahasumma) / 20) * 20;
            Console.WriteLine("10 centin kolikoita on: {0} kpl", (int)rahasumma / 10);
            rahasumma -= ((int)(rahasumma) / 10) * 10;
            Console.WriteLine("5 centin kolikoita on: {0} kpl", (int)rahasumma / 5);
            rahasumma -= ((int)(rahasumma) / 5) * 5;
            Console.WriteLine("2 centin kolikoita on: {0} kpl", (int)rahasumma / 2);
            rahasumma -= ((int)(rahasumma) / 2) * 2;
            Console.WriteLine("1 centin kolikoita on: {0} kpl", (int)rahasumma / 1);
            rahasumma -= ((int)(rahasumma) / 1) * 1;
        }
        static void Tehtava18()
        {
            Console.Write("Anna 1. kulman asteet: ");
            double kulma1 = double.Parse(Console.ReadLine());
            Console.Write("Anna 2. kulman asteet: ");
            double kulma2 = double.Parse(Console.ReadLine());
            Console.Write("Anna 3. kulman asteet: ");
            double kulma3 = double.Parse(Console.ReadLine());
            if(kulma1 + kulma2 + kulma3 == 180)
            {
                Console.WriteLine("Kolmio on mahdollista piirtää.");
            }
            else 
            {
                Console.WriteLine("Kolmiota ei ole mahdollista piirtää.");
            }

        }
    }
}