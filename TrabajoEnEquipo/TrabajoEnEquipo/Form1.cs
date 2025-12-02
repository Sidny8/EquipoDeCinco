/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 01/12/2025
 * Time: 05:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public string Nombre;
		public string Semestre;
		public string espescialidad;
		public string gmail;
		public string telefono;
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Form1Load(object sender, EventArgs e)
		{
			label3.Text= Nombre;
			lblEspe.Text= espescialidad;
			lblCorre.Text= gmail;
			lblSe.Text= Semestre;
			lblTele.Text= telefono;
		
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			FormB B = new FormB();
			B.Show();
			this.Hide();
		}
	}
}
