﻿namespace CSHP12D
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLesen = new System.Windows.Forms.Button();
            this.ButtonSchreiben = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ButtonLesen
            // 
            this.ButtonLesen.Location = new System.Drawing.Point(52, 116);
            this.ButtonLesen.Name = "ButtonLesen";
            this.ButtonLesen.Size = new System.Drawing.Size(75, 23);
            this.ButtonLesen.TabIndex = 1;
            this.ButtonLesen.Text = "Lesen";
            this.ButtonLesen.UseVisualStyleBackColor = true;
            this.ButtonLesen.Click += new System.EventHandler(this.ButtonLesen_Click);
            // 
            // ButtonSchreiben
            // 
            this.ButtonSchreiben.Location = new System.Drawing.Point(52, 157);
            this.ButtonSchreiben.Name = "ButtonSchreiben";
            this.ButtonSchreiben.Size = new System.Drawing.Size(75, 23);
            this.ButtonSchreiben.TabIndex = 2;
            this.ButtonSchreiben.Text = "Schreiben";
            this.ButtonSchreiben.UseVisualStyleBackColor = true;
            this.ButtonSchreiben.Click += new System.EventHandler(this.ButtonSchreiben_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 294);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonSchreiben);
            this.Controls.Add(this.ButtonLesen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLesen;
        private System.Windows.Forms.Button ButtonSchreiben;
        private System.Windows.Forms.TextBox textBox1;
    }
}

