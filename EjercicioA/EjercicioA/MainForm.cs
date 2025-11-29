/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 28/11/2025
 * Time: 07:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EjercicioA
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
			 if(txtUser.Text == "USUARIO")
				{
				  txtUser.Text ="";
				  txtUser.ForeColor=Color.Black;
				}
            }
			void TxtUserLeave(object sender, EventArgs e)
		   {
			//Cunado el cursor sale de la caja de texto
			if(txtUser.Text == "USUARIO")
				{
					txtUser.Text ="";
					txtUser.ForeColor=Color.DimGray;
				}
			}
			void TxtPassEnter(object sender, EventArgs e)
			{
			//Cunado el cursor esta dentro de la caja de texto
			if(txtPass.Text == "CONTRASEÑA")
				{
					txtPass.Text ="";
					txtPass.ForeColor=Color.Black;
					txtPass.UseSystemPasswordChar=true;
				}
			}
			void TxtPassLeave(object sender, EventArgs e)
			{
			//Cunado el cursor sale de la caja de texto
			if(txtPass.Text == "CONTRASEÑA")
				{
					txtPass.Text ="";
					txtPass.ForeColor=Color.DimGray;
					txtPass.UseSystemPasswordChar=false;
				}
			}
		}
	}
