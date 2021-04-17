using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_13
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
			int x0, y0, z0, h, d, m;
			x0 = 0;
			y0 = 0;
			z0 = 0;
			h = 150;
			d = 70;
			m = 3;
			double i, j, k;
			Pen MyPen1 = new Pen(Color.Blue, 1);
			Pen MyPen2 = new Pen(Color.Red, 1);
			Pen MyPen3 = new Pen(Color.Green, 1);
			Pen MyPen4 = new Pen(Color.Black, 1);
			double XMin, Xmax;
			for (i = z0; i <= z0 + h; i += m)
			{
				XMin = -(z0 + i) * d / (2 * h);
				Xmax = (z0 + i) * d / (2 * h);
				for (j = XMin; j <= Xmax; j += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					double newx2 = 0, newy2 = 0, newz2 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, XMin, j, i, ref newx1, ref newy1);
					newz2 = RotateObject(Pitch, Yaw, Roll, Xmax, j, i, ref newx2, ref newy2);
					Rectangle MyBox1 = new Rectangle(System.Convert.ToInt32(newx1), System.Convert.ToInt32(newy1), 1, 1);
					Rectangle MyBox2 = new Rectangle(System.Convert.ToInt32(newx2), System.Convert.ToInt32(newy2), 1, 1);
					graphic.DrawEllipse(MyPen1, MyBox1);
					graphic.DrawEllipse(MyPen2, MyBox2);
				}

				for (k = XMin; k <= Xmax; k += m)
				{
					double newx1 = 0, newy1 = 0, newz1 = 0;
					double newx2 = 0, newy2 = 0, newz2 = 0;
					newz1 = RotateObject(Pitch, Yaw, Roll, k, Xmax, i, ref newx1, ref newy1);
					newz2 = RotateObject(Pitch, Yaw, Roll, k, XMin, i, ref newx2, ref newy2);
					Rectangle MyBox3 = new Rectangle(System.Convert.ToInt32(newx1), System.Convert.ToInt32(newy1), 1, 1);
					Rectangle MyBox4 = new Rectangle(System.Convert.ToInt32(newx2), System.Convert.ToInt32(newy2), 1, 1);
					graphic.DrawEllipse(MyPen3, MyBox3);
					graphic.DrawEllipse(MyPen4, MyBox4);
				}
			}

			XMin = -(z0 + h) * d / (double)(2 * h);
			Xmax = (z0 + h) * d / (double)(2 * h);
			Pen MyPen5 = new Pen(Color.Brown, 1);
			for (j = XMin; j <= Xmax; j += m)
			{
				double newx1 = 0, newy1 = 0, newz1 = 0;
				double newx2 = 0, newy2 = 0, newz2 = 0;
				newz1 = RotateObject(Pitch, Yaw, Roll, j, XMin, z0 + h, ref newx1, ref newy1);
				newz2 = RotateObject(Pitch, Yaw, Roll, j, Xmax, z0 + h, ref newx2, ref newy2);
				graphic.DrawLine(MyPen5, Convert.ToSingle(newx1), Convert.ToSingle(newy1), Convert.ToSingle(newx2), Convert.ToSingle(newy2));
			}

			Matrix myMatrix = new Matrix();
			myMatrix.Translate(Width / (float)2, Height / (float)2, MatrixOrder.Append);
			graphic.Transform = myMatrix;
		}
	}
}
