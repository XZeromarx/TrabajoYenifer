namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarArchivo = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadPalabras = new System.Windows.Forms.TextBox();
            this.txtCantidadCaracteres = new System.Windows.Forms.TextBox();
            this.txtCantidadEspaciosBlancos = new System.Windows.Forms.TextBox();
            this.txtCantidadTabuladores = new System.Windows.Forms.TextBox();
            this.txtCantidadLineas = new System.Windows.Forms.TextBox();
            this.txtCantidadConsonantes = new System.Windows.Forms.TextBox();
            this.cboxOpcionesQuitar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.richTexto = new System.Windows.Forms.RichTextBox();
            this.txtCantidadVocales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresarArchivo
            // 
            this.txtIngresarArchivo.Location = new System.Drawing.Point(93, 44);
            this.txtIngresarArchivo.Name = "txtIngresarArchivo";
            this.txtIngresarArchivo.Size = new System.Drawing.Size(299, 20);
            this.txtIngresarArchivo.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(409, 44);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(90, 23);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracteres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Espacios en blanco :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tabuladores :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lineas :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vocales :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Consonantes :";
            // 
            // txtCantidadPalabras
            // 
            this.txtCantidadPalabras.Location = new System.Drawing.Point(182, 277);
            this.txtCantidadPalabras.Name = "txtCantidadPalabras";
            this.txtCantidadPalabras.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadPalabras.TabIndex = 11;
            this.txtCantidadPalabras.TextChanged += new System.EventHandler(this.txtCantidadPalabras_TextChanged);
            // 
            // txtCantidadCaracteres
            // 
            this.txtCantidadCaracteres.Location = new System.Drawing.Point(182, 311);
            this.txtCantidadCaracteres.Name = "txtCantidadCaracteres";
            this.txtCantidadCaracteres.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadCaracteres.TabIndex = 12;
            // 
            // txtCantidadEspaciosBlancos
            // 
            this.txtCantidadEspaciosBlancos.Location = new System.Drawing.Point(182, 350);
            this.txtCantidadEspaciosBlancos.Name = "txtCantidadEspaciosBlancos";
            this.txtCantidadEspaciosBlancos.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadEspaciosBlancos.TabIndex = 13;
            // 
            // txtCantidadTabuladores
            // 
            this.txtCantidadTabuladores.Location = new System.Drawing.Point(182, 388);
            this.txtCantidadTabuladores.Name = "txtCantidadTabuladores";
            this.txtCantidadTabuladores.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadTabuladores.TabIndex = 14;
            // 
            // txtCantidadLineas
            // 
            this.txtCantidadLineas.Location = new System.Drawing.Point(182, 425);
            this.txtCantidadLineas.Name = "txtCantidadLineas";
            this.txtCantidadLineas.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadLineas.TabIndex = 15;
            // 
            // txtCantidadConsonantes
            // 
            this.txtCantidadConsonantes.Location = new System.Drawing.Point(182, 499);
            this.txtCantidadConsonantes.Name = "txtCantidadConsonantes";
            this.txtCantidadConsonantes.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadConsonantes.TabIndex = 17;
            // 
            // cboxOpcionesQuitar
            // 
            this.cboxOpcionesQuitar.FormattingEnabled = true;
            this.cboxOpcionesQuitar.Location = new System.Drawing.Point(93, 591);
            this.cboxOpcionesQuitar.Name = "cboxOpcionesQuitar";
            this.cboxOpcionesQuitar.Size = new System.Drawing.Size(121, 21);
            this.cboxOpcionesQuitar.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quitar :";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(255, 594);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 20;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Location = new System.Drawing.Point(378, 594);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(89, 23);
            this.btnGuardarComo.TabIndex = 21;
            this.btnGuardarComo.Text = "Guardar Como..";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            // 
            // richTexto
            // 
            this.richTexto.Location = new System.Drawing.Point(44, 99);
            this.richTexto.Name = "richTexto";
            this.richTexto.Size = new System.Drawing.Size(423, 161);
            this.richTexto.TabIndex = 22;
            this.richTexto.Text = "";
            this.richTexto.TextChanged += new System.EventHandler(this.richTexto_TextChanged);
            // 
            // txtCantidadVocales
            // 
            this.txtCantidadVocales.Location = new System.Drawing.Point(182, 460);
            this.txtCantidadVocales.Name = "txtCantidadVocales";
            this.txtCantidadVocales.Size = new System.Drawing.Size(47, 20);
            this.txtCantidadVocales.TabIndex = 23;
            this.txtCantidadVocales.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 695);
            this.Controls.Add(this.txtCantidadVocales);
            this.Controls.Add(this.richTexto);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxOpcionesQuitar);
            this.Controls.Add(this.txtCantidadConsonantes);
            this.Controls.Add(this.txtCantidadLineas);
            this.Controls.Add(this.txtCantidadTabuladores);
            this.Controls.Add(this.txtCantidadEspaciosBlancos);
            this.Controls.Add(this.txtCantidadCaracteres);
            this.Controls.Add(this.txtCantidadPalabras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtIngresarArchivo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarArchivo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadPalabras;
        private System.Windows.Forms.TextBox txtCantidadCaracteres;
        private System.Windows.Forms.TextBox txtCantidadEspaciosBlancos;
        private System.Windows.Forms.TextBox txtCantidadTabuladores;
        private System.Windows.Forms.TextBox txtCantidadLineas;
        private System.Windows.Forms.TextBox txtCantidadConsonantes;
        private System.Windows.Forms.ComboBox cboxOpcionesQuitar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnGuardarComo;
        private System.Windows.Forms.RichTextBox richTexto;
        private System.Windows.Forms.TextBox txtCantidadVocales;
    }
}

