namespace Estructura
{
    partial class Resultado
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1_AB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_BD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_BC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(183, 397);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.ReadOnly = true;
            this.txtbox1.Size = new System.Drawing.Size(100, 26);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.Click += new System.EventHandler(this.txt2);
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(393, 12);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.ReadOnly = true;
            this.txtbox2.Size = new System.Drawing.Size(100, 26);
            this.txtbox2.TabIndex = 3;
            this.txtbox2.Click += new System.EventHandler(this.txt1);
            this.txtbox2.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estructura.Properties.Resources.Img3;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Calcular);
            // 
            // textBox1_AB
            // 
            this.textBox1_AB.Location = new System.Drawing.Point(833, 66);
            this.textBox1_AB.Name = "textBox1_AB";
            this.textBox1_AB.Size = new System.Drawing.Size(100, 26);
            this.textBox1_AB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resultado AB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado BD";
            // 
            // textBox1_BD
            // 
            this.textBox1_BD.Location = new System.Drawing.Point(833, 163);
            this.textBox1_BD.Name = "textBox1_BD";
            this.textBox1_BD.Size = new System.Drawing.Size(100, 26);
            this.textBox1_BD.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultado BC";
            // 
            // textBox1_BC
            // 
            this.textBox1_BC.Location = new System.Drawing.Point(837, 257);
            this.textBox1_BC.Name = "textBox1_BC";
            this.textBox1_BC.Size = new System.Drawing.Size(100, 26);
            this.textBox1_BC.TabIndex = 14;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.textBox1_BC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1_BD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_AB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtbox1;
        public System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1_AB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_BD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_BC;
    }
}