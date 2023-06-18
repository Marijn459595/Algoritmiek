using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPlacementTool
{
    public partial class frmDisplayVisitors : Form
    {
        private Event Event;
        private VisitorCollection Visitors;
        public frmDisplayVisitors(Event Event, VisitorCollection Visitors)
        {
            this.Event = Event;
            this.Visitors = Visitors;
            InitializeComponent();
            foreach (var Button in this.Controls.OfType<Button>())
            {
                Button.Visible = false;
                Button.Text = "";
            }

            Event.Vakken.Sort((x, y) => x.Naam.CompareTo(y.Naam));

            cbxVakken.Items.Clear();
            foreach (var Vak in Event.Vakken)
            {
                cbxVakken.Items.Add("Vak " + Vak.Naam);
            }
            if (Event.Vakken.Count > 0)
            {
                cbxVakken.SelectedIndex = 0;
            }

            List<int> VisitorIDs = new List<int>();
            foreach (var Vak in Event.Vakken)
            {
                foreach (var Stoel in Vak.StoelenLijst)
                {
                    if (Stoel.VisitorID != -1)
                    {
                        VisitorIDs.Add(Stoel.VisitorID);
                    }
                }
            }
            foreach (var Visitor in Visitors.VisitorsList)
            {
                if (VisitorIDs.FindAll(ID => ID == Visitor.ID).Count == 0)
                {
                    lbxVisitorsNoAccess.Items.Add(Visitor.Voornaam + " " + Visitor.Achternaam);
                }
            }
        }

        private void cbxVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var Button in this.Controls.OfType<Button>())
            {
                Button.Visible = false;
                Button.Text = " ";
                Button.BackColor = Color.Transparent;
            }
            lblRij1.Visible = false;
            lblRij2.Visible = false;
            lblRij3.Visible = false;
            foreach (var Vak in Event.Vakken)
            {
                if ("Vak " + Vak.Naam.ToString() == cbxVakken.Text)
                {
                    foreach (var Stoel in Vak.StoelenLijst)
                    {
                        foreach (var Button in this.Controls.OfType<Button>())
                        {
                            if (Button.Name == "button" + Stoel.Rij + "_" + Stoel.Stoelnummer)
                            {
                                Button.Visible = true;
                                if (Stoel.Rij == 1)
                                {
                                    lblRij1.Visible = true;
                                }
                                else if (Stoel.Rij == 2)
                                {
                                    lblRij2.Visible = true;
                                }
                                else if (Stoel.Rij == 3)
                                {
                                    lblRij3.Visible = true;
                                }
                                if (Stoel.VisitorID != -1)
                                {
                                    Visitor Visitor = Visitors.VisitorsList.Find(FindVisitor => FindVisitor.ID == Stoel.VisitorID);
                                    Button.Text = Visitor.Voornaam + " " + Visitor.Achternaam;
                                    Button.BackColor = Color.LightSkyBlue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void frmDisplayVisitors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbxVisitorsNoAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Er was voor deze bezoeker helaas geen plek meer.");
        }
    }
}
