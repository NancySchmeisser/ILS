namespace CSHP10D
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
            this.Schließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Schließen
            // 
            this.Schließen.Location = new System.Drawing.Point(669, 376);
            this.Schließen.Name = "Schließen";
            this.Schließen.Size = new System.Drawing.Size(75, 23);
            this.Schließen.TabIndex = 0;
            this.Schließen.Text = "Schließen";
            this.Schließen.UseVisualStyleBackColor = true;
            this.Schließen.Click += new System.EventHandler(this.Schließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Schließen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Schließen;
    }
}

