using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl; // для работы с библиотекой OpenGL
using Tao.FreeGlut; // для работы с библиотекой FreeGLUT
using Tao.Platform.Windows;// для работы с элементом управления SimpleOpenGLControl 
using Tao.DevIl;// ТЕКСТУРЫ
using OpenTK;

namespace _2_laba_Graphics
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			siOGlC.InitializeContexts();
		}

		public int mode = 0;
		Double factor = Math.PI / 180;
		
		double X = 1;
		double Y = 1;
		double Z = 1;
		
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
		Example_19 ex19;


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
			rotated = trackBar_angle_alpha.Value;
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
				case 19:
					ex19.DrawShape(e.Graphics, X, Y, Z, panel_drawing.Width, panel_drawing.Height);
					break;
				case 20:
					break;
			}
		}

		private void Example1_Click(object sender, EventArgs e)
		{	// Выбор 1 примера
			ex1 = new Example_1();
			mode = 1;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example2_Click(object sender, EventArgs e)
		{   // Выбор 2 примера
			ex2 = new Example_2();
			mode = 2;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example3_Click(object sender, EventArgs e)
		{   // Выбор 3 примера
			ex3 = new Example_3();
			mode = 3;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example4_Click(object sender, EventArgs e)
		{	// Выбор 4 примера
			ex4 = new Example_4();
			mode = 4;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example5_Click(object sender, EventArgs e)
		{   // Выбор 5 примера
			ex5 = new Example_5();
			mode = 5;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example6_Click(object sender, EventArgs e)
		{   // Выбор 6 примера
			ex6 = new Example_6();
			mode = 6;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example7_Click(object sender, EventArgs e)
		{   // Выбор 7 примера
			ex7 = new Example_7();
			mode = 7;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example8_Click(object sender, EventArgs e)
		{   // Выбор 8 примера
			ex8 = new Example_8();
			mode = 8;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = true;
			panel_angle.Visible = true;
			panel_drawing.Refresh();
		}

		private void Example9_Click(object sender, EventArgs e)
		{   // Выбор 9 примера
			ex9 = new Example_9();
			mode = 9;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example10_Click(object sender, EventArgs e)
		{   // Выбор 10 примера
			ex10 = new Example_10();
			mode = 10;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example11_Click(object sender, EventArgs e)
		{   // Выбор 11 примера
			pictureBox1.Visible = false;
			ex11 = new Example_11();
			mode = 11;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example12_Click(object sender, EventArgs e)
		{   // Выбор 12 примера
			pictureBox1.Visible = false;
			ex12 = new Example_12();
			mode = 12;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example13_Click(object sender, EventArgs e)
		{   // Выбор 13 примера
			pictureBox1.Visible = false;
			ex13 = new Example_13();
			mode = 13;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example14_Click(object sender, EventArgs e)
		{   // Выбор 14 примера
			pictureBox1.Visible = false;
			ex14 = new Example_14();
			mode = 14;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example15_Click(object sender, EventArgs e)
		{   // Выбор 15 примера
			pictureBox1.Visible = false;
			ex15 = new Example_15();
			mode = 15;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example16_Click(object sender, EventArgs e)
		{   // Выбор 16 примера
			pictureBox1.Visible = false;
			ex16 = new Example_16();
			mode = 16;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example17_Click(object sender, EventArgs e)
		{   // Выбор 17 примера
			pictureBox1.Visible = false;
			ex17 = new Example_17();
			mode = 17;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example18_Click(object sender, EventArgs e)
		{   // Выбор 18 примера
			pictureBox1.Visible = false;
			ex18 = new Example_18();
			ex18.FillClippedCone();
			mode = 18;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = false;
			panel_drawing.Refresh();
		}

		private void Example19_Click(object sender, EventArgs e)
		{   // Выбор 19 примера
			//pictureBox1.Visible = false;
			//ex19 = new Example_19();
			//mode = 19;
			//panel_XYZ.Visible = true;
			//panel_XYZ1.Visible = false;
			//panel_angle.Visible = false;
			//panel_drawing.Refresh();
			//siOGlC.Visible = false;
			//panel_Check_XYZ.Visible = false;
			comand = 1;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			siOGlC.Visible = true;
			panel_Check_XYZ.Visible = true;
		}

		private void Example20_Click(object sender, EventArgs e)
		{   // Выбор 20 примера
			//_tor = new DrawTor();
			//mode = 20;
			comand = 2;
			//pictureBox1.Visible = true;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			//panel_drawing.Refresh();
			//button1.Visible = true;
			//button2.Visible = true;
			siOGlC.Visible = true;
			panel_Check_XYZ.Visible = true;
		}

		private void Example21_Click(object sender, EventArgs e)
		{
			comand = 3;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			siOGlC.Visible = true;
			panel_Check_XYZ.Visible = true;
		}

		private void Example22_Click(object sender, EventArgs e)
		{
			comand = 4;
			panel_XYZ.Visible = true;
			panel_XYZ1.Visible = false;
			panel_angle.Visible = true;
			siOGlC.Visible = true;
			panel_Check_XYZ.Visible = true;
		}

		DrawTor _tor;
		int i = 0;
		int typeDraw;
		private void button1_Click(object sender, EventArgs e)
		{
			typeDraw = 0;
			timer1.Enabled = false;
			timer1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
		}
		public void Draw(int type)
		{
			pictureBox1.Image = _tor.DrawingTor(pictureBox1.Width, pictureBox1.Height, 300, type);
			timer1.Enabled = true;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			Draw(typeDraw);
			_tor.Speed = i + 1;
			i++;
		}

		// ряд вспомогательных переменных
		double rotated = 0.0f;	// Поворот
		float color, color1, color2 = 0.0f;

		int comand = 0; // Какая фигура выбрана
		int COLORcomand = 2;	// Цвет фигуры
		
		int oX = 0, oY = 0, oZ = 0; // Выбор оси поворота
		private void checkBox_oX_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_oX.Checked)
				oX = 1;
			else oX = 0;
		}

		private void checkBox_oY_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_oY.Checked)
				oY = 1;
			else oY = 0;
		}
		private void checkBox_oZ_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_oZ.Checked)
				oZ = 1;
			else oZ = 0;
		}
		private void button_sbros_Click(object sender, EventArgs e)
		{
			oX = oY = oZ = 0;
			X = Y = Z = 1;
			trackBar_angle_alpha.Value = 1*factor;
			trackBar_Pitch.Value = 57;
			trackBar_Roll.Value = 57;
			trackBar_Yaw.Value = 1;
			trackBar_PitchOffset.Value = 1;
			trackBar_RollOffSet.Value = 1;
			trackBar_YawOffSet.Value = 1;
			checkBox_oX.Checked = false;
			checkBox_oY.Checked = false;
			checkBox_oZ.Checked = false;
		}
		private void siOGlC_Paint(object sender, PaintEventArgs e)
		{
			Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
			Gl.glLoadIdentity();
			switch (COLORcomand)
			{
				case 1: color = 1.0f; color2 = 0.0f; Gl.glColor3f(color, color1, color2); break;
				case 2: color1 = 5.0f; color = 0.0f; Gl.glColor3f(color, color1, color2); break;
				case 3: color2 = 9.0f; color1 = 0.0f; Gl.glColor3f(color, color1, color2); break;
			}
			Gl.glPushMatrix();
			Gl.glTranslated(0, 0, -6); Gl.glRotated(rotated, oX, oY, oZ); Gl.glScaled(X, Y, Z);
			//Gl.glOrtho(-1, 1, -1, 1, -11, 11);
			

			switch (comand)
			{
				case 1: Glut.glutWireCube(2); Gl.glFlush(); Gl.glColor3f(1.0f, 0.0f, 0.0f); Glut.glutWireSphere(1, 20, 50); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
				case 2: Glut.glutWireTorus(0.32, 0.69, 52, 52); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
				case 3: Glut.glutWireSphere(2, 20, 50); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
				case 4:
					Gl.glTranslated(0, -1.5, -6); Gl.glColor3f(1.0f, 0.0f, 0.0f); Glut.glutWireSphere(0.6, 20, 50); Gl.glFlush();
					Gl.glTranslated(0, 1, 0); Gl.glColor3f(0.0f, 0.0f, 1.0f); Glut.glutSolidSphere(0.5, 20, 50); Gl.glFlush();
					Gl.glTranslated(0, 0.8, 0); Gl.glColor3f(1.0f, 1.0f, 1.0f); Glut.glutWireSphere(0.4, 20, 50); Gl.glFlush();
					Gl.glTranslated(0, 0.6, 0); Gl.glColor3f(0.0f, 1.0f, 0.0f); Glut.glutSolidSphere(0.3, 20, 50);  Gl.glFlush();
					Gl.glTranslated(0, 0.4, 0); Gl.glColor3f(1.0f, 1.0f, 1.0f); Glut.glutWireSphere(0.2, 20, 50); Gl.glFlush();
					Gl.glTranslated(0, 0.3, 0); Gl.glColor3f(0.0f, 0.0f, 1.0f); Glut.glutSolidSphere(0.15, 20, 50); Gl.glFlush();

					Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
					//case 3: Glut.glutWireDodecahedron(); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
					//case 4: Glut.glutWireTeapot(0.95); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
					//case 5: Glut.glutWireCylinder(2, 2, 32, 32); Gl.glPopMatrix(); Gl.glFlush(); siOGlC.Invalidate(); break;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// инициализация Glut 
			Glut.glutInit(); Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
			// отчитка окна 
			Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
			// установка порта вывода в соответствии с размерами элемента siOGlC 
			Gl.glViewport(0, 0, siOGlC.Width, siOGlC.Height);
			// настройка проекции 
			Gl.glMatrixMode(Gl.GL_PROJECTION); Gl.glLoadIdentity();
			Glu.gluPerspective(45, (float)siOGlC.Width / (float)siOGlC.Height, 0.2, 200);
			Gl.glMatrixMode(Gl.GL_MODELVIEW); Gl.glLoadIdentity();
			// настройка параметров OpenGL для визуализации
			Gl.glEnable(Gl.GL_DEPTH_TEST);
		}
	}
}
