namespace Matriz
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
         this.tbNumber = new System.Windows.Forms.TextBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.TbResult = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(32, 62);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Introduzca el #";
         // 
         // tbNumber
         // 
         this.tbNumber.Location = new System.Drawing.Point(118, 57);
         this.tbNumber.Name = "tbNumber";
         this.tbNumber.Size = new System.Drawing.Size(100, 20);
         this.tbNumber.TabIndex = 1;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(118, 88);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(100, 23);
         this.btnAdd.TabIndex = 2;
         this.btnAdd.Text = "Agregar";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // TbResult
         // 
         this.TbResult.Location = new System.Drawing.Point(35, 148);
         this.TbResult.Multiline = true;
         this.TbResult.Name = "TbResult";
         this.TbResult.Size = new System.Drawing.Size(240, 253);
         this.TbResult.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(298, 450);
         this.Controls.Add(this.TbResult);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.tbNumber);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbNumber;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.TextBox TbResult;
   }
}

