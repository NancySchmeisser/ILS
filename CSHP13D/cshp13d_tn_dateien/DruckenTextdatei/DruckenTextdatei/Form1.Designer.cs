namespace DruckenTextdatei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDrucken = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonVorschau = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // buttonDrucken
            // 
            this.buttonDrucken.Location = new System.Drawing.Point(115, 18);
            this.buttonDrucken.Name = "buttonDrucken";
            this.buttonDrucken.Size = new System.Drawing.Size(75, 23);
            this.buttonDrucken.TabIndex = 6;
            this.buttonDrucken.Text = "Drucken";
            this.buttonDrucken.UseVisualStyleBackColor = true;
            this.buttonDrucken.Click += new System.EventHandler(this.ButtonDrucken_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Textausgabe Demo";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // buttonVorschau
            // 
            this.buttonVorschau.Location = new System.Drawing.Point(115, 70);
            this.buttonVorschau.Name = "buttonVorschau";
            this.buttonVorschau.Size = new System.Drawing.Size(75, 23);
            this.buttonVorschau.TabIndex = 7;
            this.buttonVorschau.Text = "Vorschau";
            this.buttonVorschau.UseVisualStyleBackColor = true;
            this.buttonVorschau.Click += new System.EventHandler(this.ButtonVorschau_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.buttonDrucken);
            this.Controls.Add(this.buttonVorschau);
            this.Name = "Form1";
            this.Text = "Drucken einer Textdatei";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrucken;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonVorschau;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

