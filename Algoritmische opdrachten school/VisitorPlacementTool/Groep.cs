using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Groep
    {
        // Heel Groep is door Marijn Colen gemaakt

        public List<Visitor> VisitorsList = new List<Visitor>();

        public string Naam;

        public bool HasPriority;

        public int ChildAmount()
        {
            int ChildAmount = 0;

            if (VisitorsList.Count > 0)
            {
                foreach (var Visitor in VisitorsList)
                {
                    if (Visitor.IsVolwassen == false || Visitor.Begeleider == true)
                    {
                        ChildAmount++;
                    }
                }
            }

            return ChildAmount;
        }

        public int ParentAmount()
        {
            int ParentAmount = 0;

            if (VisitorsList.Count > 0)
            {
                foreach (var Visitor in VisitorsList)
                {
                    if (Visitor.IsVolwassen == true && Visitor.Begeleider == false)
                    {
                        ParentAmount++;
                    }
                }
            }

            return ParentAmount;
        }

        public Groep(string Naam)
        {
            this.Naam = Naam;
            HasPriority = false;
        }
    }
}
