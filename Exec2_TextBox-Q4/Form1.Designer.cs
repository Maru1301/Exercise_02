namespace Exec2_TextBox_Q4
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
			this.lblCars = new System.Windows.Forms.Label();
			this.lblPeople = new System.Windows.Forms.Label();
			this.txtCars = new System.Windows.Forms.TextBox();
			this.txtPeople = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.txtShow = new System.Windows.Forms.TextBox();
			this.lblFee = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblCars
			// 
			this.lblCars.AutoSize = true;
			this.lblCars.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCars.Location = new System.Drawing.Point(37, 52);
			this.lblCars.Name = "lblCars";
			this.lblCars.Size = new System.Drawing.Size(61, 20);
			this.lblCars.TabIndex = 0;
			this.lblCars.Text = "車輛數:";
			// 
			// lblPeople
			// 
			this.lblPeople.AutoSize = true;
			this.lblPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPeople.Location = new System.Drawing.Point(230, 52);
			this.lblPeople.Name = "lblPeople";
			this.lblPeople.Size = new System.Drawing.Size(45, 20);
			this.lblPeople.TabIndex = 0;
			this.lblPeople.Text = "人數:";
			// 
			// txtCars
			// 
			this.txtCars.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCars.Location = new System.Drawing.Point(104, 49);
			this.txtCars.Name = "txtCars";
			this.txtCars.Size = new System.Drawing.Size(100, 29);
			this.txtCars.TabIndex = 0;
			// 
			// txtPeople
			// 
			this.txtPeople.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPeople.Location = new System.Drawing.Point(281, 49);
			this.txtPeople.Name = "txtPeople";
			this.txtPeople.Size = new System.Drawing.Size(100, 29);
			this.txtPeople.TabIndex = 1;
			// 
			// btnEnter
			// 
			this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEnter.Location = new System.Drawing.Point(398, 47);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(85, 31);
			this.btnEnter.TabIndex = 2;
			this.btnEnter.Text = "輸入";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// txtShow
			// 
			this.txtShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtShow.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtShow.Location = new System.Drawing.Point(112, 102);
			this.txtShow.Name = "txtShow";
			this.txtShow.ReadOnly = true;
			this.txtShow.Size = new System.Drawing.Size(371, 39);
			this.txtShow.TabIndex = 3;
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblFee.Location = new System.Drawing.Point(45, 110);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(53, 24);
			this.lblFee.TabIndex = 4;
			this.lblFee.Text = "費用:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 192);
			this.Controls.Add(this.lblFee);
			this.Controls.Add(this.txtShow);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.txtPeople);
			this.Controls.Add(this.txtCars);
			this.Controls.Add(this.lblPeople);
			this.Controls.Add(this.lblCars);
			this.Name = "Form1";
			this.Text = "計算入場費";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCars;
		private System.Windows.Forms.Label lblPeople;
		private System.Windows.Forms.TextBox txtCars;
		private System.Windows.Forms.TextBox txtPeople;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.TextBox txtShow;
		private System.Windows.Forms.Label lblFee;
	}
}

