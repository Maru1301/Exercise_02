using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP_Q2
{
	public partial class Form1 : Form
	{
		RollDice game = new RollDice();
		public Form1()
		{
			InitializeComponent();
			lblDice.Text = string.Empty;
			lblScore.Text = 0.ToString();
		}

		private void btnRoll_Click(object sender, EventArgs e)
		{
			game.Start();

			Display();
		}

		private void Display()
		{
			lblScore.Text = game.ScoreDisplay().ToString();
			lblDice.Text = game.DiceDisplay();
		}
	}
}

/// <summary>
/// The game of rolling dice
/// </summary>
public class RollDice
{
	private int[] dice = new int[4];

	public void Start()
	{
		int seed = Guid.NewGuid().GetHashCode();
		Random rand = new Random(seed);

		int i;
		//produce 4 random number for the dice
		for(i = 0; i < dice.Length; i++)
		{
			dice[i] = rand.Next(1, 7);
		}

		//check if there are duplicate numbers
		bool isDup = false;
		while(!isDup && i < dice.Length)
		{
			for(int j = i+1; j < dice.Length; j++)
			{
				if (dice[i] == dice[j])
				{
					isDup = true;
					break;
				}
			}
		}

		//if there isn't any duplicate numbers, change the first number until there appears a pair of duplicate numbers
		while (!isDup)
		{
			dice[0] = rand.Next(1, 7);
			for(i = 1; i < dice.Length; i++)
			{
				if (dice[0] == dice[i])
				{
					isDup = true;
					break;
				}
			}
		}
	}

	internal string  DiceDisplay()
	{
		string result = string.Empty;
		for(int i = 0; i < dice.Length-1; i++)
		{
			result += $"{dice[i].ToString()}, ";
		}
		result += $"{dice[dice.Length-1].ToString()}";

		return result;
	}

	internal int ScoreDisplay()
	{
		int sum = 0;
		int[] hash = new int[7];
		for(int i = 0; i < dice.Length; i++)
		{
			sum += dice[i];
			hash[dice[i]]++;
		}

		bool isDup = false;
		for(int i = 0; i < hash.Length; i++)
		{
			if (hash[i] >= 2 && !isDup)
			{
				sum -= i * 2;
				isDup = true;
			}
		}

		return isDup ? sum : 0;
	}
}
