using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        private Train Train = new Train();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cbDiet.Text) || string.IsNullOrWhiteSpace(cbSize.Text))
            {
                MessageBox.Show("Zorg dat je alle gegevens ingevuld hebt!", "Fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Train.AddAnimal(txtName.Text, cbSize.Text, cbDiet.Text);
                Clear();
            }
            UpdateListBox();
        }

        private void btnDistribute_Click(object sender, EventArgs e)
        {
            if (lbTrain.Items.Count == 0)
            {
                MessageBox.Show("Voeg eerst wat dieren toe!", "Add animals first", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Train.ClearWagons();
            lbWagon.Items.Clear();
            Train.DistributeAnimals();
            UpdateComboBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lbTrain.Items.Count == 0)
            {
                MessageBox.Show("Lijst is al leeg!", "List already empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Train.Animals.Clear();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbTrain.Items.Clear();
            foreach (var Animal in Train.Animals)
            {
                string Size;
                switch (Animal.Size)
                {
                    case 1:
                        Size = "Klein";
                        break;
                    case 3:
                        Size = "Middelgroot";
                        break;
                    default:
                        Size = "Groot";
                        break;
                }
                lbTrain.Items.Add(Animal.Name + " " + Size + " " + Animal.Diet);
            }
        }

        private void UpdateComboBox()
        {
            cbWagons.Items.Clear();
            foreach (var Wagon in Train.Wagons)
            {
                cbWagons.Items.Add("Wagon " + Wagon.Increment);
            }
            cbWagons.Text = "Wagon 1";
        }

        private void Clear()
        {
            txtName.Text = null;
            cbDiet.Text = null;
            cbSize.Text = null;
        }

        private void cbWagons_TextChanged(object sender, EventArgs e)
        {
            string WagonNumbers = null;
            for (int i = 0; i < cbWagons.Text.Length; i++)
            {
                if (Char.IsDigit(cbWagons.Text[i]))
                {
                    WagonNumbers += cbWagons.Text[i];
                }
            }
            int.TryParse(WagonNumbers, out int WagonNumber);
            lbWagon.Items.Clear();
            foreach (var Wagon in Train.Wagons)
            {
                if (Wagon.Increment == WagonNumber)
                {
                    foreach (var Animal in Wagon.Animals)
                    {
                        string Size;
                        switch (Animal.Size)
                        {
                            case 1:
                                Size = "Klein";
                                break;
                            case 3:
                                Size = "Middelgroot";
                                break;
                            default:
                                Size = "Groot";
                                break;
                        }
                        lbWagon.Items.Add(Animal.Name + " " + Size + " " + Animal.Diet);
                    }
                }
            }
        }
    }
}
