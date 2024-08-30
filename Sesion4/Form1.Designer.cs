namespace Sesion4
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
         this.btnAumentar = new System.Windows.Forms.Button();
         this.btnDisminuir = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnAumentar
         // 
         this.btnAumentar.Location = new System.Drawing.Point(43, 54);
         this.btnAumentar.Name = "btnAumentar";
         this.btnAumentar.Size = new System.Drawing.Size(115, 58);
         this.btnAumentar.TabIndex = 0;
         this.btnAumentar.Text = "+";
         this.btnAumentar.UseVisualStyleBackColor = true;
         this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
         // 
         // btnDisminuir
         // 
         this.btnDisminuir.Location = new System.Drawing.Point(43, 118);
         this.btnDisminuir.Name = "btnDisminuir";
         this.btnDisminuir.Size = new System.Drawing.Size(115, 58);
         this.btnDisminuir.TabIndex = 1;
         this.btnDisminuir.Text = "-";
         this.btnDisminuir.UseVisualStyleBackColor = true;
         this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = System.Drawing.SystemColors.Highlight;
         this.ClientSize = new System.Drawing.Size(614, 749);
         this.Controls.Add(this.btnDisminuir);
         this.Controls.Add(this.btnAumentar);
         this.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ForeColor = System.Drawing.Color.Red;
         this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.Opacity = 0.75D;
         this.ShowIcon = false;
         this.Text = "Ejemplo1";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnAumentar;
      private System.Windows.Forms.Button btnDisminuir;
   }
}

