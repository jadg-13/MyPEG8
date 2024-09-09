using Ejercicio1.models;
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
      GradeStorage grades = new GradeStorage();
      int index = 0;

      public Form1()
      {
         InitializeComponent();
      }

      private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
      {
         if(e.KeyChar == (char) Keys.Enter)
         {
            AddElement();
         }
      }

      private void AddElement()
      {
         try
         {
            int grade = Convert.ToInt32(tbGrade.Text);
            grades.AddElement(grade, index);
            index++;
            ShowGrades();
            tbGrade.Clear();
            tbGrade.Focus();
         }catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void ShowGrades()
      {
         try
         {
            lbGrades.Items.Clear();
            for(int i = 0; i < index; i++)
            {
               lbGrades.Items.Add(grades.GetGrades()[i]);
            }
            int sum = grades.GetGrades().Sum();
            double avg = sum / index;
            lblSum.Text = "Suma: "+ sum;
            lblAverage.Text = "Promedio: " + avg;
         }catch(Exception ex)
         {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
