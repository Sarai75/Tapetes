﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC30
 * Date: 20/11/2024
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_transversal
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
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			this.Hide();
			Form1 from1 = new Form1();
			from1.Show();
			
		}
	}
}
