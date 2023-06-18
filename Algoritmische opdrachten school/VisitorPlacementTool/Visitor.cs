using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPlacementTool
{
    public class Visitor
    {
        // Heel Visitor is door Marijn Colen gemaakt

        public readonly string Voornaam;
        public readonly string Achternaam;
        DateTime Geboortedag;
        public readonly string Groepsnaam;
        public readonly bool IsVolwassen;
        public readonly int ID;

        public bool Begeleider;

        public bool IsNew { get; private set; }

        public Visitor(string Voornaam, string Achternaam, DateTime Geboortedag, string Groepsnaam, bool IsVolwassen, int ID)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.Geboortedag = Geboortedag;
            this.Groepsnaam = Groepsnaam;
            this.IsVolwassen = IsVolwassen;
            this.ID = ID;
            IsNew = true;
            Begeleider = false;
        }

        public Visitor(string Voornaam, string Achternaam, DateTime Geboortedag, bool IsVolwassen, int ID)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.Geboortedag = Geboortedag;
            this.IsVolwassen = IsVolwassen;
            this.ID = ID;
            IsNew = true;
            Begeleider = false;
        }
    }
}
