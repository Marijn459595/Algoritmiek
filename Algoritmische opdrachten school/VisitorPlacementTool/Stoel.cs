using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Stoel
    {
        // Heel Stoel is door Coen Donk gemaakt

        public int Rij;
        public int Stoelnummer;
        private char Rijnaam;
        public string Stoelnaam;
        public int VisitorID = -1;

        public bool IsEmpty { get { if (VisitorID == -1) return true; else return false; } }


        public Stoel(int Rij, int Stoelnummer, char Rijnaam)
        {
            this.Rij = Rij;
            this.Stoelnummer = Stoelnummer;
            this.Rijnaam = Rijnaam;

            Stoelnaam = Rijnaam.ToString() + Rij.ToString() + "_" + Stoelnummer.ToString();
        }
    }
}
