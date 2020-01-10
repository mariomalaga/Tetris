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
	/// Descripci�n breve de Utiles.
	/// </summary>
	public class Utiles
	{
		public static bool ResolucionCorrecta(int ancho, int alto)
		{
			bool correcto = false;
			System.Drawing.Rectangle pantalla = Screen.PrimaryScreen.Bounds;
			if (pantalla.Width >= ancho && pantalla.Height >= alto)
				correcto = true;
			return correcto;
		}
	}
}
