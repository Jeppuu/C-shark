using System;

namespace Dia_24_harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            //HARJOITUS 1

            int luku1, luku2; //määäritetään muuttujat luvuille
            Console.WriteLine("Syötä jokin kokonaisluku:");
            luku1 = int.Parse(Console.ReadLine()); //pyydetään ensimmäinen luku ja luetaan se

            Console.WriteLine("Syötä toinen kokonaisluku:");
            luku2 = int.Parse(Console.ReadLine()); //sama toiselle luvulle

            if (luku1 > luku2)
            {
                Console.WriteLine(luku2 + " " + luku1); //jos ensimmäinen luku on suurempi, se tulostetaan ensin
            }
            else
            {
                Console.WriteLine(luku1 + " " + luku2); //jos toinen luku on suurempi, se tulostetaan ensin
            }

            //HARJOITUS 2

            int a, b, c;

            Console.WriteLine("\nJos syötät kolme kokonaislukua, tulostan sinulle niistä suurimman.");
            Console.WriteLine("Syötä ensimmäinen kokonaisluku:");
            a = int.Parse(Console.ReadLine()); //luetaan 1. luku

            Console.WriteLine("Syötä toinen kokonaisluku:");
            b = int.Parse(Console.ReadLine()); //luetaan 2. luku

            Console.WriteLine("Syötä kolmas kokonaisluku:");
            c = int.Parse(Console.ReadLine()); //luetaan 3. luku

            if(a > b && a > c) //jos 1. luku on suurin
            {
                Console.WriteLine("Luvuista suurin on " + a);
            } else if(b > a && b > c) //jos 2. luku on suurin
                    {
                Console.WriteLine("Luvuista suurin on " + b);
            } else //jos 3. luku on suurin
            {
                Console.WriteLine("Luvuista suurin on " + c);
            }

            //HARJOITUS 3

            Console.WriteLine("\nSyötä seuraavaksi luku 1-9 niin kirjoitan sen sinulle sanana!");
            alku: //jos syötetty numero ei ole sopiva, ohjelma palaa tähän kohtaan
            Console.WriteLine("Syötä luku 1-9:");
            int numero = int.Parse(Console.ReadLine()); //luetaan annettu numero

            switch(numero) //käydään läpi numerot 1-9 ja kirjoitetaan ne sanana
            {
                case 1:
                    Console.WriteLine("Yksi");
                    break;
                case 2:
                    Console.WriteLine("Kaksi");
                    break;
                case 3:
                    Console.WriteLine("kolme");
                    break;
                case 4:
                    Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("kuusi");
                    break;
                case 7:
                    Console.WriteLine("seitsemän");
                    break;
                case 8:
                    Console.WriteLine("kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("yhdeksän");
                    break;
                default: //jos luku ei ole 1-9, annetaan virheviesti ja palataan pyytämään uusi numero
                    Console.WriteLine("Syöte virheellinen. Syötä luku 1-9 väliltä!");
                    goto alku;

            }

            //HARJOITUS 4

            Console.WriteLine("\nSyötä seuraavaksi 5 kokonaislukua, niin tulostan niistä suurimman.");

            //luetaan syötetyt luvut
            Console.WriteLine("Anna ensimmäinen luku:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kolmas luku:");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna neljäs luku:");
            int n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna viides luku:");
            int n5 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5) //jos ensimmäinen luku on suurempi kuin muut
            {
                Console.WriteLine(n1 + " on luvuista suurin.");
            } else if (n2 > n3 && n2 > n4 && n2 > n5) // jos toinen luku on suurempi kuin muut
            {
                Console.WriteLine(n2 + " on luvuista suurin."); 
            } else if (n3 > n4 && n3 > n5) //jos kolmas luku on suurempi kuin muut
            {
                Console.WriteLine(n3 + " on luvuista suurin.");
            } else if (n4 > n5) // jos neljäs luku on suurempi kuin muut
            {
                Console.WriteLine(n4 + " on luvuista suurin.");
            } else //tässä tapauksessa viidennen luvun on oltava suurin (koska mikään muu ei ole sitä suurempi)
            {
                Console.WriteLine(n5 + " on luvuista suurin.");
            }

            //HARJOITUS 5

            int kokonaisluku;
            double doubleLuku;
            string merkkijono, syote; // määritellään muuttujat
            syottoalku:
            Console.WriteLine("\nKerro seuraavaksi, haluatko syöttää kokonaisluvun, doubleluvun vai merkkijonon.");
            syote = Console.ReadLine();

            if (syote == "kokonaisluvun" || syote == "doubleluvun" || syote == "merkkijonon") //tarkistetaan että syöte on oikeassa muodossa
            {
                switch(syote)
                {
                    case "kokonaisluvun": //pyydetään käyttäjältä kokonaisluku ja lisätään siihen 1
                        intalku:
                        Console.WriteLine("Syötä kokonaisluku:");
                        try
                        {
                            kokonaisluku = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Anatamasi luku on " + kokonaisluku + " ja kun siihen lisätään 1, saadaan tulokseksi " + (kokonaisluku + 1));

                        } catch (Exception e) //jos syöte ei ole kokonaisluku, ilmoitetaan virheestä
                        {
                            Console.WriteLine("Sinun täytyy syöttää kokonaisluku!");
                            goto intalku; // ...ja palataan pyytämään lukua uudelleen
                        }
                        break;

                    case "doubleluvun":
                            doublealku:
                        Console.WriteLine("Syötä doubleluku:"); //jos käyttäjä valitsee doubleluvun, lisätään siihenkin yksi
                        try
                        {
                            doubleLuku = Double.Parse(Console.ReadLine());
                            Console.WriteLine(" Anatamasi luku on " + doubleLuku + " ja kun siihen lisätään 1, saadaan tulokseksi " + (doubleLuku + 1));

                        } catch (Exception e)
                        {
                            Console.WriteLine("Sinun täytyy syöttää doubleluku!");
                            goto doublealku; // .. ja palataan takaisin jos syöte ei ole doubleluku
                        }
                        break;

                    case "merkkijonon": // pyydetään käyttäjältä merkkijono ja lisätään sen perään tähti
                        Console.WriteLine("Syötä merkkijono");
                        merkkijono = Console.ReadLine();
                        merkkijono += "*";
                        Console.WriteLine("Kun antamaasi merkkijonoon lisätään *, siitä syntyy " + merkkijono + "!");
                        break;

                    default:
                        Console.WriteLine("Virhe!");
                        break;
                }
            } else //jos käyttäjän syöte on väärässä muodossa, ilmoitetaan virheestä ja pyydetään uusi syöte
            {
                Console.WriteLine("Syötteesi oli virheellinen. Kirjoita joko 'kokonaisluvun', 'doubleluvun' tai 'merkkijonon'!");
                goto syottoalku;
            }

            //HARJOITUS 6

            int pisteet, bonus;
            bonusalku:
            Console.WriteLine("\nSyötä pisteiden määrä (välillä 1-9):");
            pisteet = int.Parse(Console.ReadLine()); //luetaan käyttäjän antamat pisteet

            switch(pisteet)
            {
                case 1: //jos pisteiden määrä on 1-3 kerrotaan pisteet kymmenellä
                case 2:
                case 3:
                    bonus = pisteet * 10;
                    Console.WriteLine("Bonusten jälkeen sinulla on " + bonus + " pistettä!");
                    break;
                case 4: //jos pisteiden määrä on 4-6 kerrotaan pisteet sadalla
                case 5:
                case 6:
                    bonus = pisteet * 100;
                    Console.WriteLine("Bonusten jälkeen sinulla on " + bonus + " pistettä!");
                    break;
                case 7: //jos pisteiden määrä on 7-9 kerrotaan pisteet tuhannella
                case 8:
                case 9:
                    bonus = pisteet * 1000;
                    Console.WriteLine("Bonusten jälkeen sinulla on " + bonus + " pistettä!");
                    break;
                default: //jos pisteiden määrä ei ole 1-9 tulostetaan virhe ja pyydetään lukua uudestaan
                    Console.WriteLine("Virheellinen syöte! Syötä luku 1-9 väliltä.");
                    goto bonusalku;
            }

            //HARJOITUS 7 <-- ohjelma toimii vain luvuilla 1-19 

            numeroalku:
            Console.WriteLine("\nSyötä numero 1-999 väliltä, niin se tulostuu sanana.");
            int numerossi = int.Parse(Console.ReadLine()); //luetaan käyttäjän syöttämä numero

            if (numerossi > 999 || numerossi < 0)
            {
                Console.WriteLine("Syöttämäsi luku täytyy olla 1-999 väliltä!");
                goto numeroalku; //jos luku ei ole väliltä 1-999, palataan alkuun
            }
            else if (numerossi < 10)
            {
                string ykkonen = ykkoset(numerossi);
                Console.WriteLine(ykkonen);
            }
            else if (numerossi < 20)
            {
                string poikkeus = poikkeusKympit(numerossi);
                Console.WriteLine(poikkeus);
            }
            else if (numerossi < 100)
            {
                string kymppi = kympit(numero);
                Console.WriteLine(kymppi);
            }
            else if (numerossi < 1000)
            {
                string sata = sadat(numerossi);
                Console.WriteLine(sata);
            }
            static string ykkoset(int number)
            {
                switch(number) //sanoitetaan ykkösluvut
                {
                    case 1:
                        return "yksi";
                        break;
                    case 2:
                        return "kaksi";
                        break;
                    case 3:
                        return "kolme";
                        break;
                    case 4:
                        return "neljä";
                        break;
                    case 5:
                        return "viisi";
                        break;
                    case 6:
                        return "kuusi";
                        break;
                    case 7:
                        return "seitsemän";
                        break;
                    case 8:
                        return "kahdeksan";
                        break;
                    case 9:
                        return "yhdeksän";
                        break;
                    default:
                        return "blaah";
                        break;

                }
            }
            static string poikkeusKympit(int number)
            {
                switch(number) //sanoitetaan "poikkeusluvut"
                {
                    case 10:
                        return "kymmenen";
                        break;
                    case 11:
                        return "yksitoista";
                        break;
                    case 12:
                        return "kaksitoista";
                        break;
                    case 13:
                        return "kolmetoista";
                        break;
                    case 14:
                        return "neljätoista";
                        break;
                    case 15:
                        return "viisitoista";
                        break;
                    case 16:
                        return "kuusitoista";
                        break;
                    case 17:
                        return "seitsemäntoista";
                        break;
                    case 18:
                        return "kahdeksantoista";
                        break;
                    case 19:
                        return "yhdeksäntoista";
                        break;
                    default:
                        return "blööh";
                        break;
                }
            }
            static string kympit(int number)
            {
                string x = Convert.ToString(number);
                string eka = x.Substring(0, 1);
                string toka = x.Substring(1, 1); //TÄSSÄ ERROR !?
                number = Int32.Parse(eka);
                int toinen = Int32.Parse(toka);
                string y = ykkoset(toinen);

                switch(number) //sanoitetaan kympit ja lisätään niihin ykköset
                {
                    case 2:
                        return "kaksikymmentä " + y;
                        break;
                    case 3:
                        return "kolmekymmentä " + y;
                        break;
                    case 4:
                        return "neljäkymmentä " + y;
                        break;
                    case 5:
                        return "viisikymmentä " + y;
                        break;
                    case 6:
                        return "kuusikymmentä " + y;
                        break;
                    case 7:
                        return "seitsemänkymmentä " + y;
                        break;
                    case 8:
                        return "kahdeksankymmentä " + y;
                        break;
                    case 9:
                        return "yhdeksänkymmentä " + y;
                        break;
                    default:
                        return "bluuh";
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
                if(ptoka == "1")
                {
                    y = poikkeusKympit(toinen); //jos luku on 10-19
                }
                else
                {
                    y = kympit(toinen);
                }
                switch (number) //sanoitetaan sadat
                {
                    case 1:
                        return "sata" + y;
                        break;
                    case 2:
                        return "kaksisataa " + y;
                        break;
                    case 3:
                        return "kolmesataa " + y;
                        break;
                    case 4:
                        return "neljäsataa " + y;
                        break;
                    case 5:
                        return "viisisataa " + y;
                        break;
                    case 6:
                        return "kuusisataa " + y;
                        break;
                    case 7:
                        return "seitsemänsataa " + y;
                        break;
                    case 8:
                        return "kahdeksansataa " + y;
                        break;
                    case 9:
                        return "yhdeksänsataa " + y;
                        break;
                    default:
                        return "bleeh";
                        break;
                }
            }
        }



    }
}
