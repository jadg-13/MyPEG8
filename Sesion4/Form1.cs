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
      public Form1()
      {
         InitializeComponent();
      }

      private void btnAumentar_Click(object sender, EventArgs e)
      {

         this.Opacity = (this.Opacity>= 1)?1: this.Opacity+= 0.01;
         mostrarOpacity();
      }

      private void btnDisminuir_Click(object sender, EventArgs e)
      {
         this.Opacity = (this.Opacity<=0.2)?0.2:  this.Opacity-= 0.01;
         mostrarOpacity();
      }

      private void mostrarOpacity()
      {
         this.Text = "";
         this.Text = "Ejemplo 1 - " + (this.Opacity * 100).ToString() + "%";
         if(this.Opacity < 0.5) {
            this.BackColor = Color.Red;
         }
         else
         {
            this.BackColor = Color.Green;
         }
      }

    
   }
}
