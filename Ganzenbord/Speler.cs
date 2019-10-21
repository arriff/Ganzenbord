using System;
using System.Collections.Generic;
using System.Text;

namespace Ganzenbord
{
    public class Speler
    {
        private string naam;
        private int positie;
        private int dobbelnr;
        private bool status;
        private int beurten;            //aantal beurten overslaan
        private bool put;

        public Speler(string aNaam)
        {
            naam = aNaam;
            positie = 29;
            dobbelnr = 0;
            status = true;
            beurten = 0;
            put = false;    
        }

        public string Naam { get { return naam; } set { } }
        public int Positie { get { return positie; } set { positie = value; } }
        public int Dobbelnr{ get { return dobbelnr; } set { dobbelnr = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public int Beurten { get { return beurten; } set { beurten = value; } }
        public bool Put { get { return put; } set { put = value; } }

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
