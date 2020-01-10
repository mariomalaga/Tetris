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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            string line;
            List<string> nombres = new List<string>();
            List<string> puntuaciones = new List<string>();
            InitializeComponent();
            StreamReader file = new System.IO.StreamReader(@".\\puntuacion.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] puntuacion = line.Split('-');
                nombres.Add(puntuacion[0]);
                puntuaciones.Add(puntuacion[1]);
            }

            file.Close();

            for (int x = 0; x < puntuaciones.Count; x++)
            {
                for (int i = 0; i < puntuaciones.Count - x - 1; i++)
                {
                    if (int.Parse(puntuaciones[i]) < int.Parse(puntuaciones[i + 1]))
                    {
                        int tmp = int.Parse(puntuaciones[i + 1]);
                        puntuaciones[i + 1] = puntuaciones[i];
                        puntuaciones[i] = tmp.ToString();
                        string nombre = nombres[i + 1];
                        nombres[i + 1] = nombres[i];
                        nombres[i] = nombre;
                    }
                }
            }
            if (nombres.Count == 0) {

            }
            if (nombres.Count >= 1)
            {
                txtJugador1.Text = nombres[0];
                txtPuntuacion1.Text = puntuaciones[0];
            }
            if (nombres.Count >= 2)
            {
                txtJugador2.Text = nombres[1];
                txtPuntuacion2.Text = puntuaciones[1];
            }
            if (nombres.Count >= 3)
            {
                txtJugador3.Text = nombres[2];
                txtPuntuacion3.Text = puntuaciones[2];
            }
            if (nombres.Count >= 4)
            {
                txtJugador4.Text = nombres[3];
                txtPuntuacion4.Text = puntuaciones[3];
            }
            if (nombres.Count >= 5)
            {
                txtJugador5.Text = nombres[4];
                txtPuntuacion5.Text = puntuaciones[4];
            }
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {

        }
    }
}
