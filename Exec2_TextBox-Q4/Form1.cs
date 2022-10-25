using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			int cars =0 , people = 0;
			try
			{
				cars = Getnum(txtCars.Text);
				people = Getnum(txtPeople.Text);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string fee = Feecompare(cars, people);

			txtShow.Text = fee;
		}

		private string Feecompare(int cars, int people)
		{
			int carsFee = cars * 200;
			int peopleFee = people * 60;

			string fee = string.Empty;
			if (carsFee < peopleFee)
			{
				fee = $"總共{cars}輛車,共{carsFee}元";
			}
			else
			{
				fee = $"總共{people}人,共{peopleFee}元";
			}

			return fee;
		}

		private int Getnum(string value)
		{
			bool isInt = int.TryParse(value, out int result);

			if (!isInt)
			{
				throw new Exception("輸入錯誤");
			}

			if(result < 1)
			{
				throw new Exception("數量不得小於1");
			}

			return result;
		}
	}
}
