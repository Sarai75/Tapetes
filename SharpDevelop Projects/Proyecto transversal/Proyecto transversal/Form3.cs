﻿/*
 * Created by SharpDevelop.
 * User: J Sarai
 * Date: 22/11/2024
 * Time: 06:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_transversal
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		int botella;
		int pinturaa;
		int frutos;
		int metross;
		int metrossaserrin;
		int resulaserrin;
		int floress;
		int tortaa;
		int resutrabajador;
		int metrotra;
		
		public Form3(int botellaagua, int pinturas, int frutoos, int metroos,  int metroosassa, int resullase, int flooree, int toortaa, int restrabaja, int metrostraa)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			botella=botellaagua;
			pinturaa=pinturas;
			frutos=frutoos;
			metross=metroos;
			metrossaserrin=metroosassa;
			resulaserrin=resullase;
			floress=flooree;
			tortaa=toortaa;
			resutrabajador=restrabaja;
			metrotra=metrostraa;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnvolverClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainform = new MainForm();
			mainform.Show();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			
			botella=botella*25;
			lblagua.Text=botella.ToString();
			
			pinturaa=pinturaa*100;
			lblpintura.Text=pinturaa.ToString();
			
			frutos=frutos*80;
			lblfrutos.Text=frutos.ToString();
			
			lblaserrin.Text=metrossaserrin.ToString();
			
			lblcosto.Text=resulaserrin.ToString();
			
			floress=floress*50;
			lblflores.Text=floress.ToString();
			
			tortaa=tortaa*30;
			lbltorta.Text=tortaa.ToString();
			
			resutrabajador=resutrabajador*50;
			lbltrabajadores.Text=resutrabajador.ToString();
			
			int resuu=botella+pinturaa+frutos+metrossaserrin+resulaserrin+floress+tortaa+resutrabajador;
			lblresul.Text=resuu.ToString();
		}
	}
}
