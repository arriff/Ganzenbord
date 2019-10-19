using System;

namespace Ganzenbord
{
    class Program
    {
        static void Main(string[] args)
        {


            var spel = new Spel();
            spel.starten();

            while (Spelbord.gameStatus)
            {
                if (spel.spelerActief.status)           // alleen als speler status true is doet ie nog mee, anders wordt zijn beurt overgeslagen omdat ie niet meer in het spel zit
                {
                    spel.aanDeBeurt(spel.spelerActief);

                    spel.spelerActief.spelerPositie();

                    spel.wachtOpSpelerInput();

                    spel.spelerActief.gooi();

                    spel.spelerActief.lopen();

                    spel.checkRegels();

                    spel.spelerActief.spelerPositie();

                    spel.wisselBeurt();

                }
                else
                {
                    spel.wisselBeurt();
                }
            }
        }

    }
}

