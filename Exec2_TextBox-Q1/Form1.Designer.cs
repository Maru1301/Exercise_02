namespace Exec2_TextBox_Q1
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
			this.btnShow = new System.Windows.Forms.Button();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(120, 128);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(75, 23);
			this.btnShow.TabIndex = 0;
			this.btnShow.Text = "顯示";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(108, 86);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(100, 22);
			this.txtNum.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(25, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "請輸入一個介於1~100之間的數";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnShow;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 192);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.btnShow);
			this.Name = "Form1";
			this.Text = "[1,100]";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label1;
	}
}

