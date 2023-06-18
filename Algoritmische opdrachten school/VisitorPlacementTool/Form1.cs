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
    public partial class Form1 : Form
    {
        // Heel form1 is door Coen Donk gemaakt

        public Event Event = new Event();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            foreach (var Button in this.Controls.OfType<Button>())
            {
                if (Button.Name.Substring(0, 6) == "button")
                {
                    Button.Visible = false;
                    Button.Text = "";
                }
                if (Button.Name == "btnTest" && Event.TestMode == true)
                {
                    Button.Visible = true;
                }
            }
        }

        private void btnMaakVak_Click(object sender, EventArgs e)
        {
            Event.AddVak(Convert.ToInt32(nudRijen.Value), Convert.ToInt32(nudStoelen.Value));
            cbxVakken.Items.Clear();
            foreach (var Vak in Event.Vakken)
            {
                cbxVakken.Items.Add("Vak " + Vak.Naam);
            }
            if (Event.Vakken.Count > 0)
            {
                cbxVakken.SelectedIndex = cbxVakken.Items.Count - 1;
            }
        }

        private void cbxVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var Button in this.Controls.OfType<Button>())
            {
                if (Button.Name.Substring(0, 6) == "button")
                {
                    Button.Visible = false;
                }
            }
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
                            }
                        }
                    }
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult Done = MessageBox.Show("Ben je klaar met vakken toevoegen?", "Bevestig", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Done == DialogResult.Yes)
            {
                Event.Datum = dtpEvenement.Value;
                frmVisitors Visitors = new frmVisitors(Event);
                Visitors.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TestEvent(object sender, EventArgs e)
        {
            Event.AddVak(3, 3);
            Event.AddVak(1, 3);
            Event.AddVak(2, 4);
            Event.Datum = new DateTime(2022, 1, 9);
            frmVisitors frmVisitors = new frmVisitors(Event);
            frmVisitors.Show();
            this.Hide();
        }
    }
}
