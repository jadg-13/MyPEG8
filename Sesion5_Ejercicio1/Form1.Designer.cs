namespace Sesion5_Ejercicio1
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tbNumber1 = new System.Windows.Forms.TextBox();
         this.tbNumber2 = new System.Windows.Forms.TextBox();
         this.btnMayor = new System.Windows.Forms.Button();
         this.lblAnswer = new System.Windows.Forms.Label();
         this.btnMenor = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.btnShowDay = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(39, 45);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(53, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Número1:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(36, 79);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Número 2:";
         // 
         // tbNumber1
         // 
         this.tbNumber1.Location = new System.Drawing.Point(98, 45);
         this.tbNumber1.Name = "tbNumber1";
         this.tbNumber1.Size = new System.Drawing.Size(100, 20);
         this.tbNumber1.TabIndex = 2;
         this.tbNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // tbNumber2
         // 
         this.tbNumber2.Location = new System.Drawing.Point(98, 79);
         this.tbNumber2.Name = "tbNumber2";
         this.tbNumber2.Size = new System.Drawing.Size(100, 20);
         this.tbNumber2.TabIndex = 3;
         this.tbNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnMayor
         // 
         this.btnMayor.Location = new System.Drawing.Point(89, 111);
         this.btnMayor.Name = "btnMayor";
         this.btnMayor.Size = new System.Drawing.Size(109, 23);
         this.btnMayor.TabIndex = 4;
         this.btnMayor.Text = "Evaluar Mayor";
         this.btnMayor.UseVisualStyleBackColor = true;
         this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
         // 
         // lblAnswer
         // 
         this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblAnswer.Location = new System.Drawing.Point(39, 181);
         this.lblAnswer.Name = "lblAnswer";
         this.lblAnswer.Size = new System.Drawing.Size(159, 23);
         this.lblAnswer.TabIndex = 5;
         // 
         // btnMenor
         // 
         this.btnMenor.Location = new System.Drawing.Point(89, 140);
         this.btnMenor.Name = "btnMenor";
         this.btnMenor.Size = new System.Drawing.Size(109, 23);
         this.btnMenor.TabIndex = 6;
         this.btnMenor.Text = "Evaluar Menor";
         this.btnMenor.UseVisualStyleBackColor = true;
         this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(204, 140);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(109, 23);
         this.button1.TabIndex = 8;
         this.button1.Text = "Evaluar Menor";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(204, 111);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(109, 23);
         this.button2.TabIndex = 7;
         this.button2.Text = "Evaluar Mayor";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // btnShowDay
         // 
         this.btnShowDay.Location = new System.Drawing.Point(318, 35);
         this.btnShowDay.Name = "btnShowDay";
         this.btnShowDay.Size = new System.Drawing.Size(95, 23);
         this.btnShowDay.TabIndex = 9;
         this.btnShowDay.Text = "Evaluar Día";
         this.btnShowDay.UseVisualStyleBackColor = true;
         this.btnShowDay.Click += new System.EventHandler(this.btnShowDay_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(440, 233);
         this.Controls.Add(this.btnShowDay);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnMenor);
         this.Controls.Add(this.lblAnswer);
         this.Controls.Add(this.btnMayor);
         this.Controls.Add(this.tbNumber2);
         this.Controls.Add(this.tbNumber1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sesión 5";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbNumber1;
      private System.Windows.Forms.TextBox tbNumber2;
      private System.Windows.Forms.Button btnMayor;
      private System.Windows.Forms.Label lblAnswer;
      private System.Windows.Forms.Button btnMenor;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button btnShowDay;
   }
}

