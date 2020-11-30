namespace Proyecto138controlesDado
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
            this.dado2 = new Proyecto138controlesDado.Dado();
            this.dado3 = new Proyecto138controlesDado.Dado();
            this.dado1 = new Proyecto138controlesDado.Dado();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dado2
            // 
            this.dado2.Location = new System.Drawing.Point(118, 12);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(100, 100);
            this.dado2.TabIndex = 1;
            this.dado2.Valor = 1;
            // 
            // dado3
            // 
            this.dado3.Location = new System.Drawing.Point(224, 12);
            this.dado3.Name = "dado3";
            this.dado3.Size = new System.Drawing.Size(100, 100);
            this.dado3.TabIndex = 2;
            this.dado3.Valor = 1;
            // 
            // dado1
            // 
            this.dado1.Location = new System.Drawing.Point(12, 12);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(100, 100);
            this.dado1.TabIndex = 3;
            this.dado1.Valor = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sortear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.dado3);
            this.Controls.Add(this.dado2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Dado dado2;
        private Dado dado3;
        private Dado dado1;
        private System.Windows.Forms.Button button1;
    }
}

