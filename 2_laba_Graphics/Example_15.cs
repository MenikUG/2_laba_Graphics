using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_15
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
			int x0, y0, z0, R, m;
			x0 = 100;
			y0 = 100;
			z0 = 100;
			R = 50;
			m = 1;
			int ZMin, Zmax;
			ZMin = z0 - R;
			Zmax = z0 + R;
			int i, j;
			Pen MyPen1 = new Pen(Color.Blue, 1);
			Pen MyPen2 = new Pen(Color.Red, 1);
			for (i = ZMin; i <= Zmax; i += m)
			{
				int XMin, XMax;
				XMin = Convert.ToInt32(x0 - Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - z0), 2)));
				XMax = Convert.ToInt32(x0 + Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - z0), 2)));
				int SmallR;
				SmallR = Convert.ToInt32(Math.Sqrt(Math.Pow(R, 2) - Math.Pow((i - z0), 2)));
				for (j = XMin; j <= XMax; j += m)
				{
					double y1, y2;
					y1 = y0 + Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((j - x0), 2));
					y2 = y0 - Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((j - x0), 2));
					double NewX1 = 0, NewY1 = 0, NewZ1;
					double NewX2 = 0, NewY2 = 0, NewZ2;
					NewZ1 = RotateObject(Pitch, Yaw, Roll, j, y1, i, ref NewX1, ref NewY1);
					NewZ2 = RotateObject(Pitch, Yaw, Roll, j, y2, i, ref NewX2, ref NewY2);
					Rectangle MyBox1 = new Rectangle(Convert.ToInt32(NewX1), Convert.ToInt32(NewY1), m, m);
					Rectangle MyBox2 = new Rectangle(Convert.ToInt32(NewX2), Convert.ToInt32(NewY2), m, m);
					graphic.DrawEllipse(MyPen1, MyBox1);
					graphic.DrawEllipse(MyPen2, MyBox2);
				}
			}

			Matrix myMatrix = new Matrix();
			myMatrix.Translate(Width / (float)2, Height / (float)2, MatrixOrder.Append);
			graphic.Transform = myMatrix;
		}
	}
}
