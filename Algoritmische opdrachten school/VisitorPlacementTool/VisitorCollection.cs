using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace VisitorPlacementTool
{
    public class VisitorCollection
    {
        // Heel VisitorCollection is door Marijn Colen gemaakt

        public List<Visitor> VisitorsList = new List<Visitor>();

        public List<Groep> Groepen = new List<Groep>();

        private DateTime EvenementDag;

        private int NextVisitorID = 0;

        public void AddGroep(string Groepsnaam)
        {
            bool NameExists = false;
            if (Groepen.Count > 0)
            {
                foreach (var Groep in Groepen)
                {
                    if (Groep.Naam == Groepsnaam)
                    {
                        NameExists = true;
                        break;
                    }
                }
            }
            if (NameExists == false)
            {
                Groepen.Add(new Groep(Groepsnaam));
            }
        }

        public bool VolwassenenInGroep(string Groepsnaam)
        {
            bool VolwasseneAanwezig = false;
            foreach (var Visitor in VisitorsList)
            {
                if (Visitor.Groepsnaam == Groepsnaam && Visitor.IsVolwassen == true)
                {
                    VolwasseneAanwezig = true;
                }
            }

            return VolwasseneAanwezig;
        }

        public void VerdeelGroepen()
        {
            if (VisitorsList.Count > 0)
            {
                foreach (var Visitor in VisitorsList)
                {
                    if (string.IsNullOrEmpty(Visitor.Groepsnaam) == false)
                    {
                        foreach (var Groep in Groepen)
                        {
                            if (Groep.Naam == Visitor.Groepsnaam)
                            {
                                Groep.VisitorsList.Add(Visitor);
                            }
                        }
                    }
                }
            }
        }

        public bool IsVolwassen(DateTime Geboortedag)
        {
            var Leeftijd = EvenementDag.Year - Geboortedag.Year;

            if (Geboortedag.Date > EvenementDag.AddYears(-Leeftijd))
            {
                Leeftijd--;
            }

            if (Leeftijd > 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddVisitor(string Voornaam, string Achternaam, DateTime Geboortedag, string Groepsnaam)
        {
            VisitorsList.Add(new Visitor(Voornaam, Achternaam, Geboortedag, Groepsnaam, IsVolwassen(Geboortedag), NextVisitorID));
            NextVisitorID++;
        }

        public void AddVisitor(string Voornaam, string Achternaam, DateTime Geboortedag)
        {
            VisitorsList.Add(new Visitor(Voornaam, Achternaam, Geboortedag, IsVolwassen(Geboortedag), NextVisitorID));
            NextVisitorID++;
        }

        public VisitorCollection(DateTime EvenementDag)
        {
            this.EvenementDag = EvenementDag;
        }
    }
}
