/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: Mario Olivera Castañeda
* CURSO y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 03 de Marzo de 2019
*/
using System;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmCambiarTamano : Form
    {
        private static int columnas = Constantes.COLUMNAS_PANTALLA;
        private static int filas = Constantes.FILAS_PANTALLA;

        public static int Columnas { get => columnas; set => columnas = value; }
        public static int Filas { get => filas; set => filas = value; }

        public frmCambiarTamano()
        {
            InitializeComponent();
            txtColumnas.Text = "" + Columnas;
            txtFilas.Text = "" + Filas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (int.Parse(txtColumnas.Text) > 30 || int.Parse(txtColumnas.Text) < 5)
            {
                erpTamano.SetError(txtColumnas, "Un valor entre 5 y 30");
                contador++;
            }
            else
            {
                erpTamano.Clear();
            }
            if (int.Parse(txtFilas.Text) > 30 || int.Parse(txtFilas.Text) < 5)
            {
                erpTamano.SetError(txtFilas, "Un valor entre 5 y 30");
                contador++;
            }
            else
            {
                erpTamano.Clear();
            }
            if (contador == 0)
            {
                Columnas = int.Parse(txtColumnas.Text);
                Filas = int.Parse(txtFilas.Text);
                this.Dispose();
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
