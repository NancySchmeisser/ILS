namespace CSHP12D_1._4
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
            this.ButtonLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLoeschen
            // 
            this.ButtonLoeschen.Location = new System.Drawing.Point(161, 82);
            this.ButtonLoeschen.Name = "ButtonLoeschen";
            this.ButtonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoeschen.TabIndex = 0;
            this.ButtonLoeschen.Text = "Löschen";
            this.ButtonLoeschen.UseVisualStyleBackColor = true;
            this.ButtonLoeschen.Click += new System.EventHandler(this.ButtonLoeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 125);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonLoeschen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoeschen;
    }
}

