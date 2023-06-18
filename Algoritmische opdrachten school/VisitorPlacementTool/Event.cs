using System;
using System.Collections.Generic;

namespace VisitorPlacementTool
{
    public class Event
    {
        // Past deze bool aan naar true om speciale testbuttons visible te maken waarmee je heel makkelijk een testevent aan maakte
        public readonly bool TestMode = false;
        char Vaknaam = '@';
        public List<Vak> Vakken = new List<Vak>();
        public DateTime Datum;
        public int StoelenCount;

        // Coen
        public void AddVak(int Rijen, int Stoelen)
        {
            Vaknaam++;
            Vakken.Add(new Vak(Rijen, Stoelen, Vaknaam));
            StoelenCount += Rijen * Stoelen;
        }

        // Marijn
        public bool AnyChildrenLeft(List<Groep> Groepen)
        {
            bool ChildrenLeft = false;
            if (Groepen.Count > 0)
            {
                foreach (var Groep in Groepen)
                {
                    if (Groep.VisitorsList.Count > 0)
                    {
                        foreach (var Visitor in Groep.VisitorsList)
                        {
                            if (Visitor.IsVolwassen == false)
                            {
                                ChildrenLeft = true;
                            }
                        }
                    }
                }
            }
            return ChildrenLeft;
        }

