/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 28/11/2025
 * Time: 06:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoEnEquipo
{
	partial class MainForm
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
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "LOGIN";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuario:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Contraseña:";
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(103, 56);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(176, 23);
			this.txtUser.TabIndex = 4;
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(103, 85);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(176, 23);
			this.txtPass.TabIndex = 5;
			this.txtPass.Enter += new System.EventHandler(this.TxtPassEnter);
			this.txtPass.Leave += new System.EventHandler(this.TxtPassLeave);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(33, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(237, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "ACCEDER";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(322, 190);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "TrabajoEnEquipo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
