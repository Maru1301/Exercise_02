namespace Exec2_OOP_Q2
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
			this.btnRoll = new System.Windows.Forms.Button();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblDice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRoll
			// 
			this.btnRoll.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRoll.Location = new System.Drawing.Point(112, 177);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(123, 59);
			this.btnRoll.TabIndex = 0;
			this.btnRoll.Text = "Roll";
			this.btnRoll.UseVisualStyleBackColor = true;
			this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblScore.Location = new System.Drawing.Point(151, 39);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(178, 50);
			this.lblScore.TabIndex = 1;
			this.lblScore.Text = "lblScore";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblDice
			// 
			this.lblDice.AutoSize = true;
			this.lblDice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblDice.Location = new System.Drawing.Point(116, 117);
			this.lblDice.Name = "lblDice";
			this.lblDice.Size = new System.Drawing.Size(105, 35);
			this.lblDice.TabIndex = 2;
			this.lblDice.Text = "lblDice";
			this.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 296);
			this.Controls.Add(this.lblDice);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnRoll);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblDice;
	}
}

