namespace Dia71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yhteenlasku(3, 5);
            //CelsiusToFahrenheit(0);
            //Peruslaskutoimitukset(8, 5);
            //Jakojaannos(5, 2);
            //Heippa();
            //Kyhteenlasku();
            //KCToF();
            //KPeruslaskut();
            //KJakoj();
            Kertotaulu();
        }
        static void Yhteenlasku(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        static void CelsiusToFahrenheit(int x)
        {
            Console.WriteLine("{0} Celsiusta on {1} Fahrenheitia", x, x * 1.8 + 32);
        }
        static void Peruslaskutoimitukset(int x, double y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
        static void Jakojaannos(int x, int y)
        {
            Console.WriteLine("{0} ja {1} jakojäännös on {2}", x, y, x % y);
        }
        static void Heippa()
        {
            Console.Write("Anna nimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei, {0}", nimi);
        }
        static void Kyhteenlasku()
        {
            Console.Write("Anna 1. yhteenlaskettava luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. yhteenlaskettava luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, luku1+luku2);
        }
        static void KCToF()
        {
            Console.Write("Anna Celsiusasteet: ");
            double Celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} Celsiusta on {1} Fahrenheitia", Celsius, Celsius * 1.8 + 32);
        }
        static void KPeruslaskut()
        {
            Console.Write("Anna 1. luku, jolle tehdään kaikki peruslaskutoimitukset: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku, jolle tehdään kaikki peruslaskutoimitukset: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
        static void KJakoj()
        {
            Console.Write("Anna suurempi luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna pienempi luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ja {1} jakojäännös on {2}", luku1, luku2, luku1 % luku2);
        }
        static void Kertotaulu()
        {
            Console.Write("Anna perusluku, jonka kertotaulun tulostan: ");
            int pluku = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * 1 = {1}", pluku, pluku * 1);
            Console.WriteLine("{0} * 2 = {1}", pluku, pluku * 2);
            Console.WriteLine("{0} * 3 = {1}", pluku, pluku * 3);
            Console.WriteLine("{0} * 4 = {1}", pluku, pluku * 4);
            Console.WriteLine("{0} * 5 = {1}", pluku, pluku * 5);
            Console.WriteLine("{0} * 6 = {1}", pluku, pluku * 6);
            Console.WriteLine("{0} * 7 = {1}", pluku, pluku * 7);
            Console.WriteLine("{0} * 8 = {1}", pluku, pluku * 8);
            Console.WriteLine("{0} * 9 = {1}", pluku, pluku * 9);
            Console.WriteLine("{0} * 10 = {1}", pluku, pluku * 10);
        }
    }
}