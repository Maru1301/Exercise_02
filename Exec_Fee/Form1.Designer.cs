namespace Exec_Fee
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
			this.grpInfo = new System.Windows.Forms.GroupBox();
			this.lblAge = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.rdbMale = new System.Windows.Forms.RadioButton();
			this.rdbFemale = new System.Windows.Forms.RadioButton();
			this.btnCalc = new System.Windows.Forms.Button();
			this.grpResult = new System.Windows.Forms.GroupBox();
			this.lblFee = new System.Windows.Forms.Label();
			this.lblShowFee = new System.Windows.Forms.Label();
			this.lblReason = new System.Windows.Forms.Label();
			this.lblShowReason = new System.Windows.Forms.Label();
			this.grpInfo.SuspendLayout();
			this.grpResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpInfo
			// 
			this.grpInfo.Controls.Add(this.btnCalc);
			this.grpInfo.Controls.Add(this.rdbFemale);
			this.grpInfo.Controls.Add(this.rdbMale);
			this.grpInfo.Controls.Add(this.lblGender);
			this.grpInfo.Controls.Add(this.txtAge);
			this.grpInfo.Controls.Add(this.lblAge);
			this.grpInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.grpInfo.Location = new System.Drawing.Point(35, 30);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new System.Drawing.Size(335, 117);
			this.grpInfo.TabIndex = 0;
			this.grpInfo.TabStop = false;
			this.grpInfo.Text = "客戶資訊";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Location = new System.Drawing.Point(7, 30);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(45, 20);
			this.lblAge.TabIndex = 0;
			this.lblAge.Text = "年齡:";
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(58, 27);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 29);
			this.txtAge.TabIndex = 1;
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(176, 30);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(45, 20);
			this.lblGender.TabIndex = 2;
			this.lblGender.Text = "性別:";
			// 
			// rdbMale
			// 
			this.rdbMale.AutoSize = true;
			this.rdbMale.Checked = true;
			this.rdbMale.Location = new System.Drawing.Point(227, 28);
			this.rdbMale.Name = "rdbMale";
			this.rdbMale.Size = new System.Drawing.Size(43, 24);
			this.rdbMale.TabIndex = 3;
			this.rdbMale.TabStop = true;
			this.rdbMale.Text = "男";
			this.rdbMale.UseVisualStyleBackColor = true;
			// 
			// rdbFemale
			// 
			this.rdbFemale.AutoSize = true;
			this.rdbFemale.Location = new System.Drawing.Point(276, 28);
			this.rdbFemale.Name = "rdbFemale";
			this.rdbFemale.Size = new System.Drawing.Size(43, 24);
			this.rdbFemale.TabIndex = 3;
			this.rdbFemale.TabStop = true;
			this.rdbFemale.Text = "女";
			this.rdbFemale.UseVisualStyleBackColor = true;
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(58, 76);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(95, 31);
			this.btnCalc.TabIndex = 4;
			this.btnCalc.Text = "計算";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// grpResult
			// 
			this.grpResult.Controls.Add(this.lblShowReason);
			this.grpResult.Controls.Add(this.lblReason);
			this.grpResult.Controls.Add(this.lblShowFee);
			this.grpResult.Controls.Add(this.lblFee);
			this.grpResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.grpResult.Location = new System.Drawing.Point(35, 169);
			this.grpResult.Name = "grpResult";
			this.grpResult.Size = new System.Drawing.Size(335, 106);
			this.grpResult.TabIndex = 1;
			this.grpResult.TabStop = false;
			this.grpResult.Text = "計算結果";
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Location = new System.Drawing.Point(7, 36);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(45, 20);
			this.lblFee.TabIndex = 0;
			this.lblFee.Text = "車資:";
			// 
			// lblShowFee
			// 
			this.lblShowFee.AutoSize = true;
			this.lblShowFee.Location = new System.Drawing.Point(58, 36);
			this.lblShowFee.Name = "lblShowFee";
			this.lblShowFee.Size = new System.Drawing.Size(94, 20);
			this.lblShowFee.TabIndex = 0;
			this.lblShowFee.Text = "lblShowFee";
			// 
			// lblReason
			// 
			this.lblReason.AutoSize = true;
			this.lblReason.Location = new System.Drawing.Point(7, 66);
			this.lblReason.Name = "lblReason";
			this.lblReason.Size = new System.Drawing.Size(45, 20);
			this.lblReason.TabIndex = 0;
			this.lblReason.Text = "原因:";
			// 
			// lblShowReason
			// 
			this.lblShowReason.AutoSize = true;
			this.lblShowReason.Location = new System.Drawing.Point(58, 66);
			this.lblShowReason.Name = "lblShowReason";
			this.lblShowReason.Size = new System.Drawing.Size(123, 20);
			this.lblShowReason.TabIndex = 0;
			this.lblShowReason.Text = "lblShowReason";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 321);
			this.Controls.Add(this.grpResult);
			this.Controls.Add(this.grpInfo);
			this.Name = "Form1";
			this.Text = "計算車資";
			this.grpInfo.ResumeLayout(false);
			this.grpInfo.PerformLayout();
			this.grpResult.ResumeLayout(false);
			this.grpResult.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpInfo;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.RadioButton rdbFemale;
		private System.Windows.Forms.RadioButton rdbMale;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.GroupBox grpResult;
		private System.Windows.Forms.Label lblShowReason;
		private System.Windows.Forms.Label lblReason;
		private System.Windows.Forms.Label lblShowFee;
		private System.Windows.Forms.Label lblFee;
	}
}

