using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_14
	{
		public double RotateObject(double Pitch, double Yaw, double Roll, double x, double y, double z, ref double NewX, ref double NewY)
		{
			double[,] m = new double[3, 3];
			m[0, 0] = Math.Cos(Yaw) * Math.Cos(Roll);
			m[0, 1] = -Math.Cos(Yaw) * Math.Sin(Roll);
			m[0, 2] = -Math.Sin(Yaw);
			m[1, 0] = Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Roll)
			* Math.Cos(Pitch);
			m[1, 1] = -Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Cos(Roll)
			* Math.Cos(Pitch);
			m[1, 2] = Math.Cos(Yaw);
			m[2, 0] = -Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Pitch)
			* Math.Sin(Roll);
			m[2, 1] = Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Sin(Pitch)
			* Math.Cos(Roll);
			m[2, 2] = Math.Cos(Yaw) * Math.Cos(Pitch);
			double NewZ;
			NewX = m[0, 0] * x + m[1, 0] * y + m[2, 0] * z;
			NewY = m[0, 1] * x + m[1, 1] * y + m[2, 1] * z;
			NewZ = m[0, 2] * x + m[1, 2] * y + m[2, 2] * z;
			return NewZ;
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, int Width, int Height)
		{
			int x0, y0, z0, R, L, m;
			x0 = 100;
			y0 = 100;
			z0 = 100;
			R = 50;
			L = 100;
			m = 3; // Шаг итерации
			int i, j;
			for (i = x0 - R; i <= x0 + R; i += m)
			{
				int y1, y2;
				y1 = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - x0), 2)));
				y2 = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - x0), 2)));
				double x11 = 0, y11 = 0, z11 = 0;
				double x21 = 0, y21 = 0, z21 = 0;
				z11 = RotateObject(Pitch, Yaw, Roll, i, y1, z0, ref x11, ref y11);
				z21 = RotateObject(Pitch, Yaw, Roll, i, y2, z0, ref x21, ref y21);
				Rectangle MyBox1 = new Rectangle(Convert.ToInt32(x11), Convert.ToInt32(y11), m, m);
				Rectangle MyBox2 = new Rectangle(Convert.ToInt32(x21), Convert.ToInt32(y21), m, m);
				Pen MyPen1 = new Pen(Color.Green, 1);
				Pen MyPen2 = new Pen(Color.Orchid, 1);
				graphic.DrawLine(MyPen2, Convert.ToInt32(x11), Convert.ToInt32(y11), Convert.ToInt32(x21), Convert.ToInt32(y21));
				graphic.DrawEllipse(MyPen1, MyBox1);
				graphic.DrawEllipse(MyPen2, MyBox2);
			}

			for (i = z0 - m; i <= z0 + L - m; i += m)
			{
				for (j = x0 - R; j <= x0 + R; j += m)
				{
					int y1, y2;
					y1 = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(R, 2) - Math.Pow((j - x0), 2)));
					y2 = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(R, 2) - Math.Pow((j - x0), 2)));
					double x11 = 0, y11 = 0, z11 = 0;
					double x21 = 0, y21 = 0, z21 = 0;
					z11 = RotateObject(Pitch, Yaw, Roll, j, y1, i, ref x11, ref y11);
					z21 = RotateObject(Pitch, Yaw, Roll, j, y2, i, ref x21, ref y21);
					Rectangle MyBox1 = new Rectangle(Convert.ToInt32(x11), Convert.ToInt32(y11), m, m);
					Rectangle MyBox2 = new Rectangle(Convert.ToInt32(x21), Convert.ToInt32(y21), m, m);
					Pen MyPen1 = new Pen(Color.Blue, 1);
					Pen MyPen2 = new Pen(Color.Red, 1);
					graphic.DrawEllipse(MyPen1, MyBox1);
					graphic.DrawEllipse(MyPen2, MyBox2);
				}
			}

			for (i = x0 - R; i <= x0 + R; i += m)
			{
				int y1, y2;
				y1 = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - x0), 2)));
				y2 = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - x0), 2)));
				double x11 = 0, y11 = 0, z11 = 0;
				double x21 = 0, y21 = 0, z21 = 0;
				z11 = RotateObject(Pitch, Yaw, Roll, i, y1, z0 + L, ref x11, ref y11);
				z21 = RotateObject(Pitch, Yaw, Roll, i, y2, z0 + L, ref x21, ref y21);
				Rectangle MyBox1 = new Rectangle(Convert.ToInt32(x11), Convert.ToInt32(y11), m, m);
				Rectangle MyBox2 = new Rectangle(Convert.ToInt32(x21), Convert.ToInt32(y21), m, m);
				Pen MyPen1 = new Pen(Color.Green, 1);
				Pen MyPen2 = new Pen(Color.Orchid, 1);
				graphic.DrawLine(MyPen2, Convert.ToInt32(x11), Convert.ToInt32(y11), Convert.ToInt32(x21), Convert.ToInt32(y21));
				graphic.DrawEllipse(MyPen1, MyBox1);
				graphic.DrawEllipse(MyPen2, MyBox2);
			}

			Matrix myMatrix = new Matrix();
			myMatrix.Translate(Width / (float)2, Height / (float)2, MatrixOrder.Append);
			graphic.Transform = myMatrix;
		}
	}
}
