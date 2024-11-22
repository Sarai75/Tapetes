/*
 * Created by SharpDevelop.
 * User: CC2_PC30
 * Date: 20/11/2024
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_transversal
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnvolverClick(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int agua = int.Parse(lblagua.Text);
            agua++;
            lblagua.Text = agua.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int pintura = int.Parse(lblpintura.Text);
            pintura++;
            lblpintura.Text = pintura.ToString();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int frutossecos = int.Parse(lblfrutos.Text);
            frutossecos++;
            lblfrutos.Text = frutossecos.ToString();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			int flores = int.Parse(lblflores.Text);
			flores++;
            lblflores.Text = flores.ToString();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			int trabajadores = int.Parse(lbltrabajadores.Text);
            trabajadores++;
            lbltrabajadores.Text = trabajadores.ToString();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			int torta = int.Parse(lbltorta.Text);
			torta++;
            lbltorta.Text = torta.ToString();
		}
		
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtancho.Clear();
			txtlargo.Clear();
		}
	}
}
