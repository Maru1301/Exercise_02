using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			DateTime dt = new DateTime();
			try
			{
				dt = GetDate(txtInput.Text);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if (Check(dt))
			{
				MessageBox.Show("年齡符合");
			}
			else
			{
				MessageBox.Show("年紀太小");
			}
		}

		private bool Check(DateTime dt)
		{
			DateTime today = DateTime.Today;
			int difference = today.Year - dt.Year;
			if(difference < 13 || (difference == 13 && dt.Month > today.Month)|| (difference == 13 && dt.Month == today.Month && dt.Day > today.Day))
			{
				return false;
			}

			return true;
		}

		private DateTime GetDate(string text)
		{
			bool isDT = DateTime.TryParse(text, out DateTime dt);

			if (!isDT)
			{
				throw new Exception("輸入錯誤!\r\n輸入格式: YYYY/MM/DD");
			}

			if(dt > DateTime.Now)
			{
				throw new Exception("生日不得超過今天");
			}

			return dt;
		}
	}
}
