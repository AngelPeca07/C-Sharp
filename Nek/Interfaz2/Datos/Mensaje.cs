using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private void lbl_mensaje(object sender, EventArgs e)
        {

        }

        public Mensaje(String text)
        {
            InitializeComponent();
            lbl_mensaje.Text = "Mensaje recibido: " + text;
        }
    }
}
