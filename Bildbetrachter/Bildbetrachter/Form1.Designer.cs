namespace Bildbetrachter
{
    partial class Bildbetrachter
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEinzel = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxNeuesFenster = new System.Windows.Forms.CheckBox();
            this.checkBoxOptimaleGröße = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonÖffnen = new System.Windows.Forms.Button();
            this.tabPageSchau = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPageEinzel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzel);
            this.tabControl1.Controls.Add(this.tabPageSchau);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEinzel
            // 
            this.tabPageEinzel.Controls.Add(this.pictureBox1);
            this.tabPageEinzel.Controls.Add(this.checkBoxNeuesFenster);
            this.tabPageEinzel.Controls.Add(this.checkBoxOptimaleGröße);
            this.tabPageEinzel.Controls.Add(this.textBox1);
            this.tabPageEinzel.Controls.Add(this.buttonAnzeigen);
            this.tabPageEinzel.Controls.Add(this.buttonBeenden);
            this.tabPageEinzel.Controls.Add(this.buttonÖffnen);
            this.tabPageEinzel.Location = new System.Drawing.Point(4, 22);
            this.tabPageEinzel.Name = "tabPageEinzel";
            this.tabPageEinzel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzel.Size = new System.Drawing.Size(768, 400);
            this.tabPageEinzel.TabIndex = 0;
            this.tabPageEinzel.Text = "Einzelbild";
            this.tabPageEinzel.UseVisualStyleBackColor = true;
            this.tabPageEinzel.Click += new System.EventHandler(this.tabPageEinzel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 339);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxNeuesFenster
            // 
            this.checkBoxNeuesFenster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNeuesFenster.AutoSize = true;
            this.checkBoxNeuesFenster.Location = new System.Drawing.Point(127, 377);
            this.checkBoxNeuesFenster.Name = "checkBoxNeuesFenster";
            this.checkBoxNeuesFenster.Size = new System.Drawing.Size(95, 17);
            this.checkBoxNeuesFenster.TabIndex = 5;
            this.checkBoxNeuesFenster.Text = "Neues Fenster";
            this.checkBoxNeuesFenster.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptimaleGröße
            // 
            this.checkBoxOptimaleGröße.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOptimaleGröße.AutoSize = true;
            this.checkBoxOptimaleGröße.Location = new System.Drawing.Point(22, 377);
            this.checkBoxOptimaleGröße.Name = "checkBoxOptimaleGröße";
            this.checkBoxOptimaleGröße.Size = new System.Drawing.Size(99, 17);
            this.checkBoxOptimaleGröße.TabIndex = 4;
            this.checkBoxOptimaleGröße.Text = "Optimale Größe";
            this.checkBoxOptimaleGröße.UseVisualStyleBackColor = true;
            this.checkBoxOptimaleGröße.CheckedChanged += new System.EventHandler(this.checkBoxOptimaleGröße_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(19, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(687, 6);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnzeigen.TabIndex = 2;
            this.buttonAnzeigen.Text = " Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(687, 64);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 1;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonÖffnen
            // 
            this.buttonÖffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonÖffnen.Location = new System.Drawing.Point(687, 35);
            this.buttonÖffnen.Name = "buttonÖffnen";
            this.buttonÖffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonÖffnen.TabIndex = 0;
            this.buttonÖffnen.Text = "Öffnen";
            this.buttonÖffnen.UseVisualStyleBackColor = true;
            this.buttonÖffnen.Click += new System.EventHandler(this.buttonÖffnen_Click);
            // 
            // tabPageSchau
            // 
            this.tabPageSchau.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchau.Name = "tabPageSchau";
            this.tabPageSchau.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchau.Size = new System.Drawing.Size(768, 400);
            this.tabPageSchau.TabIndex = 1;
            this.tabPageSchau.Text = "Bilderschau";
            this.tabPageSchau.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "Grafikdateien|*.bmp;*.gif;*.jpg;*.png;*.tif;*.wmf";
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Bildbetrachter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bildbetrachter";
            this.Text = "Bildbetrachter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageEinzel.ResumeLayout(false);
            this.tabPageEinzel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEinzel;
        private System.Windows.Forms.TabPage tabPageSchau;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonÖffnen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxNeuesFenster;
        private System.Windows.Forms.CheckBox checkBoxOptimaleGröße;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

