/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 28/11/2025
 * Time: 07:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoEnEquipo
{
	partial class Datos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.cboColonia = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtDomicilia = new System.Windows.Forms.TextBox();
			this.cboSemestre = new System.Windows.Forms.ComboBox();
			this.cboEspecialidad = new System.Windows.Forms.ComboBox();
			this.btmRegistrar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(169, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DATOS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label2.Location = new System.Drawing.Point(6, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label3.Location = new System.Drawing.Point(5, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellidos";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(85, 29);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(351, 20);
			this.txtName.TabIndex = 3;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(85, 64);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(351, 20);
			this.txtApellido.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label4.Location = new System.Drawing.Point(232, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "Semestre";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label5.Location = new System.Drawing.Point(5, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 21);
			this.label5.TabIndex = 7;
			this.label5.Text = "Especialidad";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label6.Location = new System.Drawing.Point(6, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Altura";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(85, 148);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(58, 20);
			this.txtAltura.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label7.Location = new System.Drawing.Point(157, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 20);
			this.label7.TabIndex = 11;
			this.label7.Text = "Peso";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(218, 149);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(58, 20);
			this.txtPeso.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label8.Location = new System.Drawing.Point(198, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "Correo Electronico:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(310, 121);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(126, 20);
			this.txtCorreo.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label9.Location = new System.Drawing.Point(6, 117);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Telefono:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label10.Location = new System.Drawing.Point(11, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 18);
			this.label10.TabIndex = 16;
			this.label10.Text = "Colonia:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(85, 117);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(107, 20);
			this.txtTelefono.TabIndex = 17;
			// 
			// cboColonia
			// 
			this.cboColonia.FormattingEnabled = true;
			this.cboColonia.Items.AddRange(new object[] {
									"La Zapata",
									"La Presa",
									"Centro",
									"El charco",
									"Deportiva",
									"Plan de Ayala",
									"La joya"});
			this.cboColonia.Location = new System.Drawing.Point(85, 179);
			this.cboColonia.Name = "cboColonia";
			this.cboColonia.Size = new System.Drawing.Size(140, 21);
			this.cboColonia.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label11.Location = new System.Drawing.Point(232, 182);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(102, 18);
			this.label11.TabIndex = 19;
			this.label11.Text = "No. de domicilio:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDomicilia
			// 
			this.txtDomicilia.Location = new System.Drawing.Point(340, 182);
			this.txtDomicilia.Name = "txtDomicilia";
			this.txtDomicilia.Size = new System.Drawing.Size(46, 20);
			this.txtDomicilia.TabIndex = 20;
			// 
			// cboSemestre
			// 
			this.cboSemestre.FormattingEnabled = true;
			this.cboSemestre.Items.AddRange(new object[] {
									"1",
									"3",
									"5"});
			this.cboSemestre.Location = new System.Drawing.Point(293, 94);
			this.cboSemestre.Name = "cboSemestre";
			this.cboSemestre.Size = new System.Drawing.Size(59, 21);
			this.cboSemestre.TabIndex = 21;
			// 
			// cboEspecialidad
			// 
			this.cboEspecialidad.FormattingEnabled = true;
			this.cboEspecialidad.Items.AddRange(new object[] {
									"Contaduria",
									"Programacion",
									"Ciberseguridad",
									"Mecanica",
									"Soporte",
									"Administracion",
									"Alimentos"});
			this.cboEspecialidad.Location = new System.Drawing.Point(85, 90);
			this.cboEspecialidad.Name = "cboEspecialidad";
			this.cboEspecialidad.Size = new System.Drawing.Size(141, 21);
			this.cboEspecialidad.TabIndex = 22;
			// 
			// btmRegistrar
			// 
			this.btmRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btmRegistrar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btmRegistrar.Location = new System.Drawing.Point(337, 252);
			this.btmRegistrar.Name = "btmRegistrar";
			this.btmRegistrar.Size = new System.Drawing.Size(111, 31);
			this.btmRegistrar.TabIndex = 23;
			this.btmRegistrar.Text = "Registrar";
			this.btmRegistrar.UseVisualStyleBackColor = false;
			this.btmRegistrar.Click += new System.EventHandler(this.BtmRegistrarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDomicilia);
			this.groupBox1.Controls.Add(this.txtPeso);
			this.groupBox1.Controls.Add(this.txtAltura);
			this.groupBox1.Controls.Add(this.cboEspecialidad);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboColonia);
			this.groupBox1.Controls.Add(this.cboSemestre);
			this.groupBox1.Controls.Add(this.txtCorreo);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(12, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(446, 213);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(210, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 31);
			this.button1.TabIndex = 25;
			this.button1.Text = "Regresar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Datos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(487, 292);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btmRegistrar);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Datos";
			this.Text = "Datos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btmRegistrar;
		private System.Windows.Forms.ComboBox cboEspecialidad;
		private System.Windows.Forms.ComboBox cboSemestre;
		private System.Windows.Forms.TextBox txtDomicilia;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboColonia;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
