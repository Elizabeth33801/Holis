using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holis
{
  class Acciones
  {
    Label label1;
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
      //agregue una clase llamada acciones es un cambio que tengo que sincronizar
    }
  }
}
