namespace Exec2_TextBox_Q2
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
			this.lblEnter = new System.Windows.Forms.Label();
			this.txtEnter = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblEnter
			// 
			this.lblEnter.AutoSize = true;
			this.lblEnter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblEnter.Location = new System.Drawing.Point(86, 75);
			this.lblEnter.Name = "lblEnter";
			this.lblEnter.Size = new System.Drawing.Size(93, 20);
			this.lblEnter.TabIndex = 0;
			this.lblEnter.Text = "請輸入日期:";
			// 
			// txtEnter
			// 
			this.txtEnter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtEnter.Location = new System.Drawing.Point(181, 73);
			this.txtEnter.Name = "txtEnter";
			this.txtEnter.Size = new System.Drawing.Size(118, 29);
			this.txtEnter.TabIndex = 1;
			this.txtEnter.Text = "YYYY/MM/DD";
			// 
			// btnCheck
			// 
			this.btnCheck.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCheck.Location = new System.Drawing.Point(116, 113);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(125, 45);
			this.btnCheck.TabIndex = 2;
			this.btnCheck.Text = "輸入";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 229);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.txtEnter);
			this.Controls.Add(this.lblEnter);
			this.Name = "Form1";
			this.Text = "日期確認";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnter;
		private System.Windows.Forms.TextBox txtEnter;
		private System.Windows.Forms.Button btnCheck;
	}
}

