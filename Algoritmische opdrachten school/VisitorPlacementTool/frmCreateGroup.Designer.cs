namespace VisitorPlacementTool
{
    partial class frmCreateGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGroepNaam = new System.Windows.Forms.TextBox();
            this.lblGroepNaam = new System.Windows.Forms.Label();
            this.btnMaakGroep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGroepNaam
            // 
            this.tbGroepNaam.Location = new System.Drawing.Point(12, 25);
            this.tbGroepNaam.Name = "tbGroepNaam";
            this.tbGroepNaam.Size = new System.Drawing.Size(100, 20);
            this.tbGroepNaam.TabIndex = 0;
            this.tbGroepNaam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGroepNaam_KeyDown);
            // 
            // lblGroepNaam
            // 
            this.lblGroepNaam.AutoSize = true;
            this.lblGroepNaam.Location = new System.Drawing.Point(12, 9);
            this.lblGroepNaam.Name = "lblGroepNaam";
            this.lblGroepNaam.Size = new System.Drawing.Size(62, 13);
            this.lblGroepNaam.TabIndex = 1;
            this.lblGroepNaam.Text = "Groepnaam";
            // 
            // btnMaakGroep
            // 
            this.btnMaakGroep.Location = new System.Drawing.Point(12, 51);
            this.btnMaakGroep.Name = "btnMaakGroep";
            this.btnMaakGroep.Size = new System.Drawing.Size(100, 23);
            this.btnMaakGroep.TabIndex = 2;
            this.btnMaakGroep.Text = "Maak Groep";
            this.btnMaakGroep.UseVisualStyleBackColor = true;
            this.btnMaakGroep.Click += new System.EventHandler(this.btnMaakGroep_Click);
            // 
            // frmCreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 86);
            this.Controls.Add(this.btnMaakGroep);
            this.Controls.Add(this.lblGroepNaam);
            this.Controls.Add(this.tbGroepNaam);
            this.Name = "frmCreateGroup";
            this.Text = "Groep aanmaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGroepNaam;
        private System.Windows.Forms.Label lblGroepNaam;
        private System.Windows.Forms.Button btnMaakGroep;
    }
}