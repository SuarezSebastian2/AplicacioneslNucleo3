namespace AplicacioneslNucleo3
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
            this.Dato1 = new System.Windows.Forms.Label();
            this.Dato2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dato1
            // 
            this.Dato1.AutoSize = true;
            this.Dato1.Location = new System.Drawing.Point(249, 46);
            this.Dato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(45, 17);
            this.Dato1.TabIndex = 0;
            this.Dato1.Text = "Dato1";
            // 
            // Dato2
            // 
            this.Dato2.AutoSize = true;
            this.Dato2.Location = new System.Drawing.Point(249, 124);
            this.Dato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(45, 17);
            this.Dato2.TabIndex = 1;
            this.Dato2.Text = "Dato2";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(237, 272);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(69, 17);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "Resultado";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(209, 67);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(132, 23);
            this.num1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(209, 145);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(132, 23);
            this.num2.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(209, 293);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(132, 23);
            this.result.TabIndex = 5;
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.Color.Lime;
            this.sumar.Location = new System.Drawing.Point(223, 205);
            this.sumar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(100, 30);
            this.sumar.TabIndex = 6;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.limpiar.Location = new System.Drawing.Point(223, 352);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 30);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacioneslNucleo3.Properties.Resources.matematicas;
            this.pictureBox1.Location = new System.Drawing.Point(40, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AplicacioneslNucleo3.Properties.Resources.prueba;
            this.pictureBox2.Location = new System.Drawing.Point(403, 245);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(563, 416);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Dato1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dato1;
        private System.Windows.Forms.Label Dato2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

