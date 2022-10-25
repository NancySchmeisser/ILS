namespace Verwaltung
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
            this.buttonLesen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelLW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLesen
            // 
            this.buttonLesen.Location = new System.Drawing.Point(257, 86);
            this.buttonLesen.Name = "buttonLesen";
            this.buttonLesen.Size = new System.Drawing.Size(85, 23);
            this.buttonLesen.TabIndex = 31;
            this.buttonLesen.Text = "Ordner lesen";
            this.buttonLesen.UseVisualStyleBackColor = true;
            this.buttonLesen.Click += new System.EventHandler(this.ButtonLesen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(257, 223);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(85, 23);
            this.buttonBeenden.TabIndex = 30;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(257, 123);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(85, 23);
            this.buttonLoeschen.TabIndex = 29;
            this.buttonLoeschen.Text = "Datei löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.ButtonLoeschen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Dateien im Ordner \\test";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 160);
            this.listBox1.TabIndex = 27;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(257, 15);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(85, 23);
            this.buttonInfo.TabIndex = 26;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // labelLW
            // 
            this.labelLW.AutoSize = true;
            this.labelLW.Location = new System.Drawing.Point(72, 20);
            this.labelLW.Name = "labelLW";
            this.labelLW.Size = new System.Drawing.Size(35, 13);
            this.labelLW.TabIndex = 25;
            this.labelLW.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Laufwerk:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.buttonLesen);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelLW);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Datei- und Orderfunktionen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLesen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelLW;
        private System.Windows.Forms.Label label1;
    }
}

