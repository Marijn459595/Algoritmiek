namespace Circustrein
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiet = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.lbTrain = new System.Windows.Forms.ListBox();
            this.cbWagons = new System.Windows.Forms.ComboBox();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 131);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 25);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Dier toevoegen";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Klein",
            "Middelgroot",
            "Groot"});
            this.cbSize.Location = new System.Drawing.Point(12, 104);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 1;
            // 
            // cbDiet
            // 
            this.cbDiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Items.AddRange(new object[] {
            "Planten",
            "Vlees"});
            this.cbDiet.Location = new System.Drawing.Point(12, 64);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(121, 21);
            this.cbDiet.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naam";
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(12, 48);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(32, 13);
            this.lblDiet.TabIndex = 5;
            this.lblDiet.Text = "Dieet";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 88);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(45, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Formaat";
            // 
            // btnDistribute
            // 
            this.btnDistribute.Location = new System.Drawing.Point(12, 161);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(121, 23);
            this.btnDistribute.TabIndex = 7;
            this.btnDistribute.Text = "Dieren verdelen";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // lbTrain
            // 
            this.lbTrain.FormattingEnabled = true;
            this.lbTrain.Location = new System.Drawing.Point(139, 12);
            this.lbTrain.Name = "lbTrain";
            this.lbTrain.Size = new System.Drawing.Size(130, 199);
            this.lbTrain.TabIndex = 8;
            // 
            // cbWagons
            // 
            this.cbWagons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWagons.FormattingEnabled = true;
            this.cbWagons.Location = new System.Drawing.Point(275, 12);
            this.cbWagons.Name = "cbWagons";
            this.cbWagons.Size = new System.Drawing.Size(130, 21);
            this.cbWagons.TabIndex = 9;
            this.cbWagons.TextChanged += new System.EventHandler(this.cbWagons_TextChanged);
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.Location = new System.Drawing.Point(275, 39);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(130, 173);
            this.lbWagon.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Lijst leegmaken";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 223);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.cbWagons);
            this.Controls.Add(this.lbTrain);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbDiet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.ListBox lbTrain;
        private System.Windows.Forms.ComboBox cbWagons;
        private System.Windows.Forms.ListBox lbWagon;
        private System.Windows.Forms.Button btnClear;
    }
}

