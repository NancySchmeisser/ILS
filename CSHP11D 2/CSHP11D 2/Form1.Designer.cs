namespace CSHP11D_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeld = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.spielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "&Spiel";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // spielfeld
            // 
            this.spielfeld.Controls.Add(this.schlaeger);
            this.spielfeld.Controls.Add(this.ball);
            this.spielfeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spielfeld.Location = new System.Drawing.Point(0, 24);
            this.spielfeld.Name = "spielfeld";
            this.spielfeld.Size = new System.Drawing.Size(624, 417);
            this.spielfeld.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(148, 270);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(200, 100);
            this.ball.TabIndex = 0;
            // 
            // schlaeger
            // 
            this.schlaeger.Location = new System.Drawing.Point(253, 143);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(200, 100);
            this.schlaeger.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.spielfeld);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pong";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spielfeld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel spielfeld;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Panel ball;
    }
}

