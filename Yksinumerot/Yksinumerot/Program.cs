namespace Yksinumerot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Summa();
        }

        static void Summa()
        {
            Console.Write("Anna y:n arvo: ");
            string y = Console.ReadLine();
            int x = 3;
            int uusiy = int.Parse(y);
            Console.WriteLine("Tulos = " + (x + uusiy));
        }
    }
}