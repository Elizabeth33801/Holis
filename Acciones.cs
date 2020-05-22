using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holis
{
    class Acciones
    {
        public Acciones()
        {

        }

        Label label1 = new Label();

        public void Saludar()
        {
            label1.Text = "Holis";

            label1.Location = new Point(0, 0);
            label1.Size = new Size(20, 50);

        }
        public void DecirAdios()
        {
            label1.Text = "Adiuuu";
            label1.Location = new Point(0, 0);
            label1.Size = new Size(20, 50);

        }
    }
}
