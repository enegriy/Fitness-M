using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fitness_M
{
	public partial class Splash : Form
	{
		private static Thread _Thread = null;
		public static Splash Show(string caption, string text)
		{
			var _This = new Splash();
			_This.Text = caption;
			_This.lblText.Text = text;
			_This.CanClose = false;

			_Thread = new Thread(() => _This.ShowDialog());
			_Thread.Start();
			
			return _This;
		}

		private Splash()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Может быть закрыт
		/// </summary>
		public bool CanClose { get; set; }

		public void SetValueProgress(int value)
		{
			pgsBar.Value = value;
		}

		public new void Close()
		{
			CanClose = true;
			base.Close();

			_Thread.Interrupt();
		}

		private void OnForm_Closing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = !CanClose;
		}

		
	}
}
