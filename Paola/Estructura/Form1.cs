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
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\Img1.PNG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario 2
            Corte2 obj2 = new Corte2();
            //Resultado obj = new Resultado();
            // Llamamos el objeto de el form2(Resultado) y lo ponemos visible
            obj2.Visible = true;
            //obj1.Visible = true;
            // Ocultamos el formulario 1 
            Visible = false;
        }
    }
}
