namespace NET_hw3_FarmerGame
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.right = new System.Windows.Forms.Button();
			this.left = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 23;
			this.listBox1.Location = new System.Drawing.Point(12, 150);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(192, 234);
			this.listBox1.TabIndex = 0;
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 23;
			this.listBox2.Location = new System.Drawing.Point(311, 150);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(192, 234);
			this.listBox2.TabIndex = 1;
			// 
			// right
			// 
			this.right.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.right.Location = new System.Drawing.Point(210, 225);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(95, 40);
			this.right.TabIndex = 2;
			this.right.Text = "→";
			this.right.UseVisualStyleBackColor = true;
			this.right.Click += new System.EventHandler(this.Right_Click);
			// 
			// left
			// 
			this.left.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.left.Location = new System.Drawing.Point(210, 271);
			this.left.Name = "left";
			this.left.Size = new System.Drawing.Size(95, 40);
			this.left.TabIndex = 3;
			this.left.Text = "←";
			this.left.UseVisualStyleBackColor = true;
			this.left.Click += new System.EventHandler(this.Left_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(375, 412);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 26);
			this.button1.TabIndex = 4;
			this.button1.Text = "How to play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(491, 117);
			this.label1.TabIndex = 5;
			this.label1.Text = "Donald the farmer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.left);
			this.Controls.Add(this.right);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button right;
		private System.Windows.Forms.Button left;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}

