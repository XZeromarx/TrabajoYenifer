using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1 {

  
    
    public partial class Form1 : Form {
        private String palabra=string.Empty;
        private int Caracteres;
        private int espacios;
        private String Tabuladores;
        private String lineas;
        private int vocales=0;
        private int Consonantes;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnExaminar_Click(object sender, EventArgs e) {
            OpenFileDialog abrirDoc = new OpenFileDialog();
            abrirDoc.Filter = "Nuevo documento de texto|*.txt";
            abrirDoc.FileName = "Nuevo documento de texto";

            var abrirArchivo = abrirDoc.ShowDialog();
            if (abrirArchivo == DialogResult.OK) ;

            StreamReader leerArchivo = new StreamReader(abrirDoc.FileName);
            richTexto.Text = leerArchivo.ReadToEnd();
            leerArchivo.Close();

           
        }

        private void txtCantidadPalabras_TextChanged(object sender, EventArgs e) {
         

        }

        private void txtCantidadVocales_TextChanged(object sender, EventArgs e) {
            
            
        }

        private void richTexto_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            palabra = richTexto.Text.ToLower();
            for (int i = 0; i < palabra.Length; i++) {
                switch (palabra[i]) {
                    case 'a':
                        vocales += 1;
                        break;
                    case 'e':
                        vocales += 1;
                        break;
                    case 'i':
                        vocales += 1;
                        break;
                    case 'o':
                        vocales += 1;
                        break;
                    case 'u':
                        vocales += 1;
                        break;
                }
            }
            txtCantidadVocales.Text = vocales.ToString();
            txtCantidadVocales.Update();
        }
    }
}
