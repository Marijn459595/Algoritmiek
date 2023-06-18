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
    public partial class frmVisitors : Form
    {
        // Heel frmVisitors is door Marijn Colen gemaakt

        private Event Event;
        public VisitorCollection Visitors;

        public frmVisitors(Event Event)
        {
            this.Event = Event;
            Visitors = new VisitorCollection(Event.Datum);
            InitializeComponent();
            this.CenterToScreen();
            UpdateGroups();
            foreach (var Button in this.Controls.OfType<Button>())
            {
                if (Button.Name == "btnTest" && Event.TestMode == true)
                {
                    Button.Visible = true;
                }
            }
        }

        private void UpdateGroups()
        {
            cbxGroepen.Items.Clear();
            cbxGroepen.Items.Add("Geen groep");

            if (Visitors.Groepen.Count != 0)
            {
                foreach (var Groep in Visitors.Groepen)
                {
                    cbxGroepen.Items.Add(Groep.Naam);
                }
            }
        }

        public void AddGroep(string Groepsnaam)
        {
            Visitors.AddGroep(Groepsnaam);
        }

        private void frmVisitors_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGroepMaken_Click(object sender, EventArgs e)
        {
            frmCreateGroup CreateGroup = new frmCreateGroup(this);
            CreateGroup.ShowDialog();
            UpdateGroups();
        }

        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Today, Event.Datum) < 0)
            {
                if (Event.StoelenCount > Visitors.VisitorsList.Count)
                {
                    if (string.IsNullOrEmpty(cbxGroepen.Text))
                    {
                        MessageBox.Show("Selecteer een groep", "Geen groep", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(tbVoornaam.Text) == false && string.IsNullOrEmpty(tbAchternaam.Text) == false && dtpGeboortedag.Value != DateTime.Today)
                        {
                            if (cbxGroepen.Text == "Geen groep")
                            {
                                if (Visitors.IsVolwassen(dtpGeboortedag.Value) == true)
                                {
                                    Visitors.AddVisitor(tbVoornaam.Text, tbAchternaam.Text, dtpGeboortedag.Value);
                                }
                                else
                                {
                                    MessageBox.Show("Kinderen moeten met minimaal één volwassene inschrijven", "Geen volwassenen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                if (Visitors.IsVolwassen(dtpGeboortedag.Value) == true)
                                {
                                    Visitors.AddVisitor(tbVoornaam.Text, tbAchternaam.Text, dtpGeboortedag.Value, cbxGroepen.Text);
                                }
                                else
                                {
                                    if (Visitors.VolwassenenInGroep(cbxGroepen.Text) == true)
                                    {
                                        Visitors.AddVisitor(tbVoornaam.Text, tbAchternaam.Text, dtpGeboortedag.Value, cbxGroepen.Text);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kinderen moeten met minimaal één volwassene inschrijven", "Geen volwassenen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                            }
                            dtpGeboortedag.Value = DateTime.Today;
                            tbAchternaam.Text = string.Empty;
                            tbVoornaam.Text = string.Empty;
                            UpdateGroups();
                        }
                        else
                        {
                            MessageBox.Show("Zorg dat je alle benodigde gegevens ingevuld hebt!", "Gegevens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maximum aantal bezoekers voor dit evenement is al bereikt", "Geen plek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Inschrijvingen voor dit event zijn al gesloten", "Inschrijvingen gesloten", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Weet je zeker dat je klaar bent met mensen inschrijven?", "Weet je het zeker?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                Event.Verdeel(Visitors);
                frmDisplayVisitors DisplayVisitors = new frmDisplayVisitors(Event, Visitors);
                DisplayVisitors.Show();
                this.Hide();
            }
        }

        private void TestVisitors(object sender, EventArgs e)
        {
            Visitors.AddGroep("1 volwassene, 2 kinderen");
            Visitors.AddGroep("3 volwassenen");
            Visitors.AddGroep("1 volwassene, 3 kinderen");

            Visitors.AddVisitor("Volwassene 1", "Groep 1", new DateTime(1900, 1, 1), "1 volwassene, 2 kinderen"); // 0
            Visitors.AddVisitor("Kind 1", "Groep 1", new DateTime(2021, 3, 20), "1 volwassene, 2 kinderen"); // 1
            Visitors.AddVisitor("Kind 2", "Groep 1", new DateTime(2021, 3, 20), "1 volwassene, 2 kinderen"); // 2

            Visitors.AddVisitor("Volwassene 1", "Groep 2", new DateTime(1900, 1, 1), "3 volwassenen"); // 3
            Visitors.AddVisitor("Volwassene 2", "Groep 2", new DateTime(1900, 1, 1), "3 volwassenen"); // 4
            Visitors.AddVisitor("Volwassene 3", "Groep 2", new DateTime(1900, 1, 1), "3 volwassenen"); // 5

            Visitors.AddVisitor("Volwassene 1", "Groep 3", new DateTime(1900, 1, 1), "1 volwassene, 3 kinderen"); // 6
            Visitors.AddVisitor("Kind 1", "Groep 3", new DateTime(2021, 3, 20), "1 volwassene, 3 kinderen"); // 7
            Visitors.AddVisitor("Kind 2", "Groep 3", new DateTime(2021, 3, 20), "1 volwassene, 3 kinderen"); // 8
            Visitors.AddVisitor("Kind 3", "Groep 3", new DateTime(2021, 3, 20), "1 volwassene, 3 kinderen"); // 9

            Visitors.AddVisitor("Volwassene 1", "Geen groep", new DateTime(1900, 1, 1)); // 10
            Visitors.AddVisitor("Volwassene 1", "Geen groep", new DateTime(1900, 1, 1)); // 11
            UpdateGroups();
        }
    }
}
