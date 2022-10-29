using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP_Q1
{
	public partial class Form1 : Form
	{
		private Game1A2B game = new Game1A2B();
		public Form1()
		{
			InitializeComponent();

			InitializeGame();

		}

		private void btnAgain_Click(object sender, EventArgs e)
		{
			InitializeGame();
		}

		private void InitializeGame()
		{
			game.GameStart();
			txtGuess.Text = String.Empty;
			txtShow.Text = String.Empty;
		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			string guess = GetInput();
			if (!isValidInput(guess))
			{
				return;
			}

			ShowResult(guess);
		}

		private void ShowResult(string guess)
		{
			GameResult result = game.Check(guess);
			if (result.isSuccess)
			{
				//todo success lblshow
				txtShow.Text = result.Hint;
				MessageBox.Show("Bingo!!!");

				DialogResult dr =  MessageBox.Show("Do you wanna paly again?", "One more?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(dr == DialogResult.Yes)
				{
					InitializeGame();
				}
				else
				{
					Application.Exit();
				}
			}
			else
			{
				//todo fail lblshow
				txtShow.Text = result.Hint;
			}
		}

		private bool isValidInput(string guess)
		{
			if(guess.Length != 4)
			{
				MessageBox.Show("Invalid Input Length!\nYou need to input 4 numbers!");
				return false;
			}
			bool isInt = int.TryParse(guess, out int value);

			if (!isInt)
			{
				MessageBox.Show("Input Error!\nYou need to input 4 numbers!");
				return false;
			}
			for(int i = 0; i < guess.Length; i++)
			{
				for(int j = i+1; j < guess.Length; j++)
				{
					if (guess[i] == guess[j])
					{
						MessageBox.Show("No duplicate numbers!");
						return false;
					}
				}
			}

			return true;
		}

		private string GetInput()
		{
			string input = txtGuess.Text;
			return input;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

public class GameResult
{
	public bool isSuccess { get; set; }
	public bool isFailed 
	{
		get { return !isSuccess; }
	}
	public string Hint { get; set; }
}

/// <summary>
/// 1A2B Game
/// </summary>
public class Game1A2B
{
	private string answer;//store the answer

	public string Hint 
	{ 
		get; 
		set; 
	}
	/// <summary>
	/// initialize the game
	/// </summary>
	public void GameStart()
	{
		answer = String.Empty;
		this.Hint = String.Empty;
		Random random = new Random();
		int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		for(int i = 0; i < nums.Length; i++)
		{
			int index = random.Next(0,10);
			swap(ref nums[i], ref nums[index]);
		}

		for(int i = 0; i < 4; i++)
		{
			answer += nums[i].ToString();
		}
		//MessageBox.Show(answer);
	}

	public GameResult Check(string guess)
	{
		if(guess == answer)
		{
			this.Hint += $"[{answer}\t4A0B]";
			return new GameResult { isSuccess = true, Hint = this.Hint };
		}

		int A = 0, B = 0;
		for(int i = 0; i < guess.Length; i++)
		{
			for(int j = 0; j < answer.Length; j++)
			{
				if (guess[i] == answer[j] && i == j)
				{
					A++;
				}
				else if( guess[i] == answer[j])
				{
					B++;
				}
			}
		}

		this.Hint += $"{guess}\t{A}A{B}B\r\n";
		return new GameResult { isSuccess = false, Hint = this.Hint };
	}

	/// <summary>
	/// interchange the values of two arguments
	/// </summary>
	/// <param name="v1">argument 1</param>
	/// <param name="v2">argument 2</param>
	private void swap(ref int v1, ref int v2)
	{
		int temp = v1;
		v1 = v2;
		v2 = temp;
	}
}