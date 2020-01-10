/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: Mario Olivera Castañeda
* CURSO y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 03 de Marzo de 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmPuntuacion : Form
    {
        public frmPuntuacion()
        {
            InitializeComponent();
        }

        private void frmPuntuacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (txtPuntuacion.Text.Length <= 0  || txtPuntuacion.Text.Length > 5)
            {
                erpPuntuacion.SetError(txtPuntuacion, "Un valor entre 1 y 5");
                contador++;
            }
            else
            {
                erpPuntuacion.Clear();
            }
            if (contador == 0)
            {
                string path = @".\\puntuacion.txt";
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.WriteLine(txtPuntuacion.Text + "-" + Tetris.Puntuacion);
                sw.Close();
                this.Dispose();
            }
        }
    }
}
