/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: Mario Olivera Castañeda
* CURSO y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 03 de Marzo de 2019
*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmGUI : Form
	{
		public System.Windows.Forms.PictureBox pbPantallaJuego;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private Tetris t;
		private bool haciaAbajo;
		private bool haciaDerecha;
		private bool rotaDerecha;
		private bool rotaIzquierda;
		private bool enPausa;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label lblNumLineas;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbPiezaSiguiente;
		private System.Windows.Forms.MenuItem menuItem6;
        private ToolTip toolTip1;
        private MenuItem menuItem7;
        private MenuItem menuItem12;
        public MenuItem mniCambiarTamano;
        private Label label4;
        public Label lblPuntuacion;
        private bool haciaIzquierda;

		public frmGUI()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.pbPantallaJuego = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNumLineas = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mniCambiarTamano = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.pbPiezaSiguiente = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPantallaJuego
            // 
            this.pbPantallaJuego.BackColor = System.Drawing.Color.Black;
            this.pbPantallaJuego.Location = new System.Drawing.Point(163, 28);
            this.pbPantallaJuego.Name = "pbPantallaJuego";
            this.pbPantallaJuego.Size = new System.Drawing.Size(286, 441);
            this.pbPantallaJuego.TabIndex = 0;
            this.pbPantallaJuego.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblNumLineas
            // 
            this.lblNumLineas.BackColor = System.Drawing.Color.Black;
            this.lblNumLineas.ForeColor = System.Drawing.Color.White;
            this.lblNumLineas.Location = new System.Drawing.Point(19, 175);
            this.lblNumLineas.Name = "lblNumLineas";
            this.lblNumLineas.Size = new System.Drawing.Size(120, 27);
            this.lblNumLineas.TabIndex = 1;
            this.lblNumLineas.Text = "0";
            this.lblNumLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.Black;
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(19, 240);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(120, 27);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "1";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblNivel, "Para mi Alumno ");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lineas:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem7,
            this.menuItem12,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem6,
            this.menuItem4});
            this.menuItem1.Text = "Juego";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Nuevo";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Pausa";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Salir";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mniCambiarTamano});
            this.menuItem7.Text = "Herramientas";
            // 
            // mniCambiarTamano
            // 
            this.mniCambiarTamano.Index = 0;
            this.mniCambiarTamano.Text = "Cambiar Tamaño";
            this.mniCambiarTamano.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "Ranking";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5});
            this.menuItem2.Text = "Ayuda";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Acerca de...";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // pbPiezaSiguiente
            // 
            this.pbPiezaSiguiente.BackColor = System.Drawing.Color.Black;
            this.pbPiezaSiguiente.Location = new System.Drawing.Point(19, 46);
            this.pbPiezaSiguiente.Name = "pbPiezaSiguiente";
            this.pbPiezaSiguiente.Size = new System.Drawing.Size(96, 92);
            this.pbPiezaSiguiente.TabIndex = 7;
            this.pbPiezaSiguiente.TabStop = false;
            this.pbPiezaSiguiente.Click += new System.EventHandler(this.pbPiezaSiguiente_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Próxima pieza:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.BackColor = System.Drawing.Color.Black;
            this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacion.Location = new System.Drawing.Point(19, 305);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(120, 27);
            this.lblPuntuacion.TabIndex = 9;
            this.lblPuntuacion.Text = "0";
            this.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblPuntuacion, "Para mi Alumno ");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Puntuación";
            // 
            // frmGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(456, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPiezaSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNumLineas);
            this.Controls.Add(this.pbPantallaJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmGUI";
            this.Text = "eTetris";
            this.Load += new System.EventHandler(this.frmGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
        //static void Main() 
        //{
        //    Application.Run(new frmGUI());
        //}

		private void frmGUI_Load(object sender, System.EventArgs e)
		{
			t = new Tetris();
		}

		private void frmGUI_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = true;
						//t.muevePiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "RIGHT":
						haciaDerecha = true;
						//t.muevePiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "UP":
						rotaDerecha = true;
						//t.rotaPiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "A":
						rotaIzquierda = true;
						//t.rotaPiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "DOWN":
						haciaAbajo = true;
						//t.muevePiezaAbajo();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "P":
						pausaJuego();
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
			else
			{
				switch(strKeyPress.ToUpper())
				{
					case "ENTER":
						break;
					default:
						break;
				}
			}
		}

		private void frmGUI_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = false;
						break;
					case "RIGHT":
						haciaDerecha = false;
						break;
					case "DOWN":
						haciaAbajo = false;
						break;
					case "UP":
						rotaDerecha = false;
						break;
					case "A":
						rotaIzquierda = false;
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
		}

		public void pintaPantalla(int [, ] matrizPantalla)
		{
            frmCambiarTamano tamano = new frmCambiarTamano();
            pbPantallaJuego.Size = new System.Drawing.Size(frmCambiarTamano.Columnas * 20, frmCambiarTamano.Filas * 20);
            Bitmap B = new Bitmap(pbPantallaJuego.Width, pbPantallaJuego.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < frmCambiarTamano.Columnas; x++)
			{
				for (int y = 0; y < frmCambiarTamano.Filas; y++)
				{
					int elemento = matrizPantalla[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(elemento - 1));
					}
				}
			}
			pbPantallaJuego.Image = B;
            ;
        }
		
		public void pintaPiezaSiguiente(Pieza p)
		{
            Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
			{
				for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
				{
					int elemento = t.piezaSiguiente[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(t.piezaSiguiente.color - 1));
					}
				}
			}
			pbPiezaSiguiente.Image = B;
		}

		private void dibujaCuadro(Graphics G, int Y,int X, Color C)
		{
			int x = (X * Constantes.ANCHO_CELDA) + 1;
			int y = (Y * Constantes.ALTO_CELDA) + 1;
			SolidBrush Br = new SolidBrush(C);
			G.FillRectangle(Br, x, y, Constantes.ANCHO_CELDA - 2, Constantes.ALTO_CELDA - 2);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				lblNumLineas.Text = t.numLineas.ToString();
                lblPuntuacion.Text = Tetris.Puntuacion.ToString();
				if (haciaAbajo)
					actualizaPantalla();
				else
				{
					haciaAbajo = true;
					actualizaPantalla();
					haciaAbajo = false;
				}
				pintaPiezaSiguiente(t.piezaSiguiente);
				if (t.juegoTerminado)
				{
					timer1.Stop();
                    mniCambiarTamano.Enabled = true;
                    frmPuntuacion puntuacion = new frmPuntuacion();
                    puntuacion.Show();
				}
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				actualizaPantalla();
			}
			else
			{
				timer2.Stop();
				timer1.Stop();
				lblNumLineas.Text = t.numLineas.ToString();
                lblPuntuacion.Text = Tetris.Puntuacion.ToString();
				inicializaTeclas();
				t.nuevoNivel();
				MessageBox.Show("¡¡Enhorabuena!! Has pasado al nivel " + (t.nivel + 1));
				lblNivel.Text = ((int)t.nivel + 1).ToString();
				timer1.Interval = Constantes.NIVELES(t.nivel);
				timer2.Start();
				timer1.Start();		
			}
			if (t.juegoTerminado)
			{
				timer2.Stop();
			}
		}

		private void actualizaPantalla()
		{
			if (haciaAbajo)
			{
				t.muevePiezaAbajo();
			}
			if (haciaDerecha)
			{
				t.muevePiezaDerecha();
			}
			if (haciaIzquierda)
			{
				t.muevePiezaIzquierda();
			}
			if (rotaDerecha)
			{
				t.rotaPiezaDerecha();
				rotaDerecha = false;
			}	
			if (rotaIzquierda)
			{
				t.rotaPiezaIzquierda();
				rotaIzquierda = false;
			}
			pintaPantalla(t.matrizPantalla);		
		}

		private void inicializaTeclas()
		{
			haciaDerecha = false;
			haciaIzquierda = false;
			rotaDerecha = false;
			rotaIzquierda = false;
			haciaAbajo = false;
			enPausa = false;
		}

		private void nuevoJuego()
		{
			inicializaTeclas();
			t.nuevoJuego();
			timer1.Interval = Constantes.NIVELES(t.nivel);
			pintaPantalla(t.matrizPantalla);
			timer1.Start();
			timer2.Start();
		}

		private void pausaJuego()
		{
			if (!enPausa)
			{
				timer1.Stop();
				timer2.Stop();
			}
			else
			{
				timer1.Start();
				timer2.Start();
			}
			enPausa = !enPausa;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
            mniCambiarTamano.Enabled = false;
            nuevoJuego();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			AcerdaDe a = new AcerdaDe();
			a.ShowDialog();
            enPausa = false;
            pausaJuego();
        }

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			pausaJuego();
		}

        private void pbPiezaSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmCambiarTamano cambiar = new frmCambiarTamano();
            cambiar.Show();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            frmRanking ranking = new frmRanking();
            ranking.Show();
        }
    }
}
