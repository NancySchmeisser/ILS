﻿namespace Taschenrechner
{
    partial class Taschenrechner
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
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.Rechenoperation = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplikation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraktion = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.ComboBoxAuswahl = new System.Windows.Forms.ComboBox();
            this.Rechenoperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(47, 126);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(75, 23);
            this.buttonBerechnen.TabIndex = 0;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(259, 126);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(47, 28);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 2;
            this.textBoxZahl1.Text = "0";
            this.textBoxZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(47, 55);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 3;
            this.textBoxZahl2.Text = "0";
            this.textBoxZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.Location = new System.Drawing.Point(47, 101);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(51, 13);
            this.labelBeschreibung.TabIndex = 4;
            this.labelBeschreibung.Text = "Ergebnis:";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(101, 101);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 5;
            this.labelAnzeige.Text = "0";
            // 
            // Rechenoperation
            // 
            this.Rechenoperation.Controls.Add(this.radioButtonMultiplikation);
            this.Rechenoperation.Controls.Add(this.radioButtonDivision);
            this.Rechenoperation.Controls.Add(this.radioButtonSubtraktion);
            this.Rechenoperation.Controls.Add(this.radioButtonAddition);
            this.Rechenoperation.Location = new System.Drawing.Point(172, 14);
            this.Rechenoperation.Name = "Rechenoperation";
            this.Rechenoperation.Size = new System.Drawing.Size(200, 106);
            this.Rechenoperation.TabIndex = 6;
            this.Rechenoperation.TabStop = false;
            this.Rechenoperation.Text = "Rechenoperation";
            // 
            // radioButtonMultiplikation
            // 
            this.radioButtonMultiplikation.AutoSize = true;
            this.radioButtonMultiplikation.Location = new System.Drawing.Point(7, 87);
            this.radioButtonMultiplikation.Name = "radioButtonMultiplikation";
            this.radioButtonMultiplikation.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMultiplikation.TabIndex = 3;
            this.radioButtonMultiplikation.Text = "Multiplikation";
            this.radioButtonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(7, 65);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDivision.TabIndex = 2;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraktion
            // 
            this.radioButtonSubtraktion.AutoSize = true;
            this.radioButtonSubtraktion.Location = new System.Drawing.Point(7, 41);
            this.radioButtonSubtraktion.Name = "radioButtonSubtraktion";
            this.radioButtonSubtraktion.Size = new System.Drawing.Size(79, 17);
            this.radioButtonSubtraktion.TabIndex = 1;
            this.radioButtonSubtraktion.Text = "Subtraktion";
            this.radioButtonSubtraktion.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Checked = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(7, 20);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Addition";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // ComboBoxAuswahl
            // 
            this.ComboBoxAuswahl.FormattingEnabled = true;
            this.ComboBoxAuswahl.Items.AddRange(new object[] {
            "Addition",
            "Subtraktion",
            "Mutliplikation",
            "Division"});
            this.ComboBoxAuswahl.Location = new System.Drawing.Point(172, 253);
            this.ComboBoxAuswahl.Name = "ComboBoxAuswahl";
            this.ComboBoxAuswahl.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxAuswahl.TabIndex = 7;
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 344);
            this.Controls.Add(this.ComboBoxAuswahl);
            this.Controls.Add(this.Rechenoperation);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.MaximizeBox = false;
            this.Name = "Taschenrechner";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Taschenrechner_Load);
            this.Rechenoperation.ResumeLayout(false);
            this.Rechenoperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.GroupBox Rechenoperation;
        private System.Windows.Forms.RadioButton radioButtonMultiplikation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonSubtraktion;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.ComboBox ComboBoxAuswahl;
    }
}