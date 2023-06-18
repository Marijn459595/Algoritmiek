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
    public partial class frmCreateGroup : Form
    {
        //Heel frmCreateGroup is door Marijn Colen gemaakt

        frmVisitors frmVisitors;

        public frmCreateGroup(frmVisitors frmVisitors)
        {
            this.frmVisitors = frmVisitors;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnMaakGroep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGroepNaam.Text) == false)
            {
                frmVisitors.AddGroep(tbGroepNaam.Text);
            }
            this.Close();
        }

        private void tbGroepNaam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMaakGroep_Click(this, new EventArgs());
            }
        }
    }
}
