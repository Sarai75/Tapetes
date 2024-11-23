/*
 * Created by SharpDevelop.
 * User: J Sarai
 * Date: 22/11/2024
 * Time: 06:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_transversal
{
	partial class Form3
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
			this.lbltorta = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnvolver = new System.Windows.Forms.Button();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lbltrabajadores = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblagua = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblflores = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblfrutos = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblpintura = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblaserrin = new System.Windows.Forms.Label();
			this.lblcosto = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbltorta
			// 
			this.lbltorta.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltorta.Location = new System.Drawing.Point(312, 108);
			this.lbltorta.Name = "lbltorta";
			this.lbltorta.Size = new System.Drawing.Size(62, 23);
			this.lbltorta.TabIndex = 58;
			this.lbltorta.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(312, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 23);
			this.label2.TabIndex = 57;
			this.label2.Text = "tortas";
			// 
			// btnvolver
			// 
			this.btnvolver.BackColor = System.Drawing.Color.Silver;
			this.btnvolver.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnvolver.Location = new System.Drawing.Point(10, 347);
			this.btnvolver.Name = "btnvolver";
			this.btnvolver.Size = new System.Drawing.Size(188, 28);
			this.btnvolver.TabIndex = 49;
			this.btnvolver.Text = "volver a precios";
			this.btnvolver.UseVisualStyleBackColor = false;
			// 
			// btncalcular
			// 
			this.btncalcular.BackColor = System.Drawing.Color.Silver;
			this.btncalcular.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(424, 347);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(112, 28);
			this.btncalcular.TabIndex = 48;
			this.btncalcular.Text = "calcular";
			this.btncalcular.UseVisualStyleBackColor = false;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(288, 268);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(118, 23);
			this.label18.TabIndex = 47;
			this.label18.Text = "precio total";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(426, 266);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 23);
			this.label11.TabIndex = 43;
			this.label11.Text = "0";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(312, 141);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(224, 39);
			this.label12.TabIndex = 42;
			this.label12.Text = "cuantos kilos de aserrin\r\n y su costo";
			// 
			// lbltrabajadores
			// 
			this.lbltrabajadores.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltrabajadores.Location = new System.Drawing.Point(312, 38);
			this.lbltrabajadores.Name = "lbltrabajadores";
			this.lbltrabajadores.Size = new System.Drawing.Size(62, 23);
			this.lbltrabajadores.TabIndex = 41;
			this.lbltrabajadores.Text = "0";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(312, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(207, 23);
			this.label14.TabIndex = 40;
			this.label14.Text = "cobro de trabajadores";
			// 
			// lblagua
			// 
			this.lblagua.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblagua.Location = new System.Drawing.Point(8, 50);
			this.lblagua.Name = "lblagua";
			this.lblagua.Size = new System.Drawing.Size(62, 23);
			this.lblagua.TabIndex = 39;
			this.lblagua.Text = "0";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(8, 17);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(163, 23);
			this.label16.TabIndex = 38;
			this.label16.Text = "litro de agua";
			// 
			// lblflores
			// 
			this.lblflores.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblflores.Location = new System.Drawing.Point(8, 254);
			this.lblflores.Name = "lblflores";
			this.lblflores.Size = new System.Drawing.Size(62, 23);
			this.lblflores.TabIndex = 37;
			this.lblflores.Text = "0";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 23);
			this.label8.TabIndex = 36;
			this.label8.Text = "docena de flores";
			// 
			// lblfrutos
			// 
			this.lblfrutos.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfrutos.Location = new System.Drawing.Point(8, 189);
			this.lblfrutos.Name = "lblfrutos";
			this.lblfrutos.Size = new System.Drawing.Size(62, 23);
			this.lblfrutos.TabIndex = 35;
			this.lblfrutos.Text = "0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 23);
			this.label6.TabIndex = 34;
			this.label6.Text = "kg de frutos secos";
			// 
			// lblpintura
			// 
			this.lblpintura.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpintura.Location = new System.Drawing.Point(8, 120);
			this.lblpintura.Name = "lblpintura";
			this.lblpintura.Size = new System.Drawing.Size(62, 23);
			this.lblpintura.TabIndex = 33;
			this.lblpintura.Text = "0";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 23);
			this.label4.TabIndex = 32;
			this.label4.Text = "litros de pintura";
			// 
			// lblaserrin
			// 
			this.lblaserrin.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblaserrin.Location = new System.Drawing.Point(312, 219);
			this.lblaserrin.Name = "lblaserrin";
			this.lblaserrin.Size = new System.Drawing.Size(62, 23);
			this.lblaserrin.TabIndex = 62;
			this.lblaserrin.Text = "0";
			// 
			// lblcosto
			// 
			this.lblcosto.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcosto.Location = new System.Drawing.Point(403, 219);
			this.lblcosto.Name = "lblcosto";
			this.lblcosto.Size = new System.Drawing.Size(62, 23);
			this.lblcosto.TabIndex = 63;
			this.lblcosto.Text = "0";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 189);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 64;
			this.label1.Text = "kilos";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(403, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 65;
			this.label3.Text = "costo";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(565, 387);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblcosto);
			this.Controls.Add(this.lblaserrin);
			this.Controls.Add(this.lbltorta);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnvolver);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.lbltrabajadores);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.lblagua);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.lblflores);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblfrutos);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblpintura);
			this.Controls.Add(this.label4);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblcosto;
		private System.Windows.Forms.Label lblaserrin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblpintura;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblfrutos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblflores;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblagua;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lbltrabajadores;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Button btnvolver;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbltorta;
	}
}
