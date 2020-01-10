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
	/// Descripción breve de Utiles.
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
