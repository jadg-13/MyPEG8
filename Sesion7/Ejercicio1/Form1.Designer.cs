namespace Ejercicio1
{
   partial class Form1
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.tbGrade = new System.Windows.Forms.TextBox();
         this.lbGrades = new System.Windows.Forms.ListBox();
         this.lblSum = new System.Windows.Forms.Label();
         this.lblAverage = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.lblAverage);
         this.groupBox1.Controls.Add(this.lblSum);
         this.groupBox1.Controls.Add(this.lbGrades);
         this.groupBox1.Controls.Add(this.tbGrade);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(37, 34);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(239, 316);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Registro Notas";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(20, 49);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(119, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ingrese la nota:";
         // 
         // tbGrade
         // 
         this.tbGrade.Location = new System.Drawing.Point(150, 47);
         this.tbGrade.Name = "tbGrade";
         this.tbGrade.Size = new System.Drawing.Size(67, 26);
         this.tbGrade.TabIndex = 1;
         this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
         // 
         // lbGrades
         // 
         this.lbGrades.FormattingEnabled = true;
         this.lbGrades.ItemHeight = 20;
         this.lbGrades.Location = new System.Drawing.Point(20, 82);
         this.lbGrades.Name = "lbGrades";
         this.lbGrades.Size = new System.Drawing.Size(197, 144);
         this.lbGrades.TabIndex = 2;
         // 
         // lblSum
         // 
         this.lblSum.Location = new System.Drawing.Point(68, 239);
         this.lblSum.Name = "lblSum";
         this.lblSum.Size = new System.Drawing.Size(149, 21);
         this.lblSum.TabIndex = 3;
         this.lblSum.Text = "Suma: 0";
         this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblAverage
         // 
         this.lblAverage.Location = new System.Drawing.Point(72, 271);
         this.lblAverage.Name = "lblAverage";
         this.lblAverage.Size = new System.Drawing.Size(145, 21);
         this.lblAverage.TabIndex = 4;
         this.lblAverage.Text = "Promedio: 0";
         this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(348, 381);
         this.Controls.Add(this.groupBox1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Arreglos";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label lblAverage;
      private System.Windows.Forms.Label lblSum;
      private System.Windows.Forms.ListBox lbGrades;
      private System.Windows.Forms.TextBox tbGrade;
      private System.Windows.Forms.Label label1;
   }
}

