using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Exec2_TextBox_Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Today;

			DateTime dt = new DateTime();
			try
			{
				dt = GetDate(txtEnter.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if(Check(dt, today))
			{
				MessageBox.Show($"輸入日期: {dt:yyyy/MM/dd}\r\n" +
					$"今天日期: {today:yyyy/MM/dd}");
			}
			else
			{
				MessageBox.Show("輸入日期大於今天");
			};
		}

		private bool Check(DateTime dt, DateTime today)
		{
			return dt <= today ? true : false;
		}

		private DateTime GetDate(string text)
		{
			bool isDT = DateTime.TryParse(text, out DateTime dt);

			if (!isDT)
			{
				throw new Exception("輸入錯誤");
			}

			return dt;
		}
	}
}
