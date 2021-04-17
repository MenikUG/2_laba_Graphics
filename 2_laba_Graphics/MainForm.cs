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
		Example_9 ex9;
		Example_10 ex10;
		Example_11 ex11;
		Example_12 ex12;
		Example_13 ex13;
		Example_14 ex14;
		Example_15 ex15;
		Example_16 ex16;
		Example_17 ex17;
		Example_18 ex18;


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
				case 9:
					ex9.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 10:
					ex10.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 11:
					ex11.DrawShape(e.Graphics, X, Y, Z);
					break;
				case 12:
					ex12.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 13:
					ex13.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 14:
					ex14.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 15:
					ex15.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 16:
					ex16.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 17:
					ex17.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 18:
					ex18.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
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

		private void Example9_Click(object sender, EventArgs e)
		{   // Выбор 9 примера
			ex9 = new Example_9();
			mode = 9;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example10_Click(object sender, EventArgs e)
		{   // Выбор 10 примера
			ex10 = new Example_10();
			mode = 10;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example11_Click(object sender, EventArgs e)
		{   // Выбор 11 примера
			ex11 = new Example_11();
			mode = 11;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example12_Click(object sender, EventArgs e)
		{   // Выбор 12 примера
			ex12 = new Example_12();
			mode = 12;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example13_Click(object sender, EventArgs e)
		{   // Выбор 13 примера
			ex13 = new Example_13();
			mode = 13;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example14_Click(object sender, EventArgs e)
		{	// Выбор 14 примера
			ex14 = new Example_14();
			mode = 14;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example15_Click(object sender, EventArgs e)
		{	// Выбор 15 примера
			ex15 = new Example_15();
			mode = 15;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example16_Click(object sender, EventArgs e)
		{   // Выбор 16 примера
			ex16 = new Example_16();
			mode = 16;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example17_Click(object sender, EventArgs e)
		{   // Выбор 17 примера
			ex17 = new Example_17();
			mode = 17;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example18_Click(object sender, EventArgs e)
		{   // Выбор 18 примера
			ex18 = new Example_18();
			ex18.FillClippedCone();
			mode = 18;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}
	}
}
