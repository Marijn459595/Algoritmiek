using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Vak
    {
        // Heel vak is door Coen Donk gemaakt

        public List<Stoel> StoelenLijst = new List<Stoel>();

        public List<string> GroepenLijst = new List<string>();

        public int Rijen { get; }
        public int Stoelen { get; }
        public string Naam;

        public int EersteRij()
        {
            return StoelenLijst.FindAll(Stoel => Stoel.Rij == 1 && Stoel.IsEmpty == true).Count;
        }

        public int LegeStoelen()
        {
            return StoelenLijst.FindAll(Stoel => Stoel.IsEmpty == true).Count;
        }

        public Vak(int Rijen, int Stoelen, char Naam)
        {
            this.Rijen = Rijen;
            this.Stoelen = Stoelen;
            this.Naam = Convert.ToString(Naam);

            for (int i = Rijen; i > 0; i--)
            {
                for (int j = Stoelen; j > 0; j--)
                {
                    StoelenLijst.Add(new Stoel(i, j, Naam));
                }
            }
        }
    }
}
