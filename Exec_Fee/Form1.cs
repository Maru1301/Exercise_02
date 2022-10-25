using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			lblShowFee.Text = string.Empty;
			lblShowReason.Text = string.Empty;
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			int age = 0;
			try
			{
				age = GetAge();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			KeyValuePair<int,string> result = new KeyValuePair<int,string>();
			result = GetResult(age);
			
			lblShowFee.Text = result.Key.ToString();
			lblShowReason.Text = result.Value.ToString();
		}

		private KeyValuePair<int, string> GetResult(int age)
		{
			bool Gender = rdbMale.Checked;
			int fee = 15;
			string reason = "全票";

			if (age <= 3)
			{
				fee = 0;
				reason = "年齡小於等於3歲";
			}
			else if (age >= 70 && Gender == true)
			{
				fee = 2;
				reason = "年齡大於等於70歲，且為男性";
			}
			else if (age >= 60 && Gender == false)
			{
				fee = 3;
				reason = "年齡大於等於60歲，且為女性";
			}

			KeyValuePair<int, string> result = new KeyValuePair<int, string>(fee,reason);
			return result;
		}

		private int GetAge()
		{
			bool isInt = int.TryParse(txtAge.Text, out int age);

			if (!isInt)
			{
				throw new Exception("輸入錯誤");
			}

			if(age < 0)
			{
				throw new Exception("年齡不得小於零");
			}

			if(age > 119)
			{
				throw new Exception("年齡過大");
			}

			return age;
		}
	}
}
