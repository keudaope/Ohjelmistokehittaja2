namespace Dia72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ika();
            //Toisto();
            //SananKaanto();
            //Etumerkit();
            //PisinSana();
            //Parittomat();
            KolmellaJaolliset();
        }
        static void Ika()
        {
            Console.Write("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta!", ika);
        }
        static void Toisto()
        {
            Console.Write("Anna 10 suurempi kokonaisluku: ");
            int luku = int.Parse(Console.ReadLine());
            int luku1 = luku;
            for (int i = 0; i < luku; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < luku1; j++)
                {
                    Console.Write(luku1 + " ");
                }
                Console.WriteLine();
                for (int k = 0; k < luku1; k++)
                {
                    Console.Write(luku1);
                }
            }
        }
        static void SananKaanto()
        {
            Console.Write("Anna sana, joka käännetään toisinpäin: ");
            string sana = Console.ReadLine();
            for (int i = sana.Length; i > 0; i--)
            {
                Console.Write(sana[i-1]);
            }
        }
        static void Etumerkit()
        {
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if(luku1 >= 0 && luku2 >= 0)
            {
                Console.WriteLine("Molemmat luvut ovat positiivisia");
            }
            else if(luku1 < 0 && luku2 < 0)
            {
                Console.WriteLine("Molemmat luvut ovat negatiivisia");
            }
            else
            {
                Console.WriteLine("Toinen luku on positiivinen ja toinen negatiivinen!");
            }
        }
        static void PisinSana()
        {
            Console.Write("Anna lause, josta pisin sana etsitään: ");
            string lause = Console.ReadLine();
            string[] sanat = lause.Split(" ");
            string suurin = sanat[0];
            for(int i = 1; i< sanat.Length; i++)
            {
                if (sanat[i].Length > sanat[i-1].Length)
                {
                    suurin = sanat[i];
                }
            }
            Console.WriteLine("Lauseen \'{0}\' pisin sana on \'{1}\'", lause, suurin);
        }
        static void Parittomat()
        {
            for(int i = 1; i < 100; i+=2)
            {
                Console.Write(i + " ");
            }
        }
        static void KolmellaJaolliset()
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.Write(i + " ");
            }
        }
    }

}