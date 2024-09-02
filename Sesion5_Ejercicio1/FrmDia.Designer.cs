namespace Sesion5_Ejercicio1
{
   partial class FrmDia
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.cmbDay = new System.Windows.Forms.ComboBox();
         this.btnEvaluar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(34, 39);
         this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(134, 22);
         this.label1.TabIndex = 0;
         this.label1.Text = "Seleciona un #:";
         // 
         // cmbDay
         // 
         this.cmbDay.FormattingEnabled = true;
         this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
         this.cmbDay.Location = new System.Drawing.Point(193, 36);
         this.cmbDay.Name = "cmbDay";
         this.cmbDay.Size = new System.Drawing.Size(85, 28);
         this.cmbDay.TabIndex = 1;
         // 
         // btnEvaluar
         // 
         this.btnEvaluar.Location = new System.Drawing.Point(295, 30);
         this.btnEvaluar.Name = "btnEvaluar";
         this.btnEvaluar.Size = new System.Drawing.Size(116, 39);
         this.btnEvaluar.TabIndex = 2;
         this.btnEvaluar.Text = "Mostrar Día";
         this.btnEvaluar.UseVisualStyleBackColor = true;
         this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
         // 
         // FrmDia
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(433, 172);
         this.Controls.Add(this.btnEvaluar);
         this.Controls.Add(this.cmbDay);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
         this.Name = "FrmDia";
         this.Text = "FrmDia";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbDay;
      private System.Windows.Forms.Button btnEvaluar;
   }
}