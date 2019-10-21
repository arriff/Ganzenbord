using System;
using System.Collections.Generic;
using System.Text;

namespace Ganzenbord
{
    public class Spelbord
    {
        public static bool gameStatus = true;


        public void spelregels(List<Speler> spelers, Speler spelerActief)
        {
            if (spelerActief.Put == false)
            {
                switch (spelerActief.Positie)
                {
                    case 6:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Brug, ga verder naar 12");
                        spelerActief.Positie = 12;
                        break;
                    case 19:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Herberg, een beurt overslaan");
                        spelerActief.Beurten++;
                        Console.WriteLine("totaal over te slaan beurt: " + spelerActief.Beurten);
                        break;
                    case 23:                                                            //bij positie 23
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Gevangenis!, Het spel is over voor " + spelerActief.Naam);
                        spelerActief.Status = false;
                        break;
                    case 25:
                    case 45:                                                   //bij positie 25 en 45
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": terug naar start.");
                        spelerActief.Positie = 0;                                            //positie terug gezet naar 0
                        break;
                    case 42:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": terug naar 39.");
                        spelerActief.Positie = 39;
                        break;
                    case 31:
                        Console.WriteLine(spelerActief.Naam + " zit in de put");
                        foreach (Speler speler in spelers)
                        {
                            if (speler.Put)
                            {
                                speler.Put = false;
                                Console.WriteLine(speler.Naam + " >>>>is uit de put");
                            }
                        }
                        spelerActief.Put = true;
                        break;
                    case 53:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": drie beurten overslaan");
                        spelerActief.Beurten += 3;
                        Console.WriteLine("totaal over te slaan beurt: " + spelerActief.Beurten);
                        break;
                    case 58:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Je bent dood en start weer op positie 0");
                        spelerActief.Positie = 0;                                            //positie terug gezet naar 0
                        break;
                    case int x when (x % 10 == 0):                                      //bij positie 10,20,30,40,50,60 etc
                        Console.WriteLine("gelopen naar positie " + spelerActief.Positie);
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Bonus stappen, nog een keer " + spelerActief.Dobbelnr + " stappen lopen naar positie:" + (spelerActief.Positie + spelerActief.Dobbelnr));
                        spelerActief.lopen();
                        spelregels(spelers, spelerActief);
                        break;
                    case 63:
                        Console.WriteLine("Speciale vak " + spelerActief.Positie + ": Het spel is gewonnen door " + spelerActief.Naam + "!!!");
                        Console.WriteLine("______EINDE SPEL______");
                        gameStatus = false;                                                 //weet niet hoe ik de gamestatus moet bereiken als ik de field heb staan in spel, daarom staat ie in deze class
                        break;
                    case int x when (x > 63):                                          //bij een positie hoger dan 63
                        var teveelstappen = 63 - spelerActief.Positie;               // negatieve waarde             bijv 3 stappen teveel = -3
                        spelerActief.Positie += (teveelstappen * 2);                       // stappen terugzetten          63 +-3
                        Console.WriteLine("te veel gegooid, je wordt van positie 63 " + teveelstappen + " stappen teruggezet.");
                        break;
                }
            }
            else {
                Console.WriteLine(spelerActief.Naam + " zit in de put, wacht tot je wordt bevrijdt");
            }
            }
        }
    }






