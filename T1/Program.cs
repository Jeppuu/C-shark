using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ohjelma laskee x ja y summan
            string x, y;
            int summa;
            Console.WriteLine("Tehdään ensin helppo pluslasku!");
            Console.WriteLine("Anna x:lle jokin arvo:");
            x = Console.ReadLine();
            Console.WriteLine("Kiitos! Anna seuraavaksi y:lle arvo:");
            y = Console.ReadLine();
            summa = Int32.Parse(x) + Int32.Parse(y);
            Console.WriteLine("Näiden lukujen summa on " + summa + "!");

            //ohjelma laskee x ja y erotuksen

            int erotus;
            Console.WriteLine(" \nOkei! Seuraavaksi lasketaan miinuslasku.");
            Console.WriteLine("Anna taas x:lle arvo:");
            x = Console.ReadLine();
            Console.WriteLine("Kiitos! Anna vielä y:lle arvo:");
            y = Console.ReadLine();
            erotus = Int32.Parse(x) - Int32.Parse(y);
            Console.WriteLine("Näiden lukujen erotus on " + erotus + "!");

            //ohjelma laskee x ja y tulon

            int tulo;
            Console.WriteLine("\nEntäs sitten kertolasku?");
            Console.WriteLine("Anna x:lle arvo:");
            x = Console.ReadLine();
            Console.WriteLine("Kiitos! Anna vielä y:lle arvo:");
            y = Console.ReadLine();
            tulo = Int32.Parse(x) * Int32.Parse(y);
            Console.WriteLine("Näiden lukujen tulo on " + tulo + "!");

            //ohjelma laskee x ja y osamäärän

            int osamaara;
            Console.WriteLine("\nHyvin sujuu! Miten olisi vielä jakolasku?");
            Console.WriteLine("Anna jälleen x:lle arvo:");
            x = Console.ReadLine();
            Console.WriteLine("Jes! Anna vielä y:lle arvo:");
            y = Console.ReadLine();
            osamaara = Int32.Parse(x) / Int32.Parse(y);
            Console.WriteLine("Näiden lukujen osamäärä on " + osamaara + "!");

            //ohjelma laskee x ja y jakojäännöksen

            int jakojaannos;
            Console.WriteLine("\nSiistiä! Oletko kuullut jakojäänteestä? Lasketaan vielä se.");
            Console.WriteLine("Anna x:lle vielä yksi arvo:");
            x = Console.ReadLine();
            Console.WriteLine("Jes! Anna vielä y:lle arvo:");
            y = Console.ReadLine();
            jakojaannos = Int32.Parse(x) % Int32.Parse(y);
            Console.WriteLine("Näiden lukujen jakojäännös on " + jakojaannos + "!");
            Console.WriteLine("Kiitos kun laskit kanssani!");
        }
    }
}
