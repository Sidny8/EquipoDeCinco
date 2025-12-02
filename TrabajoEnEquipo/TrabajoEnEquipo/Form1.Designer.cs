/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 01/12/2025
 * Time: 05:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoEnEquipo
{
	partial class Form1
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblEspe = new System.Windows.Forms.Label();
			this.lblSe = new System.Windows.Forms.Label();
			this.lblTele = new System.Windows.Forms.Label();
			this.lblCorre = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Especialidad";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(186, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Semestre";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(186, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "Correo:";
			// 
			// lblEspe
			// 
			this.lblEspe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblEspe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEspe.Location = new System.Drawing.Point(78, 68);
			this.lblEspe.Name = "lblEspe";
			this.lblEspe.Size = new System.Drawing.Size(102, 29);
			this.lblEspe.TabIndex = 6;
			// 
			// lblSe
			// 
			this.lblSe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblSe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSe.Location = new System.Drawing.Point(254, 68);
			this.lblSe.Name = "lblSe";
			this.lblSe.Size = new System.Drawing.Size(102, 29);
			this.lblSe.TabIndex = 7;
			// 
			// lblTele
			// 
			this.lblTele.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblTele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTele.Location = new System.Drawing.Point(78, 116);
			this.lblTele.Name = "lblTele";
			this.lblTele.Size = new System.Drawing.Size(102, 29);
			this.lblTele.TabIndex = 8;
			// 
			// lblCorre
			// 
			this.lblCorre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblCorre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCorre.Location = new System.Drawing.Point(254, 116);
			this.lblCorre.Name = "lblCorre";
			this.lblCorre.Size = new System.Drawing.Size(102, 29);
			this.lblCorre.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(78, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 29);
			this.label3.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button1.Location = new System.Drawing.Point(247, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 41);
			this.button1.TabIndex = 12;
			this.button1.Text = "Menu Principal";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(388, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCorre);
			this.Controls.Add(this.lblTele);
			this.Controls.Add(this.lblSe);
			this.Controls.Add(this.lblEspe);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCorre;
		private System.Windows.Forms.Label lblTele;
		private System.Windows.Forms.Label lblSe;
		private System.Windows.Forms.Label lblEspe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
