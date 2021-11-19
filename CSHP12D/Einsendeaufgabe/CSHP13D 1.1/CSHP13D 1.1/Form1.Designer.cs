namespace CSHP13D_1._1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtonLaden = new System.Windows.Forms.Button();
            this.ButtonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 160);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ButtonLaden
            // 
            this.ButtonLaden.Location = new System.Drawing.Point(12, 179);
            this.ButtonLaden.Name = "ButtonLaden";
            this.ButtonLaden.Size = new System.Drawing.Size(75, 23);
            this.ButtonLaden.TabIndex = 1;
            this.ButtonLaden.Text = "Laden";
            this.ButtonLaden.UseVisualStyleBackColor = true;
            this.ButtonLaden.Click += new System.EventHandler(this.ButtonLaden_Click);
            // 
            // ButtonSpeichern
            // 
            this.ButtonSpeichern.Location = new System.Drawing.Point(12, 209);
            this.ButtonSpeichern.Name = "ButtonSpeichern";
            this.ButtonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpeichern.TabIndex = 2;
            this.ButtonSpeichern.Text = "Speichern";
            this.ButtonSpeichern.UseVisualStyleBackColor = true;
            this.ButtonSpeichern.Click += new System.EventHandler(this.ButtonSpeichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.ButtonSpeichern);
            this.Controls.Add(this.ButtonLaden);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButtonLaden;
        private System.Windows.Forms.Button ButtonSpeichern;
    }
}

