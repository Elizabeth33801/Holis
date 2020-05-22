using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holis
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Acciones claseAcciones = new Acciones();


        private void button1_Click(object sender, EventArgs e)
        {
            claseAcciones.Saludar();
        }

        private void btnPushme_Click(object sender, EventArgs e)
        {
            lblCool.Visible = true;
        }
    }
}
