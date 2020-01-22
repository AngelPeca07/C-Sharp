using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura
{
    public partial class Form2 : Form
    {
        public Form2(int num1, int num2)
        {
            InitializeComponent();
            txtBox1_form2.Text = num1 + " N";
            txtBox2_form2.Text = num2 + " N";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBox1_form2.Text) || String.IsNullOrEmpty(txtBox2_form2.Text))
            {
                string message = "Porfavor ingresa un valor";
                string title = "Advertencia";
                MessageBox.Show(message, title);
            }
            else
            {
                int num1, num2;
                float n0, num3, Res, Res2, BD, s, Res3, c;

                num1 = Convert.ToInt32(txtBox3_form2.Text);//Valor arriba
                num2 = Convert.ToInt32(txtBox4_form2.Text);//Valor de abajo
                num3 = 4;
                n0 = 7.8413814f;
                s = 0.9806146f;
                c = 0.1959461f;

                //Calculos de AB
                Res = (num3 * num2) / n0;

                //Calculos de BD
                Res2 = -num1 - num2 + (Res * s);
                BD = (Math.Abs(Res2 / s));

                //Calculos de BC
                Res3 = ((Res * c) - (BD * c));

                Form3 R1 = new Form3(Res, BD, num1, num2, Res3);
                R1.Show();
            }
        }
    }
}
