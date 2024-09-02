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
   public partial class FrmDia : Form
   {
      public FrmDia()
      {
         InitializeComponent();
      }

      private void btnEvaluar_Click(object sender, EventArgs e)
      {
         Exercise exercise = new Exercise();
         int number = int.Parse(cmbDay.SelectedItem.ToString());
         string day = exercise.EvalueDay(number);
         MessageBox.Show(day);
      }
   }
}
