using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion4
{
   public partial class Form1 : Form
   {
      public int Porcentaje { get; set; }

      public Form1()
      {
         InitializeComponent();
         Porcentaje = (int)(this.Opacity * 100);
         nudPorcentaje.Value = Porcentaje;
      }

      private void btnAumentar_Click(object sender, EventArgs e)
      {
         this.Opacity = (this.Opacity >= 1) ? 1 : this.Opacity += 0.01;
         mostrarOpacity();
         this.nudPorcentaje.Value = (int)(this.Opacity * 100);
      }

      private void btnDisminuir_Click(object sender, EventArgs e)
      {
         this.Opacity = (this.Opacity <= 0.2) ? 0.2 : this.Opacity -= 0.01;
         mostrarOpacity();
         this.nudPorcentaje.Value = (int)(this.Opacity * 100);
      }

      private void mostrarOpacity()
      {
         this.Text = "";
         this.Text = "Ejemplo 1 - " + (this.Opacity * 100) + "%";

         if (this.Opacity < 0.5)
         {
            this.BackColor = Color.Red;
         }
         else
         {
            this.BackColor = Color.Green;
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void nudPorcentaje_ValueChanged(object sender, EventArgs e)
      {
         this.Opacity=  (double) (nudPorcentaje.Value/100);
         mostrarOpacity();
         progressBar1.Value = (int) nudPorcentaje.Value;

      }
   }
}
