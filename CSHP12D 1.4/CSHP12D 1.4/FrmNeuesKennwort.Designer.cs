namespace CSHP12D_1._4
{
    partial class FrmNeuesKennwort
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
            this.ButtonUebernehmen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxKennwort1 = new System.Windows.Forms.TextBox();
            this.textBoxKennwort2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonUebernehmen
            // 
            this.ButtonUebernehmen.Location = new System.Drawing.Point(35, 158);
            this.ButtonUebernehmen.Name = "ButtonUebernehmen";
            this.ButtonUebernehmen.Size = new System.Drawing.Size(94, 23);
            this.ButtonUebernehmen.TabIndex = 0;
            this.ButtonUebernehmen.Text = "Übernehmen";
            this.ButtonUebernehmen.UseVisualStyleBackColor = true;
            this.ButtonUebernehmen.Click += new System.EventHandler(this.ButtonUebernehmen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxKennwort1
            // 
            this.textBoxKennwort1.Location = new System.Drawing.Point(35, 58);
            this.textBoxKennwort1.Name = "textBoxKennwort1";
            this.textBoxKennwort1.Size = new System.Drawing.Size(209, 20);
            this.textBoxKennwort1.TabIndex = 2;
            this.textBoxKennwort1.UseSystemPasswordChar = true;
            // 
            // textBoxKennwort2
            // 
            this.textBoxKennwort2.Location = new System.Drawing.Point(35, 113);
            this.textBoxKennwort2.Name = "textBoxKennwort2";
            this.textBoxKennwort2.Size = new System.Drawing.Size(209, 20);
            this.textBoxKennwort2.TabIndex = 3;
            this.textBoxKennwort2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bitte geben Sie Ihr neues Kennwort ein:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bitte wiederholen Sie die Eingabe:";
            // 
            // FrmNeuesKennwort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 211);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKennwort2);
            this.Controls.Add(this.textBoxKennwort1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonUebernehmen);
            this.Name = "FrmNeuesKennwort";
            this.Text = "Neues Kennwort eingeben";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonUebernehmen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxKennwort1;
        private System.Windows.Forms.TextBox textBoxKennwort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}