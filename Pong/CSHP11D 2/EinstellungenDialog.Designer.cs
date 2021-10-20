namespace Pong
{
    partial class EinstellungenDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaximal = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonÜbernehmenGröße = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMaximal);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton320);
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMaximal
            // 
            this.radioButtonMaximal.AutoSize = true;
            this.radioButtonMaximal.Location = new System.Drawing.Point(398, 36);
            this.radioButtonMaximal.Name = "radioButtonMaximal";
            this.radioButtonMaximal.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMaximal.TabIndex = 3;
            this.radioButtonMaximal.TabStop = true;
            this.radioButtonMaximal.Text = "Maximal";
            this.radioButtonMaximal.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(273, 36);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(77, 17);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.TabStop = true;
            this.radioButton1024.Text = "1024 * 768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Location = new System.Drawing.Point(158, 36);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(71, 17);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.TabStop = true;
            this.radioButton640.Text = "640 * 480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Location = new System.Drawing.Point(42, 36);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(71, 17);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.TabStop = true;
            this.radioButton320.Text = "320 * 200";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonÜbernehmenGröße
            // 
            this.buttonÜbernehmenGröße.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonÜbernehmenGröße.Location = new System.Drawing.Point(81, 147);
            this.buttonÜbernehmenGröße.Name = "buttonÜbernehmenGröße";
            this.buttonÜbernehmenGröße.Size = new System.Drawing.Size(92, 23);
            this.buttonÜbernehmenGröße.TabIndex = 1;
            this.buttonÜbernehmenGröße.Text = "Übernehmen";
            this.buttonÜbernehmenGröße.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(377, 147);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(123, 23);
            this.buttonAbbrechen.TabIndex = 2;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 210);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonÜbernehmenGröße);
            this.Controls.Add(this.groupBox1);
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spielfeld";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonÜbernehmenGröße;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.RadioButton radioButtonMaximal;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
    }
}