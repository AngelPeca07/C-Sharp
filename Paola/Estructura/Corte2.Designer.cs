﻿namespace Estructura
{
    partial class Corte2
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
            this.textBox1_Corte2 = new System.Windows.Forms.TextBox();
            this.textBox2_Corte2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_Corte2
            // 
            this.textBox1_Corte2.Location = new System.Drawing.Point(396, 12);
            this.textBox1_Corte2.Name = "textBox1_Corte2";
            this.textBox1_Corte2.Size = new System.Drawing.Size(72, 26);
            this.textBox1_Corte2.TabIndex = 1;
            // 
            // textBox2_Corte2
            // 
            this.textBox2_Corte2.Location = new System.Drawing.Point(192, 377);
            this.textBox2_Corte2.Name = "textBox2_Corte2";
            this.textBox2_Corte2.Size = new System.Drawing.Size(72, 26);
            this.textBox2_Corte2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese fuerzas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttCorte2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estructura.Properties.Resources.Img2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Corte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_Corte2);
            this.Controls.Add(this.textBox1_Corte2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Corte2";
            this.Text = "Corte2";
            this.Load += new System.EventHandler(this.Corte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_Corte2;
        private System.Windows.Forms.TextBox textBox2_Corte2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}