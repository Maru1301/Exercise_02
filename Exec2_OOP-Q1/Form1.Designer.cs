namespace Exec2_OOP_Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGuess = new System.Windows.Forms.Button();
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.btnAgain = new System.Windows.Forms.Button();
			this.txtShow = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGuess
			// 
			this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGuess.Location = new System.Drawing.Point(233, 28);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(134, 53);
			this.btnGuess.TabIndex = 1;
			this.btnGuess.Text = "Enter";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// txtGuess
			// 
			this.txtGuess.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtGuess.Location = new System.Drawing.Point(39, 28);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(176, 51);
			this.txtGuess.TabIndex = 0;
			// 
			// btnAgain
			// 
			this.btnAgain.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAgain.Location = new System.Drawing.Point(121, 388);
			this.btnAgain.Name = "btnAgain";
			this.btnAgain.Size = new System.Drawing.Size(158, 44);
			this.btnAgain.TabIndex = 2;
			this.btnAgain.Text = "NewGame";
			this.btnAgain.UseVisualStyleBackColor = true;
			this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
			// 
			// txtShow
			// 
			this.txtShow.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtShow.Location = new System.Drawing.Point(63, 99);
			this.txtShow.Multiline = true;
			this.txtShow.Name = "txtShow";
			this.txtShow.ReadOnly = true;
			this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtShow.Size = new System.Drawing.Size(285, 266);
			this.txtShow.TabIndex = 4;
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnExit.Location = new System.Drawing.Point(304, 393);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(93, 36);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnGuess;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 444);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtShow);
			this.Controls.Add(this.btnAgain);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.btnGuess);
			this.Name = "Form1";
			this.Text = "1A2B";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGuess;
		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Button btnAgain;
		private System.Windows.Forms.TextBox txtShow;
		private System.Windows.Forms.Button btnExit;
	}
}

