﻿namespace Exec2_Message
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
			this.btnGreeting = new System.Windows.Forms.Button();
			this.lblGreeting = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGreeting
			// 
			this.btnGreeting.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGreeting.Location = new System.Drawing.Point(258, 77);
			this.btnGreeting.Name = "btnGreeting";
			this.btnGreeting.Size = new System.Drawing.Size(261, 104);
			this.btnGreeting.TabIndex = 0;
			this.btnGreeting.Text = "Press Me";
			this.btnGreeting.UseVisualStyleBackColor = true;
			this.btnGreeting.Click += new System.EventHandler(this.btnGreeting_Click);
			// 
			// lblGreeting
			// 
			this.lblGreeting.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGreeting.Location = new System.Drawing.Point(200, 241);
			this.lblGreeting.Name = "lblGreeting";
			this.lblGreeting.Size = new System.Drawing.Size(379, 109);
			this.lblGreeting.TabIndex = 1;
			this.lblGreeting.Text = "label1";
			this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblGreeting);
			this.Controls.Add(this.btnGreeting);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGreeting;
		private System.Windows.Forms.Label lblGreeting;
	}
}

