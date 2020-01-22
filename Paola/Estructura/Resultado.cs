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
    public partial class Resultado : Form
    {
        public Resultado(float Res, float BD, int num1, int num2, float Res3)
        {
            InitializeComponent();
            txtbox1.Text = num2 + " N";
            txtbox2.Text = num1 + " N";
            textBox1_AB.Text = Res + " N";
            textBox1_BD.Text = BD + " N";
            textBox1_BC.Text = Math.Abs(Res3) + " N";

        }

        private void Resultado_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Corte2 obj_ = new Corte2();
            obj_.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular(object sender, EventArgs e)
        {
            int num1, num2, num3, suma;
            float n0,Res;
         
            num1 = Convert.ToInt32(txtbox1.Text);//Valor abajo
            num2 = Convert.ToInt32(txtbox2.Text);//Valor de arriba
            num3 = 4;
            n0 = 7.84f;

            Res = (num3 * num1) / n0;


            suma = num1 + num2;

           
        }

        private void txt1(object sender, EventArgs e)
        {

        }

        private void txt2(object sender, EventArgs e)
        {

        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
