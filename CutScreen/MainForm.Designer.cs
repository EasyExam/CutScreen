namespace CutScreen
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.L1 = new System.Windows.Forms.Label();
			this.Cut = new System.Windows.Forms.Button();
			this.TheNum = new System.Windows.Forms.TextBox();
			this.L2 = new System.Windows.Forms.Label();
			this.L3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// L1
			// 
			this.L1.AutoSize = true;
			this.L1.Font = new System.Drawing.Font("华文行楷", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.L1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.L1.Location = new System.Drawing.Point(8, 9);
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(465, 76);
			this.L1.TabIndex = 0;
			this.L1.Text = "我是截屏工具";
			// 
			// Cut
			// 
			this.Cut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Cut.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Cut.Location = new System.Drawing.Point(135, 215);
			this.Cut.Name = "Cut";
			this.Cut.Size = new System.Drawing.Size(205, 80);
			this.Cut.TabIndex = 1;
			this.Cut.Text = "点我";
			this.Cut.UseVisualStyleBackColor = false;
			this.Cut.Click += new System.EventHandler(this.CutNow);
			// 
			// TheNum
			// 
			this.TheNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TheNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TheNum.ForeColor = System.Drawing.Color.Blue;
			this.TheNum.Location = new System.Drawing.Point(148, 139);
			this.TheNum.Name = "TheNum";
			this.TheNum.Size = new System.Drawing.Size(192, 35);
			this.TheNum.TabIndex = 2;
			// 
			// L2
			// 
			this.L2.AutoSize = true;
			this.L2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.L2.ForeColor = System.Drawing.Color.Blue;
			this.L2.Location = new System.Drawing.Point(36, 142);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(106, 24);
			this.L2.TabIndex = 3;
			this.L2.Text = "缩放率：";
			// 
			// L3
			// 
			this.L3.AutoSize = true;
			this.L3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.L3.ForeColor = System.Drawing.Color.Blue;
			this.L3.Location = new System.Drawing.Point(356, 142);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(22, 24);
			this.L3.TabIndex = 4;
			this.L3.Text = "%";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(485, 374);
			this.Controls.Add(this.L3);
			this.Controls.Add(this.L2);
			this.Controls.Add(this.TheNum);
			this.Controls.Add(this.Cut);
			this.Controls.Add(this.L1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(507, 430);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(507, 430);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "截屏";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label L1;
		private System.Windows.Forms.Button Cut;
		private System.Windows.Forms.TextBox TheNum;
		private System.Windows.Forms.Label L2;
		private System.Windows.Forms.Label L3;
	}
}

