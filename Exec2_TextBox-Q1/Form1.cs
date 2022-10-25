using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			int number = 0;
			try
			{
				number = GetInt();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


			Check(number);
		}

		private void Check(int number)
		{
			if (number < 1 || number > 100)
			{
				MessageBox.Show($"{number} 不在1到100的區間內");
				return;
			}

			MessageBox.Show($"{number} 大於等於1,小於等於100");
		}

		private int GetInt()
		{
			string input = txtNum.Text;
			bool isInt = int.TryParse(input, out int output);

			if (!isInt)
			{
				throw new Exception("輸入錯誤");
			}

			return output;
		}
	}
}
