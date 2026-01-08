namespace Dia27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LuvutJarjestyksessa();
            //Suurinkolmesta();
            //TulostaSanana();
            //SuurinViidesta();
            //SyotettavaTieto();
            // Bonus();
            LuvutSanoiksi();
        }
        static void LuvutJarjestyksessa()
        {
            Console.Write("Anna luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                int temp = luku1;
                luku1 = luku2;
                luku2 = temp;
            }
            Console.WriteLine(luku1 + " " + luku2);
        }

        static void Suurinkolmesta()
        {
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. luku: ");
            int luku3 = int.Parse(Console.ReadLine());
            int suurin;
            if(luku1 > luku2 && luku1 > luku3)
            {
                suurin = luku1;
            }
            else if(luku2 > luku3)
            {
                suurin = luku2;
            }
            else { suurin = luku3;}

            Console.WriteLine("Suurin luku oli: " + suurin);
        }
        static void TulostaSanana()
        {
            Console.Write("Anna luku välillä 0-9: ");
            int luku = int.Parse(Console.ReadLine());
            switch (luku)
            {
                case 0:
                    Console.WriteLine("Nolla");
                    break;
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Kolme");
                    break; 
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default: 
                    Console.WriteLine("En valinnut lukua välillä 0-9!");
                    break;
            }
        }
        static void SuurinViidesta()
        {
            int[] luvut = new int[5];
            Console.Write("Anna 1. luku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. luku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna 4. luku: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna 5. luku: ");
            luvut[4] = int.Parse(Console.ReadLine());
            Array.Sort(luvut);
            Console.WriteLine("Suurin luku on: " + luvut[4]);
        }
        static void SyotettavaTieto()
        {
            Console.Write("Anna syötettävä tieto (i=kokonaisluku,d=double,m=merkkijono): ");
            string tieto = Console.ReadLine();
            Console.Write("Anna syötettävä arvo (numero tai merkkijono): ");
            string arvo = Console.ReadLine();
            switch (tieto)
            {
                case "i":
                    int iluku = int.Parse(arvo);
                    Console.WriteLine(iluku + 1);
                    break;
                case "d":
                    double dluku = double.Parse(arvo);
                    Console.WriteLine(dluku + 1);
                    break;
                case "m":
                    Console.WriteLine(arvo + "*");
                    break;
                default: Console.WriteLine("Et antanut oikeata valintaa (i, d, m)!");
                    break;
            }
        }
        static void Bonus()
        {
            Console.WriteLine("Anna Bonuspisteet (1-9): ");
            int bonus = int.Parse(Console.ReadLine());
            if(bonus <= 3)
            {
                Console.WriteLine("Pisteet ovat: " + bonus * 10);
            }
            else if (bonus <= 6)
            {
                Console.WriteLine("Pisteet ovat: " + bonus * 100);
            }
            else if(bonus <= 9) 
            {
                Console.WriteLine("Pisteet ovat: " + bonus * 1000);
            }
            else
            {
                Console.WriteLine("Et antanut lukua välillä 1-9!");
            }
        }
        static void LuvutSanoiksi()
        {
            {
                int numero;
            alkusana:
                Console.Write("Anna numero (0-999), jonka ohjelma muuntaa sanaksi: ");
                try
                {
                    numero = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi arvo ei ole kokonaisluku!");
                    goto alkusana;
                }
                if (numero > 999 || numero < 0)
                {
                    Console.WriteLine("Annoit luvun, joka ei ole välillä 0-999.");
                    goto alkusana;
                }
                else if (numero < 10)
                {
                    string ykkonen;
                    ykkonen = ykkoset(numero);
                    Console.WriteLine(ykkonen);
                }
                else if (numero < 20)
                {
                    string pkymmenen;
                    pkymmenen = poikkeuskymmenet(numero);
                    //pkymmenen = kymmenet(numero);
                    Console.WriteLine(pkymmenen);
                }
                else if (numero < 100)
                {
                    string kymmenen;
                    kymmenen = kymmenet(numero);
                    Console.WriteLine(kymmenen);
                }
                else if (numero < 1000)
                {
                    string sata;
                    sata = sadat(numero);
                    Console.WriteLine(sata);
                }
                static string ykkoset(int number)
                {
                    switch (number)
                    {
                        case 1:
                            return "Yksi";
                            break;
                        case 2:
                            return "Kaksi";
                            break;
                        case 3:
                            return "Kolme";
                            break;
                        case 4:
                            return "Neljä";
                            break;
                        case 5:
                            return "Viisi";
                            break;
                        case 6:
                            return "Kuusi";
                            break;
                        case 7:
                            return "Seitsemän";
                            break;
                        case 8:
                            return "Kahdeksan";
                            break;
                        case 9:
                            return "Yhdeksän";
                            break;
                        default:
                            return "Puppua";
                            break;
                    }
                }
                static string poikkeuskymmenet(int number)
                {
                    switch (number)
                    {
                        case 10:
                            return "Kymmenen";
                            break;
                        case 11:
                            return "Yksitoista";
                            break;
                        case 12:
                            return "Kaksitoista";
                            break;
                        case 13:
                            return "Kolmetoista";
                            break;
                        case 14:
                            return "Neljätoista";
                            break;
                        case 15:
                            return "Viisitoista";
                            break;
                        case 16:
                            return "Kuusitoista";
                            break;
                        case 17:
                            return "Seitsemäntoista";
                            break;
                        case 18:
                            return "Kahdeksantoista";
                            break;
                        case 19:
                            return "Yhdeksäntoista";
                            break;
                        default:
                            return "Puttu";
                            break;
                    }
                }
                static string kymmenet(int number)
                {
                    string x = Convert.ToString(number);
                    string eka = x.Substring(0, 1);
                    string toka = x.Substring(1, 1);
                    number = Int32.Parse(eka);
                    int toinen = Int32.Parse(toka);
                    string y = ykkoset(toinen);
                    switch (number)
                    {
                        case 2:
                            return "Kaksikymmentä " + y;
                            break;
                        case 3:
                            return "Kolmekymmentä " + y;
                            break;
                        case 4:
                            return "Neljäkymmentä " + y;
                            break;
                        case 5:
                            return "Viisikymmentä " + y;
                            break;
                        case 6:
                            return "Kuusikymmentä " + y;
                            break;
                        case 7:
                            return "Seitsemänkymmentä " + y;
                            break;
                        case 8:
                            return "Kahdeksankymmentä " + y;
                            break;
                        case 9:
                            return "Yhdeksänkymmentä " + y;
                            break;
                        default:
                            return "puppua";
                            break;
                    }

                }
                static string sadat(int number)
                {
                    string x = Convert.ToString(number);
                    string y;
                    string eka = x.Substring(0, 1);
                    string toka = x.Substring(1, 2);
                    string ptoka = x.Substring(1, 1);
                    number = Int32.Parse(eka);
                    int toinen = Int32.Parse(toka);
                    if (ptoka == "1")
                    {
                        y = poikkeuskymmenet(toinen);
                    }
                    else
                    {
                        y = kymmenet(toinen);
                    }
                    switch (number)
                    {
                        case 1:
                            return "Sata" + y;
                            break;
                        case 2:
                            return "Kaksisataa " + y;
                            break;
                        case 3:
                            return "Kolmesataa " + y;
                            break;
                        case 4:
                            return "Neljäsataa " + y;
                            break;
                        case 5:
                            return "Viisisataa " + y;
                            break;
                        case 6:
                            return "Kuusisataa " + y;
                            break;
                        case 7:
                            return "Seitsemänsataa " + y;
                            break;
                        case 8:
                            return "Kahdeksansata a" + y;
                            break;
                        case 9:
                            return "Yhdeksänsataa " + y;
                            break;
                        default:
                            return "puppua";
                            break;
                    }
                }
                Console.Write("Aloitetaanko alusta (k/e)?");
                string vastaus = Console.ReadLine();
                if (vastaus == "k" || vastaus == "K")
                {
                    goto alkusana;
                }
            }
        }
    }
}