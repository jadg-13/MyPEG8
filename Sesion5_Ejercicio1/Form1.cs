using Sesion5_Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion5_Ejercicio1
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnMayor_Click(object sender, EventArgs e)
      {
         try
         {
            int num1 = Convert.ToInt16(tbNumber1.Text);
            int num2 = int.Parse(tbNumber2.Text);
            Exercise exercise = new Exercise();
            if (exercise.esMayor(num1, num2))
            {
               lblAnswer.Text = $"{num1} es mayor que {num2}";
            }
            else if (exercise.esMayor(num2, num1))
            {
               lblAnswer.Text = num2 + " es mayor que " + num1;
            }
            else
            {
               lblAnswer.Text = $"{num1} es igual a {num2}";
            }
         }catch (Exception ex)
         {
            lblAnswer.Text = ex.Message;
         }

      }

      private void btnMenor_Click(object sender, EventArgs e)
      {
         try
         {
            int num1 = Convert.ToInt32(tbNumber1.Text);
            int num2 = Convert.ToInt32(tbNumber2.Text);
            Exercise exercise = new Exercise();
            if (exercise.esMenor(num1, num2)) lblAnswer.Text = $"{num1} es menor que {num2}";
            else lblAnswer.Text = $"{num2} es menor que {num1}";
         }catch (Exception ex)
         {
            lblAnswer.Text = ex.Message;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         int num1 = int.Parse(tbNumber1.Text);
         int num2 = int.Parse(tbNumber2.Text);
         var res = Math.Max(num1, num2);
         lblAnswer.Text = "El mayor es " +res.ToString();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         int num1 = int.Parse(tbNumber1.Text);
         int num2 = int.Parse(tbNumber2.Text);
         var res = Math.Min(num1, num2);
         lblAnswer.Text = "El menor es " + res.ToString();
      }

      private void btnShowDay_Click(object sender, EventArgs e)
      {
         FrmDia frmDia = new FrmDia();
         frmDia.Show();
      }
   }
}
