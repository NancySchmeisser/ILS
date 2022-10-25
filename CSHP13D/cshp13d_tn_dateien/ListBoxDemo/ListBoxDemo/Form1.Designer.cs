namespace ListBoxDemo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEinfuegen = new System.Windows.Forms.Button();
            this.buttonLaden = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // buttonEinfuegen
            // 
            this.buttonEinfuegen.Location = new System.Drawing.Point(262, 192);
            this.buttonEinfuegen.Name = "buttonEinfuegen";
            this.buttonEinfuegen.Size = new System.Drawing.Size(100, 23);
            this.buttonEinfuegen.TabIndex = 13;
            this.buttonEinfuegen.Text = "Einfügen";
            this.buttonEinfuegen.UseVisualStyleBackColor = true;
            this.buttonEinfuegen.Click += new System.EventHandler(this.ButtonEinfuegen_Click);
            // 
            // buttonLaden
            // 
            this.buttonLaden.Location = new System.Drawing.Point(262, 45);
            this.buttonLaden.Name = "buttonLaden";
            this.buttonLaden.Size = new System.Drawing.Size(100, 23);
            this.buttonLaden.TabIndex = 12;
            this.buttonLaden.Text = "Laden";
            this.buttonLaden.UseVisualStyleBackColor = true;
            this.buttonLaden.Click += new System.EventHandler(this.ButtonLaden_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(262, 16);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(100, 23);
            this.buttonSpeichern.TabIndex = 11;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.ButtonSpeichern_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 199);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEinfuegen);
            this.Controls.Add(this.buttonLaden);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "ListBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEinfuegen;
        private System.Windows.Forms.Button buttonLaden;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.ListBox listBox1;
    }
}

