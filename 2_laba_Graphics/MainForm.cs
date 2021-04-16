using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_laba_Graphics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public int mode = 0;
		Double factor = Math.PI / 180;
		double X = 0;
		double Y = 0;
		double Z = 0;
		int scrollAxis = 0;
		Example_1 ex1;

		private void trackBar_Pitch_Scroll(object sender, EventArgs e)
		{
			scrollAxis = 0;
			X = factor * trackBar_Pitch.Value;
			panel_drawing.Refresh();
		}

		private void trackBar_Yaw_Scroll(object sender, EventArgs e)
		{
			scrollAxis = 1;
			Y = factor * trackBar_Yaw.Value;
			panel_drawing.Refresh();
		}

		private void trackBar_Roll_Scroll(object sender, EventArgs e)
		{
			scrollAxis = 2;
			Z = factor * trackBar_Roll.Value;
			panel_drawing.Refresh();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			ex1 = new Example_1();
			mode = 1;
			panel_drawing.Refresh();
		}

        private void panel_drawing_Paint(object sender, PaintEventArgs e)
        {
            switch (mode)
            {
				case 1:
					ex1.DrawShape(e.Graphics, scrollAxis, X, Y, Z);
					break;
			}
        }
    }
}