        // Coen en Marijn
        public void Verdeel(VisitorCollection Visitors)
        {
            Visitors.VerdeelGroepen();

            List<Groep> GroepenOnverdeeld = Visitors.Groepen;

            List<Groep> GroepenMetKinderen = GroepenOnverdeeld.FindAll(Groep => Groep.ChildAmount() > 0);

            // Alle groepen met kinderen
            while (GroepenMetKinderen.Count > 0)
            {
                GroepenMetKinderen.Sort((x, y) => y.ChildAmount().CompareTo(x.ChildAmount()));

                foreach (var Groep in GroepenMetKinderen)
                {
                    if (Groep.ChildAmount() > 0)
                    {
                        Groep.VisitorsList.Find(Visitor => Visitor.IsVolwassen == true).Begeleider = true;
                    }
                }

                Vakken.Sort((x, y) => y.Stoelen.CompareTo(x.Stoelen));

                int VakIndex = 0;

                bool FirstPartDone = false;
                bool SecondPartDone = false;

                while (GroepenMetKinderen.Count > 0)
                {
                    // First part = groepen die een aantal kinderen + 1 volwassene hebben dat precies op de voorste rij van één vak past
                    if (FirstPartDone == false)
                    {
                        // alle groepen verdelen waarvan het aantal kinderen overeen komt met het aantal stoelen op een rij van een vak
                        // Groep zoeken met grootste aantal kinderen dat exact overeenkomt met het aantal stoelen in het grootste vak
                        foreach (var Groep in GroepenMetKinderen)
                        {
                            if (Groep.ChildAmount() == Vakken[VakIndex].Stoelen)
                            {
                                Groep.HasPriority = true;
                                break;
                            }
                        }

                        // De kinderen én volwassenen uit deze groep verdelen over stoelen in dit vak
                        if (GroepenMetKinderen.FindAll(Groep => Groep.HasPriority == true).Count > 0)
                        {
                            Groep VerdeelGroep = GroepenMetKinderen.Find(Groep => Groep.HasPriority = true);
                            foreach (var Visitor in VerdeelGroep.VisitorsList)
                            {
                                if (Visitor.IsVolwassen == false || (Visitor.IsVolwassen == true && Visitor.Begeleider == true))
                                {
                                    Vakken[VakIndex].StoelenLijst.Find(Stoel => Stoel.IsEmpty == true && Stoel.Rij == 1).VisitorID = Visitor.ID;
                                    if (Vakken[VakIndex].GroepenLijst.Contains(Visitor.Groepsnaam) != true)
                                    {
                                        Vakken[VakIndex].GroepenLijst.Add(Visitor.Groepsnaam);
                                    }
                                }
                            }
                            GroepenMetKinderen.Remove(GroepenMetKinderen.Find(Groep => Groep.Naam == VerdeelGroep.Naam));
                            GroepenOnverdeeld.Remove(GroepenOnverdeeld.Find(Groep => Groep.Naam == VerdeelGroep.Naam));

                            VakIndex++;
                        }
                        else
                        {
                            FirstPartDone = true;
                        }
                    }

                    // Second part = groepen met kinderen die verdeeld moeten worden over twee vakken
                    if (SecondPartDone == false && FirstPartDone == true)
                    {
                        // alle groepen verdelen waarvan de kinderen opgesplitst moeten worden
                        GroepenMetKinderen.Sort((x, y) => x.ChildAmount().CompareTo(y.ChildAmount()));
                        Groep VerdeelGroep = GroepenMetKinderen[0];
                        Vak Vak = VakkenMetPlekRij1()[0];
                        Vak.StoelenLijst.Find(Stoel => Stoel.IsEmpty == true && Stoel.Rij == 1).VisitorID = VerdeelGroep.VisitorsList.Find(Volwassene => Volwassene.Begeleider == true).ID;
                        if (Vak.GroepenLijst.Contains(VerdeelGroep.VisitorsList.Find(Volwassene => Volwassene.Begeleider == true).Groepsnaam) != true)
                        {
                            Vak.GroepenLijst.Add(VerdeelGroep.VisitorsList.Find(Volwassene => Volwassene.Begeleider == true).Groepsnaam);
                        }
                        foreach (var Visitor in VerdeelGroep.VisitorsList.FindAll(Visitor => Visitor.IsVolwassen == false))
                        {
                            if (Vak.EersteRij() > 0)
                            {
                                Vak.StoelenLijst.Find(Stoel => Stoel.IsEmpty == true && Stoel.Rij == 1).VisitorID = Visitor.ID;
                                if (Vak.GroepenLijst.Contains(Visitor.Groepsnaam) != true)
                                {
                                    Vak.GroepenLijst.Add(Visitor.Groepsnaam);
                                }
                            }
                        }
                        foreach (var Stoel in Vak.StoelenLijst.FindAll(Stoel => Stoel.IsEmpty == false))
                        {
                            foreach (var Groep in GroepenMetKinderen)
                            {
                                Groep.VisitorsList.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                            }
                            foreach (var Groep in GroepenOnverdeeld)
                            {
                                Groep.VisitorsList.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                            }
                        }
                        if (VerdeelGroep.ChildAmount() > 0)
                        {
                            VerdeelGroep.VisitorsList.Find(Visitor => Visitor.IsVolwassen == true).Begeleider = true;
                        }
                        else
                        {
                            SecondPartDone = true;
                        }
                        GroepenMetKinderen.RemoveAll(Groep => Groep.VisitorsList.Count == 0);
                        GroepenOnverdeeld.RemoveAll(Groep => Groep.VisitorsList.Count == 0);
                    }

                    // Third part = groepen die geen kinderen (meer) hebben (dus ook groepen met kinderen, die meer volwassenen hebben dan er nodig zijn voor het aantal kinderen.
                    if (SecondPartDone == true)
                    {
                        foreach (var Groep in GroepenMetKinderen)
                        {
                            Vak Vak = Vakken.Find(CheckVak => CheckVak.GroepenLijst.Contains(Groep.Naam));
                            foreach (var Visitor in Groep.VisitorsList)
                            {
                                Vak.StoelenLijst.Find(Stoel => Stoel.IsEmpty == true).VisitorID = Visitor.ID;
                            }
                        }
                        foreach (var Vak in Vakken)
                        {
                            foreach (var Stoel in Vak.StoelenLijst.FindAll(Stoel => Stoel.IsEmpty == false))
                            {
                                foreach (var Groep in GroepenMetKinderen)
                                {
                                    Groep.VisitorsList.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                                }
                                foreach (var Groep in GroepenOnverdeeld)
                                {
                                    Groep.VisitorsList.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                                }
                            }
                        }
                        GroepenMetKinderen.RemoveAll(Groep => Groep.VisitorsList.Count == 0);
                        GroepenOnverdeeld.RemoveAll(Groep => Groep.VisitorsList.Count == 0);
                    }
                }
            }

            // Alle groepen zonder kinderen
            while (GroepenOnverdeeld.Count > 0)
            {
                foreach (var Groep in GroepenOnverdeeld)
                {
                    Vak VerdeelVak = Vakken.Find(Vak => Vak.LegeStoelen() > Groep.VisitorsList.Count);
                    foreach (var Visitor in Groep.VisitorsList)
                    {
                        VerdeelVak.StoelenLijst.Find(Stoel => Stoel.IsEmpty == true).VisitorID = Visitor.ID;
                    }
                }
                foreach (var Vak in Vakken)
                {
                    foreach (var Stoel in Vak.StoelenLijst.FindAll(Stoel => Stoel.IsEmpty == false))
                    {
                        foreach (var Groep in GroepenOnverdeeld)
                        {
                            Groep.VisitorsList.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                        }
                    }
                }
                GroepenOnverdeeld.RemoveAll(Groep => Groep.VisitorsList.Count == 0);
            }

            // Alle alleenstaande bezoekers
            List<Visitor> VisitorsOnverdeeld = Visitors.VisitorsList.FindAll(Visitor => string.IsNullOrEmpty(Visitor.Groepsnaam) == true);
            while (VisitorsOnverdeeld.Count > 0)
            {
                foreach (var Visitor in VisitorsOnverdeeld)
                {
                    VakkenMetPlek()[0].StoelenLijst.Find(Stoel => Stoel.IsEmpty == true).VisitorID = Visitor.ID;
                }
                foreach (var Vak in Vakken)
                {
                    foreach (var Stoel in Vak.StoelenLijst.FindAll(Stoel => Stoel.IsEmpty == false))
                    {
                        VisitorsOnverdeeld.RemoveAll(Visitor => Visitor.ID == Stoel.VisitorID);
                    }
                }
            }
        }

        private List<Vak> VakkenMetPlek()
        {
            List<Vak> ReturnList = Vakken.FindAll(Vak => Vak.LegeStoelen() > 0);
            ReturnList.Sort((x, y) => x.LegeStoelen().CompareTo(y.LegeStoelen()));

            return ReturnList;
        }

        private List<Vak> VakkenMetPlekRij1()
        {
            List<Vak> ReturnList = Vakken.FindAll(Vak => Vak.EersteRij() > 1);
            ReturnList.Sort((x, y) => x.EersteRij().CompareTo(y.EersteRij()));

            return ReturnList;
        }
    }
}

/*
    beginsituatie: meerdere groepen die verdeeld moeten worden (met ouders)
    
    lijst maken met alle vakken waar nog plek in is (op de eerste rij)
    {
    grootste te verdelen groep pakken
    aantal kinderen grootste groep - aantal plekken grootste vak
    vak zoeken met genoeg plek voor resterende kinderen grootste groep
        als geen vak gevonden, grootste aantal mogelijk pakken en nogmaals groep opsplitsen
    kinderen in vak zetten
    }

    eindsituatie: verdeelde groepen
*/