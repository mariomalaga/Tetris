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
	/// <summary>
	/// Descripción breve de Juego.
	/// </summary>
	public class Juego
	{
		public static void Main()
		{
			if ( !Utiles.ResolucionCorrecta(800, 600) )
			{
				MessageBox.Show("Para ejecutar el juego, debe tener como mínimo una resolución de 800 x 600");
			}
			else
			{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmSplash frmSplash = new frmSplash();
                if (frmSplash.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmGUI());
                }             
			}
		}
	}
}
