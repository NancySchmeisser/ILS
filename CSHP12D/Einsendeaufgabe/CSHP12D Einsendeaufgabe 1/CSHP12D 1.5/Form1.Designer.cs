namespace CSHP12D_1._5
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
            this.ButtonEinlesen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.ButtonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEinlesen
            // 
            this.ButtonEinlesen.Location = new System.Drawing.Point(20, 186);
            this.ButtonEinlesen.Name = "ButtonEinlesen";
            this.ButtonEinlesen.Size = new System.Drawing.Size(127, 23);
            this.ButtonEinlesen.TabIndex = 0;
            this.ButtonEinlesen.Text = "Einlesen";
            this.ButtonEinlesen.UseVisualStyleBackColor = true;
            this.ButtonEinlesen.Click += new System.EventHandler(this.ButtonEinlesen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 95);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(162, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(127, 95);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(310, 28);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(127, 95);
            this.listBox3.Sorted = true;
            this.listBox3.TabIndex = 3;
            // 
            // ButtonBeenden
            // 
            this.ButtonBeenden.Location = new System.Drawing.Point(310, 186);
            this.ButtonBeenden.Name = "ButtonBeenden";
            this.ButtonBeenden.Size = new System.Drawing.Size(127, 23);
            this.ButtonBeenden.TabIndex = 4;
            this.ButtonBeenden.Text = "Beenden";
            this.ButtonBeenden.UseVisualStyleBackColor = true;
            this.ButtonBeenden.Click += new System.EventHandler(this.ButtonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 247);
            this.Controls.Add(this.ButtonBeenden);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButtonEinlesen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEinlesen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button ButtonBeenden;
    }
}

