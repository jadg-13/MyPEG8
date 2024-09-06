using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
   public partial class Form1 : Form
   {

      bool moverLibro = true;
      public Form1()
      {
         InitializeComponent();
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         agregar();
      }

      private void agregar()
      {
         if(tbTitulo.Text.Trim().Length > 0)
         {
            string titulo = tbTitulo.Text.Trim();
            lbLibros.Items.Add(titulo);
            tbTitulo.Clear();
            tbTitulo.Focus();
         }
      }

      private void tbTitulo_KeyPress(object sender, KeyPressEventArgs e)
      {
         if(e.KeyChar == (char) Keys.Enter)
         {
            agregar();
         }
      }

      private void btnCopiar_Click(object sender, EventArgs e)
      {
         int cant = lbLibros.Items.Count;
         for(int i=0; i < cant; i++)
         {
            string titulo = lbLibros.Items[i].ToString();
            lbCopia.Items.Add(titulo);
         }

      }

      private void btnMover_Click(object sender, EventArgs e)
      {
         if (moverLibro)
         {

            if (lbLibros.Items.Count > 0)
            {
               string titulo = lbLibros.SelectedItem.ToString();
               lbCopia.Items.Add(titulo);
               int index = lbLibros.SelectedIndex;
               lbLibros.Items.RemoveAt(index);
               btnMover.Enabled = false;
            }
         }
         else
         {
            if (lbCopia.Items.Count > 0)
            {
               string titulo = lbCopia.SelectedItem.ToString();
               lbLibros.Items.Add(titulo);
               int index = lbCopia.SelectedIndex;
               lbCopia.Items.RemoveAt(index);
               btnMover.Enabled = false;
            }
         }
      }

      private void lbLibros_Click(object sender, EventArgs e)
      {
         if (lbLibros.Items.Count > 0)
         {
            btnMover.Enabled = true;
            moverLibro = true;
         }
      }

      private void lbCopia_Click(object sender, EventArgs e)
      {
         if(lbCopia.Items.Count > 0)
         {
            btnMover.Enabled = true;
            moverLibro = false;
         }
      }

      private void lbLibros_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
