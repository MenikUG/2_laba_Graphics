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
		
		int X0 = 0;
		int Y0 = 0;
		int Z0 = 0;

		double angle_alpha = 0;
		int scrollAxis = 0;
		
		Example_1 ex1;
		Example_2 ex2;
		Example_3 ex3;
		Example_4 ex4;
		Example_5 ex5;
		Example_6 ex6;
		Example_7 ex7;
		Example_8 ex8;

		private void trackBar_Pitch_Scroll(object sender, EventArgs e)
		{	// Событие на перемещение ползунка в trackBar
			scrollAxis = 0;
			X = factor * trackBar_Pitch.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_Yaw_Scroll(object sender, EventArgs e)
		{	// Событие на перемещение ползунка в trackBar
			scrollAxis = 1;
			Y = factor * trackBar_Yaw.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_Roll_Scroll(object sender, EventArgs e)
		{   // Событие на перемещение ползунка в trackBar
			scrollAxis = 2;
			Z = factor * trackBar_Roll.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_PitchOffset_Scroll(object sender, EventArgs e)
		{   // Событие на перемещение ползунка в trackBar
			X0 = trackBar_PitchOffset.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_YawOffSet_Scroll(object sender, EventArgs e)
		{   // Событие на перемещение ползунка в trackBar
			Y0 = trackBar_YawOffSet.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_RollOffSet_Scroll(object sender, EventArgs e)
		{   // Событие на перемещение ползунка в trackBar
			Z0 = trackBar_RollOffSet.Value;
			panel_drawing.Refresh();
		}
		private void trackBar_angle_alpha_Scroll(object sender, EventArgs e)
		{   // Событие на перемещение ползунка в trackBar			
			angle_alpha = factor * trackBar_angle_alpha.Value;
			panel_drawing.Refresh();
		}
		private void panel_drawing_Paint(object sender, PaintEventArgs e)
		{
			switch (mode)
			{
				case 1:
					ex1.DrawShape(e.Graphics, scrollAxis, X, Y, Z);
					break;
				case 2:
					ex2.DrawShape(e.Graphics, scrollAxis, X, Y, Z, X0, Y0, Z0);
					break;
				case 3:
					ex3.DrawShape(e.Graphics, X, Y, Z);
					break;
				case 4:
					ex4.DrawShape(e.Graphics, X, Y, Z, angle_alpha, panel_drawing.Width);
					break;
				case 5:
					ex5.DrawShape(e.Graphics, X, Y, Z, angle_alpha, panel_drawing.Width, X0, Y0, Z0);
					break;
				case 6:
					ex6.DrawShape(e.Graphics, X, Y, Z, angle_alpha);
					break;
				case 7:
					ex7.DrawShape(e.Graphics, X, Y, Z, angle_alpha, X0, Y0, Z0);
					break;
				case 8:
					ex8.DrawShape(e.Graphics, X, Y, Z, angle_alpha, X0, Y0, Z0);
					break;
			}
		}

		private void Example1_Click(object sender, EventArgs e)
		{	// Выбор 1 примера
			ex1 = new Example_1();
			mode = 1;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example2_Click(object sender, EventArgs e)
		{   // Выбор 2 примера
			ex2 = new Example_2();
			mode = 2;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example3_Click(object sender, EventArgs e)
		{   // Выбор 3 примера
			ex3 = new Example_3();
			mode = 3;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example4_Click(object sender, EventArgs e)
		{	// Выбор 4 примера
			ex4 = new Example_4();
			mode = 4;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example5_Click(object sender, EventArgs e)
		{   // Выбор 5 примера
			ex5 = new Example_5();
			mode = 5;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example6_Click(object sender, EventArgs e)
		{   // Выбор 6 примера
			ex6 = new Example_6();
			mode = 6;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example7_Click(object sender, EventArgs e)
		{   // Выбор 7 примера
			ex7 = new Example_7();
			mode = 7;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example8_Click(object sender, EventArgs e)
		{   // Выбор 8 примера
			ex8 = new Example_8();
			mode = 8;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}
	}
}
