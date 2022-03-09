using System;

namespace Dia_68
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dian 68 harjoitukset 1-10 \n");
            //LaskeYhteen();
            //CelsiusFarenheit();
            //Peruslaskut();
            //Jakojaannos();
            //Tervehdinimea();
            //Helppoyhteenlasku(3, 5);
            //Helppocelsius(10);
            //Helppoperuslaskut(8, 5);
            //Helppojakojaannos(5, 2);
            //Kertotaulu();
            alku:
            Console.WriteLine("Minkä ohjelman haluat suorittaa?");
            Console.WriteLine("1. Laske kaksi annettua lukua yhteen");
            Console.WriteLine("2. Muunna annettu celsiusaste farenheiteiksi");
            Console.WriteLine("3. Peruslaskut kahdella annetulla luvulla");
            Console.WriteLine("4. Laske jakojäännös kahdella annetulla luvulla");
            Console.WriteLine("5. Tervehdi annettua nimeä");
            Console.WriteLine("6. Laske yhteen valmiilla luvuilla");
            Console.WriteLine("7. Muunna valmiit celsiusasteet fahrenfeiteiksi");
            Console.WriteLine("8. Laske paruslaskut valmiilla luvuilla");
            Console.WriteLine("9. Laske jakojäännös valmiilla luvuila");
            Console.WriteLine("10. Laske Annetun luvun kertotaulu");
            int valinta;
            try
            {
                valinta = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Valitse luku 1-10!");
                goto alku;
            }
            switch (valinta)
            {
                case 1:
                    LaskeYhteen();
                    break;
                case 2:
                    CelsiusFarenheit();
                    break;
                case 3:
                    Peruslaskut();
                    break;
                case 4:
                    Jakojaannos();
                    break;
                case 5:
                    Tervehdinimea();
                    break;
                case 6:
                    Helppoyhteenlasku(3, 5);
                    break;
                case 7:
                    Helppocelsius(10);
                    break;
                case 8:
                    Helppoperuslaskut(8, 5);
                    break;
                case 9:
                    Helppojakojaannos(5, 2);
                    break;
                case 10:
                    Kertotaulu();
                    break;
                default:
                    Console.WriteLine("Virhe!");
                    goto alku;

            }
            //kysytään haluaako käyttäjä kokeilla toista ohjelmaa
            toinenohjelmaAlku:
            Console.WriteLine("Haluatko suorittaa toisen ohjelman? (k/e)");
            string vastaus = Console.ReadLine();
            switch(vastaus)
            {
                case "k":
                    goto alku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                goto toinenohjelmaAlku;
            }
        }
        // HARJOITUS 1
        public static void LaskeYhteen()
        {
            int x, y, summa;
            Console.WriteLine("Anna kaksi lukua, niin lasken ne yhteen.");
            laskeyhteenAlku:
            try
            {
                Console.Write("Anna ensimmäinen luku:");
                x = int.Parse(Console.ReadLine());
                Console.Write("Anna toinen luku:");
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Syötä kokonaisluku!");
                goto laskeyhteenAlku;
            }
            
            summa = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, summa);

            //kysytään haluaako käyttäjä laskea uudestaan
            uudestaanAlku:
            Console.WriteLine("Lasketaanko uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto laskeyhteenAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //HARJOITUS 2
        public static void CelsiusFarenheit()
        {
            double celsius, farenheit;
            Console.WriteLine("Anna celsiusasteiden määrä, niin muunnan ne farenheiteiksi.");
            celsiusfarenheiteiksiAlku:
            try
            {
                Console.Write("celsiusasteet:");
                celsius = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Syötä pelkkä luku, tai erota desimaali pilkulla.");
                goto celsiusfarenheiteiksiAlku;
            }
            farenheit = celsius * 1.8 + 32;
            Console.WriteLine("{0} celsiusastetta tekee {1} farenheit astetta!", celsius,farenheit);

            //kysytään haluaako käyttäjä laskea uudestaan
            uudestaanAlku:
            Console.WriteLine("Lasketaanko uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto celsiusfarenheiteiksiAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //HARJOITUS 3
        public static void Peruslaskut ()
        {
            double x, y;
            Console.WriteLine("Anna kaksi lukua, niin lasken niillä peruslaskutoimitukset.");
            peruslaskutAlku:
            try
            {
                Console.Write("Anna ensimmäinen luku:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Anna toinen luku:");
                y = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Syötä pelkkiä lukuja.");
                goto peruslaskutAlku;
            }
            Console.WriteLine("{0} + {1} = " + (x+y), x,y);
            Console.WriteLine("{0} - {1} = " + (x-y), x, y);
            Console.WriteLine("{0} * {1} = " + (x*y), x, y);
            Console.WriteLine("{0} / {1} = " + (x/y), x, y);
            Console.WriteLine("{0} % {1} = " + (x%y), x, y);

            //kysytään haluaako käyttäjä laskea uudestaan
            uudestaanAlku:
            Console.WriteLine("Lasketaanko uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto peruslaskutAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //HARJOITUS 4

        public static void Jakojaannos()
        {
            double x, y;
            Console.WriteLine("Anna kaksi lukua, niin lasken niiden jakojäännöksen.");
            jakojaannosAlku:
            try
            {
                Console.Write("Anna ensimmäinen luku:");
                x = double.Parse(Console.ReadLine());
                Console.Write("Anna toinen luku:");
                y = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Syötä pelkkiä lukuja.");
                goto jakojaannosAlku;
            }
            Console.WriteLine("{0} % {1} = " + (x % y), x, y);


            //kysytään haluaako käyttäjä laskea uudestaan
            uudestaanAlku:
            Console.WriteLine("Lasketaanko uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto jakojaannosAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //HARJOITUS 5

        public static void Tervehdinimea()
        {
            Console.WriteLine("Kerro nimesi, niin tervehdin sinua!");
            string nimi;
            nimiAlku:
            try
            {
                Console.Write("Nimesi:");
                nimi = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Eikai tuo sinun nimesi ole? Yritähän uudestaan.");
                goto nimiAlku;
            }
            Console.WriteLine("Hei {0}!", nimi);
        }

        //HARJOITUS 6 (HOX! väärässä järjestyksessä. Tämä vastaa harjoitusta 1)

        public static void Helppoyhteenlasku (int x, int y)
        {
            Console.WriteLine("{0} + {1} = " + (x + y), x, y);
        }

        //HARJOITUS 7 (HOX! vastaa tehtävää 2)

        public static void Helppocelsius (double celsius)
        {
            double farenheit = celsius * 1.8 + 32;
            Console.WriteLine("{0} celsiusastetta tekee {1} farenheit astetta!", celsius, farenheit);
        }

        //HARJOITUS 8 (HOX! Vastaa tehtävää 3)

        public static void Helppoperuslaskut (double x, double y)
        {
            Console.WriteLine("{0} + {1} = " + (x + y), x, y);
            Console.WriteLine("{0} - {1} = " + (x - y), x, y);
            Console.WriteLine("{0} * {1} = " + (x * y), x, y);
            Console.WriteLine("{0} / {1} = " + (x / y), x, y);
            Console.WriteLine("{0} % {1} = " + (x % y), x, y);
        }

        //HARJOITUS 9 (HOX! Vastaa tehtävää 4)

        public static void Helppojakojaannos (double x, double y)
        {
            Console.WriteLine("{0} % {1} = " + (x % y), x, y);
        }

        // HARJOITUS 10

        public static void Kertotaulu ()
        {
            int luku;
            Console.WriteLine("Anna luku 1-10 niin lasken sen kertotaulun!");
            kertotauluAlku:
            Console.Write("Anna luku 1-10: ");

            try
            {
                luku = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Anna kokonaisluku 1-10 väliltä!");
                goto kertotauluAlku;
            }
            if (luku > 10 || luku <= 0)
            {
                Console.WriteLine("Ei käy! Luvun on oltava väliltä 1-10!");
                goto kertotauluAlku;
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = " + (luku * i), luku, i);
            }

            //kysytään haluaako käyttäjä laskea uudestaan
            uudestaanAlku:
            Console.WriteLine("Lasketaanko uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto kertotauluAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

    }
}
