namespace VisitorPlacementTool
{
    partial class frmVisitors
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
            this.dtpGeboortedag = new System.Windows.Forms.DateTimePicker();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblGeboortedag = new System.Windows.Forms.Label();
            this.cbxGroepen = new System.Windows.Forms.ComboBox();
            this.btnAanmelden = new System.Windows.Forms.Button();
            this.btnGroepMaken = new System.Windows.Forms.Button();
            this.btnKlaar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpGeboortedag
            // 
            this.dtpGeboortedag.Checked = false;
            this.dtpGeboortedag.Location = new System.Drawing.Point(12, 64);
            this.dtpGeboortedag.Name = "dtpGeboortedag";
            this.dtpGeboortedag.Size = new System.Drawing.Size(206, 20);
            this.dtpGeboortedag.TabIndex = 0;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(118, 25);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 20);
            this.tbAchternaam.TabIndex = 1;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(12, 25);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(100, 20);
            this.tbVoornaam.TabIndex = 2;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(12, 9);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(55, 13);
            this.lblVoornaam.TabIndex = 3;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(120, 9);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(64, 13);
            this.lblAchternaam.TabIndex = 4;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblGeboortedag
            // 
            this.lblGeboortedag.AutoSize = true;
            this.lblGeboortedag.Location = new System.Drawing.Point(12, 48);
            this.lblGeboortedag.Name = "lblGeboortedag";
            this.lblGeboortedag.Size = new System.Drawing.Size(69, 13);
            this.lblGeboortedag.TabIndex = 5;
            this.lblGeboortedag.Text = "Geboortedag";
            // 
            // cbxGroepen
            // 
            this.cbxGroepen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroepen.FormattingEnabled = true;
            this.cbxGroepen.Items.AddRange(new object[] {
            "Geen groep"});
            this.cbxGroepen.Location = new System.Drawing.Point(12, 90);
            this.cbxGroepen.Name = "cbxGroepen";
            this.cbxGroepen.Size = new System.Drawing.Size(206, 21);
            this.cbxGroepen.TabIndex = 6;
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Location = new System.Drawing.Point(12, 117);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(100, 23);
            this.btnAanmelden.TabIndex = 7;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // btnGroepMaken
            // 
            this.btnGroepMaken.Location = new System.Drawing.Point(118, 117);
            this.btnGroepMaken.Name = "btnGroepMaken";
            this.btnGroepMaken.Size = new System.Drawing.Size(100, 23);
            this.btnGroepMaken.TabIndex = 8;
            this.btnGroepMaken.Text = "Groep maken";
            this.btnGroepMaken.UseVisualStyleBackColor = true;
            this.btnGroepMaken.Click += new System.EventHandler(this.btnGroepMaken_Click);
            // 
            // btnKlaar
            // 
            this.btnKlaar.Location = new System.Drawing.Point(12, 146);
            this.btnKlaar.Name = "btnKlaar";
            this.btnKlaar.Size = new System.Drawing.Size(206, 23);
            this.btnKlaar.TabIndex = 9;
            this.btnKlaar.Text = "Klaar";
            this.btnKlaar.UseVisualStyleBackColor = true;
            this.btnKlaar.Click += new System.EventHandler(this.btnKlaar_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(123, 43);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Testbutton";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.TestVisitors);
            // 
            // frmVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 181);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnKlaar);
            this.Controls.Add(this.btnGroepMaken);
            this.Controls.Add(this.btnAanmelden);
            this.Controls.Add(this.cbxGroepen);
            this.Controls.Add(this.lblGeboortedag);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.dtpGeboortedag);
            this.Name = "frmVisitors";
            this.Text = "Bezoekers inschrijven";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVisitors_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGeboortedag;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblGeboortedag;
        private System.Windows.Forms.ComboBox cbxGroepen;
        private System.Windows.Forms.Button btnAanmelden;
        private System.Windows.Forms.Button btnGroepMaken;
        private System.Windows.Forms.Button btnKlaar;
        private System.Windows.Forms.Button btnTest;
    }
}