namespace CSHP07D_3
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
            this.buttonKopieren = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.labelQuelle = new System.Windows.Forms.Label();
            this.labelZiel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonKopieren
            // 
            this.buttonKopieren.Location = new System.Drawing.Point(12, 125);
            this.buttonKopieren.Name = "buttonKopieren";
            this.buttonKopieren.Size = new System.Drawing.Size(121, 23);
            this.buttonKopieren.TabIndex = 0;
            this.buttonKopieren.Text = "Kopieren";
            this.buttonKopieren.UseVisualStyleBackColor = true;
            this.buttonKopieren.Click += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(171, 125);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(121, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // labelQuelle
            // 
            this.labelQuelle.AutoSize = true;
            this.labelQuelle.Location = new System.Drawing.Point(12, 13);
            this.labelQuelle.Name = "labelQuelle";
            this.labelQuelle.Size = new System.Drawing.Size(37, 13);
            this.labelQuelle.TabIndex = 2;
            this.labelQuelle.Text = "Quelle";
            this.labelQuelle.DoubleClick += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // labelZiel
            // 
            this.labelZiel.AutoSize = true;
            this.labelZiel.Location = new System.Drawing.Point(171, 13);
            this.labelZiel.Name = "labelZiel";
            this.labelZiel.Size = new System.Drawing.Size(24, 13);
            this.labelZiel.TabIndex = 3;
            this.labelZiel.Text = "Ziel";
            this.labelZiel.DoubleClick += new System.EventHandler(this.buttonKopieren_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kaffee",
            "Gurken",
            "Banana",
            "Schere"});
            this.comboBox1.Location = new System.Drawing.Point(12, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Lama",
            "Maus",
            "Milch"});
            this.listBox1.Location = new System.Drawing.Point(171, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 56);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Einblenden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 175);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelZiel);
            this.Controls.Add(this.labelQuelle);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonKopieren);
            this.Name = "Form1";
            this.Text = "Spielereien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKopieren;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Label labelQuelle;
        private System.Windows.Forms.Label labelZiel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

