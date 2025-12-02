/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 28/11/2025
 * Time: 07:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoEnEquipo
{
	/// <summary>
	/// Description of Datos.
	/// </summary>
	public partial class Datos : Form
	{
		public Datos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtmRegistrarClick(object sender, EventArgs e)
		{
			if(cboEspecialidad.SelectedIndex== -1)
				MessageBox.Show("Debera de escojer una opcion de las dichas especialidades ||");
			else if(cboSemestre.SelectedIndex==-1)
				MessageBox.Show("Deberia de escojer una opcion ya encionada en semestre ||");
			else if(cboColonia.SelectedIndex==-1)
				MessageBox.Show("Deberia de escojer una Colonia||");
			else if(txtName.Text=="")
				MessageBox.Show("Diga el nombre||");
			else if(txtApellido.Text=="")
				MessageBox.Show("Oblgatorio su escuela ||");
			else if(txtCorreo.Text=="")
				MessageBox.Show("Obligatorio su correo ||");
			else if(txtTelefono.Text=="0" || txtTelefono.Text=="")
				MessageBox.Show("Obligatorio su telefono ||");
			else if(txtDomicilia.Text=="0" || txtTelefono.Text=="")
				MessageBox.Show("Diga su dirreccion ||");
			else{
				
				string name = txtName.Text;
				string tele = txtTelefono.Text;
				string semes = cboSemestre.Text;
				string espe = cboEspecialidad.Text;
				string gm = txtCorreo.Text;
				
				MessageBox.Show("Guardado exitosamente ||");
				txtAltura.Text="";
				txtApellido.Text="";
				txtCorreo.Text="";
				txtDomicilia.Text="";
				txtName.Text="";
				txtPeso.Text="";
				txtTelefono.Text="";
				cboColonia.SelectedIndex=-1;
				cboEspecialidad.SelectedIndex=-1;
				cboSemestre.SelectedIndex=-1;
				
				Form1 dat = new Form1();
				
				
				
				dat.Nombre = name;
				dat.telefono= tele;
				dat.Semestre= semes;
				dat.espescialidad= espe;
				dat.gmail= gm;
				dat.Show();
				this.Hide();
			
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			FormB Menu = new FormB();
			Menu.Show();
			this.Hide();
		}
		
		
	}
}
