using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string stars = GenerateStars(rows);

			DisplayStars(stars);
		}

		private void DisplayStars(string value)
		{
			txtStars.Text = value;
		}

		private string GenerateStars(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}

			return result;
		}

		private int GetRows()
		{
			string input = txtRows.Text;
			bool isInt = int.TryParse(input, out int rows);

			if (!isInt)
			{
				throw new Exception("輸入錯誤!");
			}

			if (rows < 1 || rows > 10)
			{
				throw new Exception("請輸入介於1~10之間的值");
			}

			return rows;
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string stars = GenerateStarsRight(rows);

			DisplayStars(stars);
		}

		private string GenerateStarsRight(int rows)
		{
			string result = string.Empty;

			for(int i = 1; i <= rows; i++)
			{
				result += new string(' ', (rows-i)* 2) + new string('*', i) + "\r\n";
			}

			return result;
		}

		private void btnMiddle_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string stars = GenerateStarsMiddle(rows);

			DisplayStars(stars);
		}

		private string GenerateStarsMiddle(int rows)
		{
			string result = string.Empty;

			for(int i = 1; i <= rows; i++)
			{
				result += new string(' ', (rows - i)) + new string('*', i) + "\r\n";
			}

			return result;
		}
	}
}
