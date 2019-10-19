using System;
using System.Collections.Generic;
using System.Text;

namespace Ganzenbord
{
    public class Spelbord
    {
        public static bool gameStatus = true;

        public void spelregels(Speler spelers)
        {
            switch (spelers.positie)
            {
                case 23:                                                            //bij positie 23
                    Console.WriteLine("Gevangenis!, Het spel is over");
                    spelers.status = false;
                    break;
                case 25:
                case 45:                                                   //bij positie 25 en 45
                    Console.WriteLine("terug naar start.");
                    spelers.positie = 0;                                            //positie terug gezet naar 0
                    break;
                case int x when (x % 10 == 0):                                      //bij positie 10,20,30,40,50,60 etc
                    Console.WriteLine("geworpen " + spelers.dobbelnr + " nog een keer lopen naar " + (spelers.positie += spelers.dobbelnr));
                    spelers.lopen();
                    spelregels(spelers);
                    break;
                case int x when (x >= 63):                                          //bij positie 63 en hoger
                    Console.WriteLine("Het spel is gewonnen door " + spelers.naam + "!!!");
                    Console.WriteLine("______EINDE SPEL______");
                    spelers.positie = 63;                                               //om te voorkomen dat er een hogere positie dan 63 wordt geprint
                    gameStatus = false;                                                 //weet niet hoe ik de gamestatus moet bereiken als ik de field heb staan in spel, daarom staat ie in deze class
                    break;
            }
        }





    }

}





