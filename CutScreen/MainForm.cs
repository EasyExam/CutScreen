using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutScreen
{
	public partial class MainForm : Form
	{
		public static int i = 1;
		public MainForm()
		{
			InitializeComponent();
			TheNum.Text = "150";
		}

		private void CutNow(object sender, EventArgs e)
		{
			try
			{
				//Cut the screen
				Bitmap myImage = new Bitmap((Screen.PrimaryScreen.Bounds.Width * Convert.ToInt32(TheNum.Text)) / 100, (Screen.PrimaryScreen.Bounds.Height * Convert.ToInt32(TheNum.Text)) / 100);
				Graphics g = Graphics.FromImage(myImage);
				g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size((Screen.PrimaryScreen.Bounds.Width * Convert.ToInt32(TheNum.Text)) / 100, (Screen.PrimaryScreen.Bounds.Height * Convert.ToInt32(TheNum.Text)) / 100));
				myImage.Save(i.ToString() + ".bmp");
				i++;
				g.Dispose();
			}
			catch
			{
				//When error
				MessageBox.Show("出错了 (┬┬﹏┬┬)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
	}
}
