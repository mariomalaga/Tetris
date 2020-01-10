/*
* PR�CTICA.............: Pr�ctica 11 Resumen. Clases, Objetos y dll�s
* NOMBRE y APELLIDOS...: Mario Olivera Casta�eda
* CURSO y GRUPO........: 2o Desarrollo de Interfaces
* T�TULO de la PR�CTICA: Pr�ctica 11. Matenimiento. Resumen (Recopilaci�n).
* FECHA de ENTREGA.....: 03 de Marzo de 2019
*/
using System;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Descripci�n breve de Juego.
	/// </summary>
	public class Juego
	{
		public static void Main()
		{
			if ( !Utiles.ResolucionCorrecta(800, 600) )
			{
				MessageBox.Show("Para ejecutar el juego, debe tener como m�nimo una resoluci�n de 800 x 600");
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
