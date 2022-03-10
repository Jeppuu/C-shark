using System;

namespace Dia_69
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dian 69 harjoitukset\n");
            

            alku:
            Console.WriteLine("Minkä ohjelman haluat suorittaa?");
            Console.WriteLine("1. Iän kysyminen");
            Console.WriteLine("2. Toista annettu luku");
            Console.WriteLine("3. Sanan kirjainten vaihtaminen keskenään");
            Console.WriteLine("4. Kerro, onko annettu luku positiivinen vai negatiivinen");
            Console.WriteLine("5. Etsi annetun lauseen pisin sana");
            Console.WriteLine("6. Parittomien lukujen luetteleminen");
            Console.WriteLine("7. Kolmella jaollisten lukujen luetteleminen");

            int valinta;
            try
            {
                valinta = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Valitse luku 1-7!");
                goto alku;
            }
            switch (valinta)
            {
                case 1:
                    Kysyikaa();
                    break;
                case 2:
                    Tulostaluku();
                    break;
                case 3:
                    Vaihdakirjain();
                    break;
                case 4:
                    Positiivisiako();
                    break;
                case 5:
                    Lauseenpisinsana();
                    break;
                case 6:
                    Parittomatluvut();
                    break;
                case 7:
                    Kolmellajaolliset();
                    break;
                default:
                    Console.WriteLine("Virhe! Valitse luku 1-7!");
                    goto alku;
            }
            //kysytään haluaako käyttäjä kokeilla toista ohjelmaa
            toinenohjelmaAlku:
            Console.WriteLine("\nHaluatko suorittaa toisen ohjelman? (k/e)");
            string vastaus = Console.ReadLine();
            switch (vastaus)
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
            //HARJOITUS 11

            public static void Kysyikaa ()
        {
            int ika;
            Console.Clear();
            Console.WriteLine("Hei! Kuinka vanha sinä olet?"); //kysytään käyttäjän ikää
            ikaAlku:
            Console.Write("ikäni on: ");

            try
            {
                ika = int.Parse(Console.ReadLine()); //varmistetaan että ikä ilmoitetaan kokonaislukuna
            }
            
            catch
            {
                Console.WriteLine("Virhe! Kerro ikäsi numeromuodossa.");
                goto ikaAlku;
            }
            if (ika <= 0 || ika > 150) //varmistetaan ettei ikä ole mahdottoman pieni tai suuri
            {
                Console.WriteLine("Eihän tämä ole oikea ikä. Olepas rehellinen!");
                goto ikaAlku;
            }
            Console.WriteLine("{0} – näytät ikäistäsi nuoremmalta!", ika); //tulostetaan viesti käyttäjälle

            //uudestaan?
            uudestaanAlku:
            Console.WriteLine("\nHaluatko antaa nimen uudestaan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto ikaAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }

        }

        //HARJOITUS 12

        public static void Tulostaluku ()
        {
            int luku;
            Console.Clear();
            Console.WriteLine("Anna luku, joka on suurempi kuin kymmenen, niin tulostan sen yhtä monta kertaa.");
            tulostalukuAlku:
            try
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
            }
            catch                                                                   //_______________
            {
                Console.WriteLine("Virhe! Luvun tulee olla kokonaisluku!");         //  virheiden
                goto tulostalukuAlku;                                               //  ennakointia
            }                                                                       //      ja
            if (luku < 10)                                                          //  korjausta
            {                                                                       //_______________
                Console.WriteLine("Ei käy! Anna luku, joka on isompi kuin 10.");
                goto tulostalukuAlku;
            } 

            //tehdään looppi joka tulostaa luvun

            for (int i = 0; i < luku; i++)      // <-- ensimmäinen loop
            {
                for (int j = 0; j < luku; j++)  // <-- toinen loop määrittää tulostamaan luvun ja välilyönnin x kertaa
                {
                    Console.Write(luku + " ");
                }
                Console.WriteLine();            //<-- ensimmäinen loop hoitaa tulostuksen
                for (int k = 0; k < luku; k++)  //<-- kolmas loop määrää tulostamaan luvun ilman välilyöntiä x kertaa
                {
                    Console.Write(luku);
                }
                Console.WriteLine();            // <-- ensimmäinen loop hoitaa tulostuksen
            }

            //uudestaan?
            uudestaanAlku:
            Console.WriteLine("\nTulostetaanko uusi luku? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto tulostalukuAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }

        }

        //HARJOITUS 13

        public static void Vaihdakirjain ()
        {
            string sana, uusiSana;
            Console.Clear();
            Console.WriteLine("Anna jokin sana, niin vaihdan sen ensimmäisen ja viimeisen kirjaimen keskenään.");
            vaihdakirjainAlku:

            Console.Write("Anna jokin sana: "); //pyydetään käyttäjältä sana
            sana = Console.ReadLine();

            bool vainSana = sana.Contains(" "); //tarkistetaan, että sanoja on vain yksi
            if (vainSana == true)               // eli välilyöntejä ei saa olla
            {
                Console.WriteLine("Anna vain yksi sana! Välilyönnit eivät ole sallittuja.");
                goto vaihdakirjainAlku;
            }
            //kirjainten järjestyksen vaihto

            char[] arr = new char[sana.Length];
            for (int i = 0; i < sana.Length;i++) //loop käy läpi kaikki sanan kirjaimet
            {
                arr[i] = sana[i];
            }
            arr[0] = sana[sana.Length - 1]; // ensimmäinen kirjain siirtyy viimeisen paikalle
            arr[sana.Length - 1] = sana[0]; // viimeinen kirjain siirtyy ensimmäisen paikalle
            uusiSana = String.Join("", arr);

            Console.WriteLine("Kun sanan {0} kirjaimet vaihtavat paikkaa, siitä tulee {1}!", sana, uusiSana);

            //uudestaan?
            uudestaanAlku:
            Console.WriteLine("\nHaluatko antaa uuden sanan? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto vaihdakirjainAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }
        
       //HARJOITUS 14

        public static void Positiivisiako ()
        {
            int x, y;
            Console.Clear();
            Console.WriteLine("Anna kaksi kokonaislukua, niin kerron ovatko ne positiivisia vai negatiivisia!");
            positiivisiakoAlku:
            try
            {
                Console.Write("Anna ensimmäinen luku: ");   //pyydetään käyttäjältä luvut
                x = int.Parse(Console.ReadLine());          //ja varmistetaan että ne ovat
                Console.Write("Anna toinen luku: ");        //kokonaislukuja
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Virhe! Lukujen tulee olla kokonaislukuja.");
                goto positiivisiakoAlku;
            }
            if (x > 0 && y > 0) //jos molemmat ovat positiivisia
            {
                Console.WriteLine("Molemmat luvut ovat positiivisia.");
            }
            else if ( x > 0 || y > 0) //jos toinen on positiivinen
            {
                Console.WriteLine("Toinen luvuista on positiivinen ja toinen negatiivinen.");
            }
            else // jos molemmat ovat negatiivisia
            {
                Console.WriteLine("Molemmat luvut ovat negatiivisia.");
            }
            //uudestaan?
            uudestaanAlku:
            Console.WriteLine("\nHaluatko antaa uudet luvut? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto positiivisiakoAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //15 HARJOITUS

        public static void Lauseenpisinsana ()
        {
            string lause;
            Console.Clear();
            pisinsanaAlku:
            Console.WriteLine("Kirjoita jokin lause, niin kerron sinulle lauseen pisimmän sanan.");
            Console.Write("Anna lause: ");
            lause = Console.ReadLine(); //pyydetään käyttäjältä lause

            string[] arr = lause.Split(' ');    //muutetaan se arrayksi

            string pisin = arr[0];              //määritetään ensimmäinen sana suurimmaksi
            for (int i = 1; i < arr.Length; i++)//ja käynnistetään loop
            {
                if(arr[i].Length > pisin.Length) //loop jatkuu kunnes isoin arvo löytyy
                {
                    pisin = arr[i];             //määritetään pisin löydetty sana muuttujaan
                }
            }
            Console.WriteLine("Lauseen pisin sana on {0}", pisin);

            //uudestaan?
            uudestaanAlku:
            Console.WriteLine("\nHaluatko antaa uuden lauseen? k/e");
            string uudestaan = Console.ReadLine();
            switch (uudestaan)
            {
                case "k":
                    goto pisinsanaAlku;
                case "e":
                    break;
                default:
                    Console.WriteLine("kirjoita joko k (kyllä) tai e (ei)!");
                    goto uudestaanAlku;
            }
        }

        //16 HARJOITUS

        public static void Parittomatluvut ()
        {
            Console.WriteLine("Parittomia lukuja välillä 1-99 ovat:");

            for(int i = 1; i <= 99; i+=2)   //loop etsii kahdella jaolliset luvut < 99
            {
                Console.Write(i + " ");     //.. ja ne kirjaantuvat konsoliin
            }
            Console.WriteLine();
        }

        //17 HARJOITUS

        public static void Kolmellajaolliset ()
        {
            Console.WriteLine("Kolmella jaolliset luvut välillä 1-99 ovat:");

            for (int i = 1; i <= 99; i += 3)   //loop etsii kolmella jaolliset luvut < 99
            {
                Console.Write(i + " ");     //.. ja ne kirjaantuvat konsoliin
            }
            Console.WriteLine();
        }

    }
}
