namespace CSHP10D_3._1
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonEnden = new System.Windows.Forms.Button();
            this.buttonFüllen = new System.Windows.Forms.Button();
            this.buttonVerlauf = new System.Windows.Forms.Button();
            this.buttonTexte = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(482, 426);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(497, 12);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(75, 23);
            this.buttonEasy.TabIndex = 1;
            this.buttonEasy.Text = "Sehr einfach";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonEnden
            // 
            this.buttonEnden.Location = new System.Drawing.Point(497, 54);
            this.buttonEnden.Name = "buttonEnden";
            this.buttonEnden.Size = new System.Drawing.Size(75, 23);
            this.buttonEnden.TabIndex = 2;
            this.buttonEnden.Text = "Mit Enden";
            this.buttonEnden.UseVisualStyleBackColor = true;
            this.buttonEnden.Click += new System.EventHandler(this.buttonEnden_Click);
            // 
            // buttonFüllen
            // 
            this.buttonFüllen.Location = new System.Drawing.Point(497, 143);
            this.buttonFüllen.Name = "buttonFüllen";
            this.buttonFüllen.Size = new System.Drawing.Size(75, 23);
            this.buttonFüllen.TabIndex = 3;
            this.buttonFüllen.Text = "Füllen";
            this.buttonFüllen.UseVisualStyleBackColor = true;
            this.buttonFüllen.Click += new System.EventHandler(this.buttonFüllen_Click);
            // 
            // buttonVerlauf
            // 
            this.buttonVerlauf.Location = new System.Drawing.Point(497, 100);
            this.buttonVerlauf.Name = "buttonVerlauf";
            this.buttonVerlauf.Size = new System.Drawing.Size(75, 23);
            this.buttonVerlauf.TabIndex = 4;
            this.buttonVerlauf.Text = "Verläufe";
            this.buttonVerlauf.UseVisualStyleBackColor = true;
            this.buttonVerlauf.Click += new System.EventHandler(this.buttonVerlauf_Click);
            // 
            // buttonTexte
            // 
            this.buttonTexte.Location = new System.Drawing.Point(497, 184);
            this.buttonTexte.Name = "buttonTexte";
            this.buttonTexte.Size = new System.Drawing.Size(75, 23);
            this.buttonTexte.TabIndex = 5;
            this.buttonTexte.Text = "Texte";
            this.buttonTexte.UseVisualStyleBackColor = true;
            this.buttonTexte.Click += new System.EventHandler(this.buttonTexte_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(482, 397);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Zurücksetzen";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTexte);
            this.Controls.Add(this.buttonVerlauf);
            this.Controls.Add(this.buttonFüllen);
            this.Controls.Add(this.buttonEnden);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.buttonClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonEnden;
        private System.Windows.Forms.Button buttonFüllen;
        private System.Windows.Forms.Button buttonVerlauf;
        private System.Windows.Forms.Button buttonTexte;
        private System.Windows.Forms.Button buttonClear;
    }
}

