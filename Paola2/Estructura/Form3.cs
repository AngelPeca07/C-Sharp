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
    public partial class Form3 : Form
    {
        public Form3(float Res, float BD, int num1, int num2, float Res3)
        {
            InitializeComponent();
            txtBox1_form3.Text = num1 + " N";
            txtBox2_form3.Text = num2 + " N";
            txtBox3_form3.Text = Res + " N" + " (T)";
            txtBox4_form3.Text = BD + " N" + " (C)";
            txtBox5_form3.Text = Math.Abs(Res3) + " N" + " (T)";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
