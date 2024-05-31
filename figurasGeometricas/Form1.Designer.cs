using FiguraGeometrica;
using System.IO;

namespace figurasGeometricas
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
            this.CALC = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ESFERA = new System.Windows.Forms.RadioButton();
            this.PRISMA = new System.Windows.Forms.RadioButton();
            this.CUBO = new System.Windows.Forms.RadioButton();
            this.CIRCULO = new System.Windows.Forms.RadioButton();
            this.DATOS = new System.Windows.Forms.TextBox();
            this.POLIIRREC = new System.Windows.Forms.RadioButton();
            this.POLIREG = new System.Windows.Forms.RadioButton();
            this.RECTANGULO = new System.Windows.Forms.RadioButton();
            this.TRIANGULO = new System.Windows.Forms.RadioButton();
            this.CUADRADO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.EXPORT = new System.Windows.Forms.Button();
            this.DUBUJAR = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.INFORMACION = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CALC);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ESFERA);
            this.groupBox1.Controls.Add(this.PRISMA);
            this.groupBox1.Controls.Add(this.CUBO);
            this.groupBox1.Controls.Add(this.CIRCULO);
            this.groupBox1.Controls.Add(this.DATOS);
            this.groupBox1.Controls.Add(this.POLIIRREC);
            this.groupBox1.Controls.Add(this.POLIREG);
            this.groupBox1.Controls.Add(this.RECTANGULO);
            this.groupBox1.Controls.Add(this.TRIANGULO);
            this.groupBox1.Controls.Add(this.CUADRADO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EXPORT);
            this.groupBox1.Controls.Add(this.DUBUJAR);
            this.groupBox1.Controls.Add(this.INFO);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(699, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CALC
            // 
            this.CALC.Location = new System.Drawing.Point(536, 197);
            this.CALC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CALC.Name = "CALC";
            this.CALC.Size = new System.Drawing.Size(112, 35);
            this.CALC.TabIndex = 16;
            this.CALC.Text = "CALCULAR";
            this.CALC.UseVisualStyleBackColor = true;
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(416, 197);
            this.LIMPIAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(112, 35);
            this.LIMPIAR.TabIndex = 15;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO ETC";
            // 
            // ESFERA
            // 
            this.ESFERA.AutoSize = true;
            this.ESFERA.Location = new System.Drawing.Point(552, 108);
            this.ESFERA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ESFERA.Name = "ESFERA";
            this.ESFERA.Size = new System.Drawing.Size(100, 24);
            this.ESFERA.TabIndex = 13;
            this.ESFERA.TabStop = true;
            this.ESFERA.Text = "ESFERA";
            this.ESFERA.UseVisualStyleBackColor = true;
            // 
            // PRISMA
            // 
            this.PRISMA.AutoSize = true;
            this.PRISMA.Location = new System.Drawing.Point(444, 108);
            this.PRISMA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PRISMA.Name = "PRISMA";
            this.PRISMA.Size = new System.Drawing.Size(96, 24);
            this.PRISMA.TabIndex = 12;
            this.PRISMA.TabStop = true;
            this.PRISMA.Text = "PRISMA";
            this.PRISMA.UseVisualStyleBackColor = true;
            // 
            // CUBO
            // 
            this.CUBO.AutoSize = true;
            this.CUBO.Location = new System.Drawing.Point(360, 108);
            this.CUBO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CUBO.Name = "CUBO";
            this.CUBO.Size = new System.Drawing.Size(80, 24);
            this.CUBO.TabIndex = 12;
            this.CUBO.TabStop = true;
            this.CUBO.Text = "CUBO";
            this.CUBO.UseVisualStyleBackColor = true;
            // 
            // CIRCULO
            // 
            this.CIRCULO.AutoSize = true;
            this.CIRCULO.Location = new System.Drawing.Point(243, 108);
            this.CIRCULO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CIRCULO.Name = "CIRCULO";
            this.CIRCULO.Size = new System.Drawing.Size(106, 24);
            this.CIRCULO.TabIndex = 11;
            this.CIRCULO.TabStop = true;
            this.CIRCULO.Text = "CÍRCULO";
            this.CIRCULO.UseVisualStyleBackColor = true;
            // 
            // DATOS
            // 
            this.DATOS.Location = new System.Drawing.Point(416, 157);
            this.DATOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(109, 26);
            this.DATOS.TabIndex = 10;
            // 
            // POLIIRREC
            // 
            this.POLIIRREC.AutoSize = true;
            this.POLIIRREC.Location = new System.Drawing.Point(14, 108);
            this.POLIIRREC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.POLIIRREC.Name = "POLIIRREC";
            this.POLIIRREC.Size = new System.Drawing.Size(219, 24);
            this.POLIIRREC.TabIndex = 9;
            this.POLIIRREC.TabStop = true;
            this.POLIIRREC.Text = "POLÍGONO IRREGULAR";
            this.POLIIRREC.UseVisualStyleBackColor = true;
            // 
            // POLIREG
            // 
            this.POLIREG.AutoSize = true;
            this.POLIREG.Location = new System.Drawing.Point(444, 72);
            this.POLIREG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.POLIREG.Name = "POLIREG";
            this.POLIREG.Size = new System.Drawing.Size(202, 24);
            this.POLIREG.TabIndex = 8;
            this.POLIREG.TabStop = true;
            this.POLIREG.Text = "POLÍGONO REGULAR";
            this.POLIREG.UseVisualStyleBackColor = true;
            // 
            // RECTANGULO
            // 
            this.RECTANGULO.AutoSize = true;
            this.RECTANGULO.Location = new System.Drawing.Point(286, 72);
            this.RECTANGULO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RECTANGULO.Name = "RECTANGULO";
            this.RECTANGULO.Size = new System.Drawing.Size(145, 24);
            this.RECTANGULO.TabIndex = 7;
            this.RECTANGULO.TabStop = true;
            this.RECTANGULO.Text = "RECTÁNGULO";
            this.RECTANGULO.UseVisualStyleBackColor = true;
            // 
            // TRIANGULO
            // 
            this.TRIANGULO.AutoSize = true;
            this.TRIANGULO.Location = new System.Drawing.Point(150, 72);
            this.TRIANGULO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TRIANGULO.Name = "TRIANGULO";
            this.TRIANGULO.Size = new System.Drawing.Size(128, 24);
            this.TRIANGULO.TabIndex = 6;
            this.TRIANGULO.TabStop = true;
            this.TRIANGULO.Text = "TRIÁNGULO";
            this.TRIANGULO.UseVisualStyleBackColor = true;
            // 
            // CUADRADO
            // 
            this.CUADRADO.AutoSize = true;
            this.CUADRADO.Location = new System.Drawing.Point(14, 72);
            this.CUADRADO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CUADRADO.Name = "CUADRADO";
            this.CUADRADO.Size = new System.Drawing.Size(127, 24);
            this.CUADRADO.TabIndex = 5;
            this.CUADRADO.TabStop = true;
            this.CUADRADO.Text = "CUADRADO";
            this.CUADRADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMÉTRICAS";
            // 
            // EXPORT
            // 
            this.EXPORT.Location = new System.Drawing.Point(286, 197);
            this.EXPORT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EXPORT.Name = "EXPORT";
            this.EXPORT.Size = new System.Drawing.Size(112, 35);
            this.EXPORT.TabIndex = 3;
            this.EXPORT.Text = "EXPORTAR";
            this.EXPORT.UseVisualStyleBackColor = true;
            // 
            // DUBUJAR
            // 
            this.DUBUJAR.Location = new System.Drawing.Point(165, 197);
            this.DUBUJAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DUBUJAR.Name = "DUBUJAR";
            this.DUBUJAR.Size = new System.Drawing.Size(112, 35);
            this.DUBUJAR.TabIndex = 2;
            this.DUBUJAR.Text = "DIBUJAR";
            this.DUBUJAR.UseVisualStyleBackColor = true;
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(16, 197);
            this.INFO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(140, 35);
            this.INFO.TabIndex = 1;
            this.INFO.Text = "INFORMACIÓN";
            this.INFO.UseVisualStyleBackColor = true;
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(536, 152);
            this.GUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(112, 35);
            this.GUARDAR.TabIndex = 0;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.Image = global::figurasGeometricas.Properties.Resources.circulo;
            this.IMAGEN.Location = new System.Drawing.Point(20, 286);
            this.IMAGEN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(387, 388);
            this.IMAGEN.TabIndex = 1;
            this.IMAGEN.TabStop = false;
            // 
            // INFORMACION
            // 
            this.INFORMACION.Location = new System.Drawing.Point(416, 286);
            this.INFORMACION.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(301, 386);
            this.INFORMACION.TabIndex = 2;
            this.INFORMACION.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 692);
            this.Controls.Add(this.INFORMACION);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BIENVENID@";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CALC;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ESFERA;
        private System.Windows.Forms.RadioButton PRISMA;
        private System.Windows.Forms.RadioButton CUBO;
        private System.Windows.Forms.RadioButton CIRCULO;
        private System.Windows.Forms.TextBox DATOS;
        private System.Windows.Forms.RadioButton POLIIRREC;
        private System.Windows.Forms.RadioButton POLIREG;
        private System.Windows.Forms.RadioButton RECTANGULO;
        private System.Windows.Forms.RadioButton TRIANGULO;
        private System.Windows.Forms.RadioButton CUADRADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EXPORT;
        private System.Windows.Forms.Button DUBUJAR;
        private System.Windows.Forms.Button INFO;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.RichTextBox INFORMACION;
    }
}
