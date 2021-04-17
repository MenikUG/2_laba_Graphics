using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_16
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
			int x0, y0, z0, h, R, m;
			x0 = 200;
			y0 = 200;
			z0 = 200;
			h = 100;
			R = 60;
			m = 1;
			double i, j;
			int ZMin, ZMax;
			ZMin = z0;
			ZMax = z0 + h;
			int XMin, XMax;
			int SmallR;
			SmallR = Convert.ToInt32((R / (double)h) * (h + z0));
			XMin = x0 - SmallR;
			XMax = x0 + SmallR;
			for (j = XMin; j <= XMax; j += m)
			{
				int YMin, YMax, x, z;
				x = Convert.ToInt32(j);
				z = z0;
				YMin = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
				YMax = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
				double NewX1 = 0, NewY1 = 0, NewZ1, Newx2 = 0, NewY2 = 0, NewZ2;
				NewZ1 = RotateObject(Pitch, Yaw, Roll, x, YMin, z, ref NewX1, ref NewY1);
				NewZ2 = RotateObject(Pitch, Yaw, Roll, x, YMax, z, ref Newx2, ref NewY2);
				Pen MyPen1 = new Pen(Color.Yellow, 1);
				Pen MyPen2 = new Pen(Color.Blue, 1);
				Rectangle MyBox1 = new Rectangle(System.Convert.ToInt32(NewX1), System.Convert.ToInt32(NewY1), 1, 1);
				Rectangle MyBox2 = new Rectangle(System.Convert.ToInt32(Newx2), System.Convert.ToInt32(NewY2), 1, 1);
				graphic.DrawLine(MyPen1, Convert.ToInt32(NewX1), Convert.ToInt32(NewY1), Convert.ToInt32(Newx2), Convert.ToInt32(NewY2));
			}

			for (i = ZMin; i <= ZMax; i += m)
			{
				SmallR = Convert.ToInt32((R / (double)h) * (h + z0 - i));
				XMin = x0 - SmallR;
				XMax = x0 + SmallR;
				for (j = XMin; j <= XMax; j += m)
				{
					int YMin, YMax, x, z;
					x = Convert.ToInt32(j);
					z = Convert.ToInt32(i);
					YMin = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
					YMax = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
					double NewX1 = 0, NewY1 = 0, NewZ1, Newx2 = 0, NewY2 = 0, NewZ2;
					NewZ1 = RotateObject(Pitch, Yaw, Roll, x, YMin, z, ref NewX1, ref NewY1);
					NewZ2 = RotateObject(Pitch, Yaw, Roll, x, YMax, z, ref Newx2, ref NewY2);
					Pen MyPen1 = new Pen(Color.Red, 1);
					Pen MyPen2 = new Pen(Color.Blue, 1);
					Rectangle MyBox1 = new Rectangle(System.Convert.ToInt32(NewX1), System.Convert.ToInt32(NewY1), 1, 1);
					Rectangle MyBox2 = new Rectangle(System.Convert.ToInt32(Newx2), System.Convert.ToInt32(NewY2), 1, 1);
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
