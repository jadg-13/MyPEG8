using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Matriz
{
   public partial class Form1 : Form
   {

      int[,] matrizA = new int[4, 4];
      int[, ] matrizB = new int[4, 4];
      int r=0, c=0;

      public Form1()
      {
         InitializeComponent();
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         int number = int.Parse( tbNumber.Text);
         if(r < 4)
         {
            if (c < 4)
            {
               matrizA[r, c] = number;
               tbNumber.Clear();
               
               c++;
               
               if(c == 4)
               {
                  c = 0;
                  r++;
               }
               this.Text = "r = " + r + ", c " + c;
               tbNumber.Focus();
            }
            
         }
         else
         {
            MessageBox.Show("Nohay espacio");
         }
         mostrarMatriz();

      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this.Text = "r = " + r + ", c " + c;
      }

      public void mostrarMatriz()
      {
         string texto = "";
         for(int i = 0; i<4; i++)
         {
            for(int j = 0; j < 4; j++)
            {
               texto += matrizA[i, j];
               
            }
            texto += Environment.NewLine;
         }
         TbResult.Text = texto;
      }
   }
}
