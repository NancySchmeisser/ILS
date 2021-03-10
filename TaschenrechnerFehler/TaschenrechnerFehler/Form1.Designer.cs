namespace TaschenrechnerFehler
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplikation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraktion = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMultiplikation);
            this.groupBox1.Controls.Add(this.radioButtonDivision);
            this.groupBox1.Controls.Add(this.radioButtonSubtraktion);
            this.groupBox1.Controls.Add(this.radioButtonAddition);
            this.groupBox1.Location = new System.Drawing.Point(196, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechenoperation";
            // 
            // radioButtonMultiplikation
            // 
            this.radioButtonMultiplikation.AutoSize = true;
            this.radioButtonMultiplikation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonMultiplikation.Location = new System.Drawing.Point(7, 91);
            this.radioButtonMultiplikation.Name = "radioButtonMultiplikation";
            this.radioButtonMultiplikation.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMultiplikation.TabIndex = 3;
            this.radioButtonMultiplikation.TabStop = true;
            this.radioButtonMultiplikation.Text = "Multiplikation";
            this.radioButtonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonDivision.Location = new System.Drawing.Point(7, 68);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDivision.TabIndex = 2;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraktion
            // 
            this.radioButtonSubtraktion.AutoSize = true;
            this.radioButtonSubtraktion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonSubtraktion.Location = new System.Drawing.Point(6, 43);
            this.radioButtonSubtraktion.Name = "radioButtonSubtraktion";
            this.radioButtonSubtraktion.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSubtraktion.TabIndex = 1;
            this.radioButtonSubtraktion.TabStop = true;
            this.radioButtonSubtraktion.Text = "Subtraktion";
            this.radioButtonSubtraktion.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Checked = true;
            this.radioButtonAddition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioButtonAddition.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Addition";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(14, 36);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 8;
            this.textBoxZahl2.Text = "0";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(14, 10);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 7;
            this.textBoxZahl1.Text = "0";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAnzeige.Location = new System.Drawing.Point(62, 111);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 13;
            this.labelAnzeige.Text = "0";
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBeschreibung.Location = new System.Drawing.Point(14, 111);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(51, 13);
            this.labelBeschreibung.TabIndex = 12;
            this.labelBeschreibung.Text = "Ergebnis:";
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBeenden.Location = new System.Drawing.Point(205, 127);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(100, 23);
            this.buttonBeenden.TabIndex = 11;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBerechnen.Location = new System.Drawing.Point(14, 127);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(100, 23);
            this.buttonBerechnen.TabIndex = 10;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.ButtonBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 161);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ein einfacher Taschenrechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMultiplikation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonSubtraktion;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonBerechnen;
    }
}

