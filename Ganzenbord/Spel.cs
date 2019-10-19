using System;
using System.Collections.Generic;
using System.Text;

namespace Ganzenbord
{
    class Spel
    {
        public List<Speler> spelers = new List<Speler>();
        public Speler spelerActief;
        public Spelbord bord = new Spelbord();

        public void starten()
        {
            Console.WriteLine("Naam speler 1: ");
            spelerToevoegen(Console.ReadLine());
            spelerActief = spelers[0];
            Console.WriteLine("Naam speler 2: ");
            spelerToevoegen(Console.ReadLine());
            Console.WriteLine("Naam speler 3: ");
            spelerToevoegen(Console.ReadLine());
            Console.WriteLine("Het spel is gestart");
        }

        public void spelen()
        {
            while (Spelbord.gameStatus)
            {
                if (spelerActief.status)           // alleen als speler status true is doet ie nog mee, anders wordt zijn beurt overgeslagen omdat ie niet meer in het spel zit
                {
                    aanDeBeurt(spelerActief);
                    spelerActief.spelerPositie();
                    wachtOpSpelerInput();
                    spelerActief.gooi();
                    spelerActief.lopen();
                    checkRegels();
                    spelerActief.spelerPositie();
                    wisselBeurt();
                }
                else
                {
                    wisselBeurt();
                }
            }
        }

        public void aanDeBeurt(Speler spelerActief)
        {
            Console.WriteLine("                            =========================================================================");
            Console.WriteLine("                            || " + spelerActief.naam + " is aan de beurt           ");

        }
        public void wisselBeurt()
        {
            if (spelerActief == spelers[spelers.Count - 1])
            {
                spelerActief = spelers[0];
            }
            else if (spelerActief == spelers[0])
            {
                spelerActief = spelers[1];
            }
            else if (spelerActief == spelers[1])
            {
                spelerActief = spelers[2];
            }
        }

        public void wachtOpSpelerInput()
        {
            Console.WriteLine("                            ======================================     Toets g + enter om dobbelsteen te gooien");
            var input = Console.ReadLine().ToUpper();

            if (input == "G")
            {
                //mechanisme om alleen door te gaan als G is ingetoets    //hier kan evt. functie ook gelijk uitgevoerd worden
            }
            else wachtOpSpelerInput();
        }

        public void checkRegels()
        {
            bord.spelregels(spelerActief);
        }

        public void spelerToevoegen(string invoerNaam)
        {
            Speler spelerObj = new Speler(invoerNaam);
            spelers.Add(spelerObj);
        }

    }
}
