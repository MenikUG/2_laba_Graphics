using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_12
	{
		public double RotateObject(double Pitch, double Yaw, double Roll, double x, double y, double z, ref double NewX, ref double NewY)
		{
			Double[,] m = new double[3, 3];
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
			int x0, y0, z0; // Координаты начала отсчета
			x0 = 200;
			y0 = 200;
			z0 = 0;
			int a, b, c; // Длины сторон параллепипеда
			a = 50;
			b = 50;
			c = 50;
			int i, j, k, l;
			int m; // Шаг итерации
			m = 3;
			Pen MyPen = new Pen(Color.Red);
			Pen MyPen1 = new Pen(Color.Blue, 1);
			Pen MyPen2 = new Pen(Color.Red, 1);
			Pen MyPen3 = new Pen(Color.Green, 1);
			Pen MyPen4 = new Pen(Color.Black, 1);
			Pen MyPen5 = new Pen(Color.Yellow, 1);
			Pen MyPen6 = new Pen(Color.Orchid, 1);
			for (i = x0; i <= x0 + a; i += m)
			{
				for (j = y0; j <= y0 + b; j += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, i, j, z0, ref newx1, ref newy1);
					Rectangle MyBox = new Rectangle(Convert.ToInt32(newx1), Convert.ToInt32(newy1), m, m);
					graphic.DrawEllipse(MyPen5, MyBox);
				}
			}

			for (i = z0 + m; i <= z0 + c - m; i += m)
			{
				for (j = y0; j <= y0 + b; j += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					double newx2 = 0, newy2 = 0, newz2 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, x0, j, i, ref newx1, ref newy1);
					newz2 = RotateObject(Pitch, Yaw, Roll, x0 + a, j, i, ref newx2, ref newy2);
					Rectangle MyBox1 = new Rectangle(System.Convert.ToInt32(newx1), System.Convert.ToInt32(newy1), m, m);
					Rectangle MyBox2 = new Rectangle(System.Convert.ToInt32(newx2), System.Convert.ToInt32(newy2), m, m);
					graphic.DrawEllipse(MyPen1, MyBox1);
					graphic.DrawEllipse(MyPen2, MyBox2);
				}

				for (k = x0; k <= x0 + a; k += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					double newx2 = 0, newy2 = 0, newz2 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, k, y0, i, ref newx1, ref newy1);
					newz2 = RotateObject(Pitch, Yaw, Roll, k, y0 + b, i, ref newx2, ref newy2);
					Rectangle MyBox3 = new Rectangle(System.Convert.ToInt32(newx1), System.Convert.ToInt32(newy1), m, m);
					Rectangle MyBox4 = new Rectangle(System.Convert.ToInt32(newx2), System.Convert.ToInt32(newy2), m, m);
					graphic.DrawEllipse(MyPen3, MyBox3);
					graphic.DrawEllipse(MyPen4, MyBox4);
				}
			}

			for (i = x0; i <= x0 + a; i += m)
			{
				for (j = y0; j <= y0 + b; j += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, i, j, z0 + c, ref newx1, ref newy1);
					Rectangle MyBox = new Rectangle(Convert.ToInt32(newx1), Convert.ToInt32(newy1), m, m);
					graphic.DrawEllipse(MyPen6, MyBox);
				}
			}

			Matrix myMatrix = new Matrix();
			myMatrix.Translate(Width / (float)2, Height / (float)2, MatrixOrder.Append);
			graphic.Transform = myMatrix;
		}
	}
}
