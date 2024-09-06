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
         this.label1 = new System.Windows.Forms.Label();
         this.tbTitulo = new System.Windows.Forms.TextBox();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.lbLibros = new System.Windows.Forms.ListBox();
         this.lbCopia = new System.Windows.Forms.ListBox();
         this.btnCopiar = new System.Windows.Forms.Button();
         this.btnMover = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(30, 35);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(51, 20);
         this.label1.TabIndex = 0;
         this.label1.Text = "Título:";
         // 
         // tbTitulo
         // 
         this.tbTitulo.Location = new System.Drawing.Point(98, 35);
         this.tbTitulo.Name = "tbTitulo";
         this.tbTitulo.Size = new System.Drawing.Size(236, 26);
         this.tbTitulo.TabIndex = 1;
         this.tbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitulo_KeyPress);
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(340, 31);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(75, 35);
         this.btnAgregar.TabIndex = 2;
         this.btnAgregar.Text = "Agregar";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(30, 98);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(134, 20);
         this.label2.TabIndex = 3;
         this.label2.Text = "Libros Agregados";
         // 
         // lbLibros
         // 
         this.lbLibros.FormattingEnabled = true;
         this.lbLibros.ItemHeight = 20;
         this.lbLibros.Location = new System.Drawing.Point(34, 133);
         this.lbLibros.Name = "lbLibros";
         this.lbLibros.Size = new System.Drawing.Size(381, 124);
         this.lbLibros.TabIndex = 4;
         this.lbLibros.Click += new System.EventHandler(this.lbLibros_Click);
         this.lbLibros.SelectedIndexChanged += new System.EventHandler(this.lbLibros_SelectedIndexChanged);
         // 
         // lbCopia
         // 
         this.lbCopia.FormattingEnabled = true;
         this.lbCopia.ItemHeight = 20;
         this.lbCopia.Location = new System.Drawing.Point(437, 133);
         this.lbCopia.Name = "lbCopia";
         this.lbCopia.Size = new System.Drawing.Size(381, 124);
         this.lbCopia.TabIndex = 5;
         this.lbCopia.Click += new System.EventHandler(this.lbCopia_Click);
         // 
         // btnCopiar
         // 
         this.btnCopiar.Location = new System.Drawing.Point(340, 86);
         this.btnCopiar.Name = "btnCopiar";
         this.btnCopiar.Size = new System.Drawing.Size(75, 32);
         this.btnCopiar.TabIndex = 6;
         this.btnCopiar.Text = "Copiar";
         this.btnCopiar.UseVisualStyleBackColor = true;
         this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
         // 
         // btnMover
         // 
         this.btnMover.Enabled = false;
         this.btnMover.Location = new System.Drawing.Point(437, 86);
         this.btnMover.Name = "btnMover";
         this.btnMover.Size = new System.Drawing.Size(104, 32);
         this.btnMover.TabIndex = 7;
         this.btnMover.Text = "Mover";
         this.btnMover.UseVisualStyleBackColor = true;
         this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(839, 289);
         this.Controls.Add(this.btnMover);
         this.Controls.Add(this.btnCopiar);
         this.Controls.Add(this.lbCopia);
         this.Controls.Add(this.lbLibros);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.tbTitulo);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Form1";
         this.Text = "Libros";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbTitulo;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ListBox lbLibros;
      private System.Windows.Forms.ListBox lbCopia;
      private System.Windows.Forms.Button btnCopiar;
      private System.Windows.Forms.Button btnMover;
   }
}

