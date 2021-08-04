namespace CSHP10D_2._1
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
            this.Close = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.buttonKreis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(497, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(28, 11);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.DrawLine);
            // 
            // buttonKreis
            // 
            this.buttonKreis.Location = new System.Drawing.Point(110, 13);
            this.buttonKreis.Name = "buttonKreis";
            this.buttonKreis.Size = new System.Drawing.Size(75, 23);
            this.buttonKreis.TabIndex = 2;
            this.buttonKreis.Text = "Zeichne Kreis";
            this.buttonKreis.UseVisualStyleBackColor = true;
            this.buttonKreis.Click += new System.EventHandler(this.buttonKreis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 567);
            this.Controls.Add(this.buttonKreis);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Close);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button buttonKreis;
    }
}

