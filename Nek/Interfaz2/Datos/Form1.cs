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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Obtener_texto(object sender, EventArgs e)
        {
            String nombre = boxName.Text; // Obtener el texto de un textbox    
            Mensaje m = new Mensaje();
            m.Visible = true;
           
        }
    }
}
