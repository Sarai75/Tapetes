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
		public int agua;
		public int pintura;
		public int frutossecos;
		public int metrosc;
		public int largo;
		public int ancho;
		public int aserrin;
		public int metroaserrin;
		public int rtrabajadores;
		public int resultadoaserrin;
		public int flores;
		public int torta;
		public int resultrabajadores;
		public int  metrostrabajadores;
		public int trabajadores;
		
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
			agua = int.Parse(lblagua.Text);
            agua++;
            lblagua.Text = agua.ToString();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			pintura = int.Parse(lblpintura.Text);
            pintura++;
            lblpintura.Text = pintura.ToString();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			frutossecos = int.Parse(lblfrutos.Text);
            frutossecos++;
            lblfrutos.Text = frutossecos.ToString();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			flores = int.Parse(lblflores.Text);
			flores++;
            lblflores.Text = flores.ToString();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			trabajadores = int.Parse(lbltrabajadores.Text);
            trabajadores++;
            lbltrabajadores.Text = trabajadores.ToString();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			torta = int.Parse(lbltorta.Text);
			torta++;
            lbltorta.Text = torta.ToString();
		}
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtancho.Clear();
			txtlargo.Clear();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			string aancho=txtancho.Text;
			ancho=int.Parse(aancho);
			string llargo=txtlargo.Text;
			largo=int.Parse(llargo);	
			metrosc=ancho*largo;
			metroaserrin=metrosc*20;
			resultadoaserrin=metroaserrin*15;
			resultrabajadores=int.Parse(lbltrabajadores.Text);
			metrostrabajadores=resultrabajadores*metroaserrin;
			
			Form3 huhu =new Form3(agua, pintura, frutossecos, metrosc, metroaserrin,resultadoaserrin, flores, torta, trabajadores);
			this.Hide();
			huhu.ShowDialog();
			this.Close();
		}
	}
}
