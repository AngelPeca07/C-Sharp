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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_form1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBox1_form1.Text))
            {
                string message = "Porfavor ingresa una fuerza en B" ;
                string title = "Advertencia";
                MessageBox.Show(message, title);
            }
            else if (String.IsNullOrEmpty(txtBox2_form1.Text))
            {
                string message = "Porfavor ingresa una fuerza en E";
                string title = "Advertencia";
                MessageBox.Show(message, title);
            }
            else if (String.IsNullOrEmpty(txtBox3_form1.Text))
            {
                string message = "Porfavor ingresa una fuerza en A";
                string title = "Advertencia";
                MessageBox.Show(message, title);
            }
            else
            {
                int num1, num2, num3;

                num1 = Convert.ToInt32(txtBox1_form1.Text);
                num2 = Convert.ToInt32(txtBox3_form1.Text);
                num3 = Convert.ToInt32(txtBox2_form1.Text);

                Form2 R = new Form2(num1, num2);
                R.Show();
            }
        }
    }
}
