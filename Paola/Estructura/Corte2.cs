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
    public partial class Corte2 : Form
    {
        public Corte2()
        {
            InitializeComponent();
            //Bitmap img = new Bitmap(Application.StartupPath + @"\img\Img2.PNG");
            //this.BackgroundImage = img;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Corte2_Load(object sender, EventArgs e)
        {

        }

        private void buttCorte2_Click(object sender, EventArgs e)
        {
            int num1, num2;
            float n0, num3, Res, Res2, BD, s, Res3, c;

            num1 = Convert.ToInt32(textBox1_Corte2.Text);//Valor arriba
            num2 = Convert.ToInt32(textBox2_Corte2.Text);//Valor de abajo
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
            Res3 = ((Res * c) - (BD*c)); 

            Resultado R = new Resultado(Res, BD, num1, num2,Res3);
            R.Show();
        }
    }
}
