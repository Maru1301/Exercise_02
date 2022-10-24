using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			lblGreeting.Text = String.Empty;
		}

		private void btnGreeting_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			string now = dt.ToString("yyyy/MM/dd HH:mm:ss");

			DisplayTime(now);

			string greeting = GenerateGreeting(dt);

			DisplayGreeting(now, greeting);
		}

		private void DisplayTime(string now)
		{
			MessageBox.Show(now, "現在時間");
		}

		private void DisplayGreeting(string now, string greeting)
		{
			lblGreeting.Text = $"{now}\r\n{greeting}";
		}

		private string GenerateGreeting(DateTime dt)
		{
			int hour = dt.Hour;
			string result = string.Empty;
			if (hour < 12)
			{
				result = "早安!";
			}
			else if (hour < 18)
			{
				result = "午安!";
			}
			else
			{
				result = "晚安!";
			}

			return result;
		}
	}
}
