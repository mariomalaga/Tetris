/*
* PRÁCTICA.............: Práctica 10.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones Formulario III. Puerto Serie y Uso Dll’s.
* FECHA DE ENTREGA.....: 02 de Febrero de 2019
*/
using System;
using System.Windows.Forms;

namespace Tetris

{
    public partial class frmSplash : Form
    {
        private int contador = 0;
        public frmSplash()
        {
            InitializeComponent();
            tmrCargar.Enabled = true;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            contador = contador + 2;
            lblCargando.Text = "CARGANDO: " + contador + " %";
            progressBarCargar.Increment(2);
            if (progressBarCargar.Value == 100)
            {
                tmrCargar.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void progressBarCargar_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
