/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 28/11/2025
 * Time: 06:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtPassEnter(object sender, EventArgs e)
		{
			if(txtPass.Text == "")
				{
					txtPass.Text ="";
					txtPass.ForeColor=Color.Black;
					txtPass.UseSystemPasswordChar=true;
				}
		}
		
		void TxtPassLeave(object sender, EventArgs e)
		{
			if(txtPass.Text == "")
				{
					txtPass.Text ="";
					txtPass.ForeColor=Color.DimGray;
					txtPass.UseSystemPasswordChar=false;
				}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(txtUser.Text==""){
				MessageBox.Show("Agregue nombre de usuario");
			}
			else if(txtPass.Text==""){
				MessageBox.Show("Escriba la contraseña");
			}
			else if(txtUser.Text=="Admin" && txtPass.Text=="123"){
				MessageBox.Show("Finjamos que cambiamos de pestaña");
			}else{
				MessageBox.Show("Contraseña o usuario incorrectas");
			}
		}
	}
}
