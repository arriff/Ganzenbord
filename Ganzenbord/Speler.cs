using System;
using System.Collections.Generic;
using System.Text;

namespace Ganzenbord
{
    public class Speler
    {
        public string naam;
        public int positie;
        public int dobbelnr;
        public bool status;

        public Speler(string Naam)
        {
            naam = Naam;
            positie = 0;
            dobbelnr = 0;
            status = true;
        }

        public void lopen()
        {
            positie += dobbelnr;
        }
        public void gooi()
        {
            dobbelnr = Dobbelsteen.dobbelen();
            Console.WriteLine("Je hebt een " + dobbelnr + " gegooid       =========================================");
        }

        public void spelerPositie()
        {
            Console.WriteLine("                            || " + naam + " staat nu op positie:  " + positie + "   ");
        }

    }
}
