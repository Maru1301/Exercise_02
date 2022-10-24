namespace Exec2_Star
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
			this.txtStars = new System.Windows.Forms.TextBox();
			this.lblRows = new System.Windows.Forms.Label();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnMiddle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtStars
			// 
			this.txtStars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStars.Location = new System.Drawing.Point(52, 113);
			this.txtStars.Multiline = true;
			this.txtStars.Name = "txtStars";
			this.txtStars.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtStars.Size = new System.Drawing.Size(436, 134);
			this.txtStars.TabIndex = 0;
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRows.Location = new System.Drawing.Point(48, 62);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(53, 24);
			this.lblRows.TabIndex = 1;
			this.lblRows.Text = "列數:";
			// 
			// txtRows
			// 
			this.txtRows.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtRows.Location = new System.Drawing.Point(107, 62);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(140, 29);
			this.txtRows.TabIndex = 2;
			// 
			// btnLeft
			// 
			this.btnLeft.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLeft.Location = new System.Drawing.Point(268, 57);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(77, 40);
			this.btnLeft.TabIndex = 3;
			this.btnLeft.Text = "靠左";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnRight
			// 
			this.btnRight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRight.Location = new System.Drawing.Point(350, 57);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(77, 40);
			this.btnRight.TabIndex = 4;
			this.btnRight.Text = "靠右";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			// 
			// btnMiddle
			// 
			this.btnMiddle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMiddle.Location = new System.Drawing.Point(432, 57);
			this.btnMiddle.Name = "btnMiddle";
			this.btnMiddle.Size = new System.Drawing.Size(77, 40);
			this.btnMiddle.TabIndex = 5;
			this.btnMiddle.Text = "等腰";
			this.btnMiddle.UseVisualStyleBackColor = true;
			this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 445);
			this.Controls.Add(this.btnMiddle);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.txtRows);
			this.Controls.Add(this.lblRows);
			this.Controls.Add(this.txtStars);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtStars;
		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.TextBox txtRows;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnMiddle;
	}
}

