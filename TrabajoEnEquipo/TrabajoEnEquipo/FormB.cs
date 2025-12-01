/*
 * Creado por SharpDevelop.
 * Usuario: EDGAR
 * Fecha: 01/12/2025
 * Hora: 08:24 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of FormB.
	/// </summary>
	public partial class FormB : Form
	{
		public FormB()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormBLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnCalificacionesClick(object sender, EventArgs e)
		{
			Formulario4 Cali = new Formulario4();
			Cali.Show();
			this.Hide();
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			FormE Order = new FormE();
			Order.Show();
			this.Hide();
		}
		
		void BtnRegistroClick(object sender, EventArgs e)
		{
			Datos Dat = new Datos();
			Dat.Show();
			this.Hide();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
