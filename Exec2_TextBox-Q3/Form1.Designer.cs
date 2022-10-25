namespace Exec2_TextBox_Q3
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
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblInput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCheck
			// 
			this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCheck.Location = new System.Drawing.Point(117, 98);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(96, 47);
			this.btnCheck.TabIndex = 0;
			this.btnCheck.Text = "Enter";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtInput.Location = new System.Drawing.Point(172, 48);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(150, 33);
			this.txtInput.TabIndex = 1;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInput.Location = new System.Drawing.Point(40, 54);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(126, 21);
			this.lblInput.TabIndex = 2;
			this.lblInput.Text = "請輸入你的生日:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 186);
			this.Controls.Add(this.lblInput);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.btnCheck);
			this.Name = "Form1";
			this.Text = "歲數確認";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblInput;
	}
}

