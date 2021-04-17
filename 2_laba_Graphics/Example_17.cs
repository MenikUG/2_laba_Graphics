using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace _2_laba_Graphics
{
	class Example_17
	{
		List<Vertex> MyList = new List<Vertex>();
		public int a, b, c, H, d, x0, y0, z0, R, m, L;
		public Example_17()
		{
			x0 = 200;
			y0 = 200;
			z0 = 0;
			R = 100;
			m = 5;
			L = 200;
			a = 50;
			b = 100;
			c = 150;
			H = 300;
			d = 150;

			double i, j;
			int ZMin, ZMax;
			ZMin = z0;
			ZMax = z0 + H;
			for (i = ZMin; i <= ZMax; i += m)
			{
				int XMin, XMax;
				int SmallR;
				SmallR = Convert.ToInt32((R / (double)H) * (H + z0 - i));
				XMin = x0 - SmallR;
				XMax = x0 + SmallR;
				for (j = XMin; j <= XMax; j += m)
				{
					int YMin, YMax, x, z;
					x = Convert.ToInt32(j);
					z = Convert.ToInt32(i);
					YMin = Convert.ToInt32(y0 - Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
					YMax = Convert.ToInt32(y0 + Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x - x0), 2)));
					MyList.Add(new Vertex(j, YMin, i));
					MyList.Add(new Vertex(j, YMax, i));
				}
			}
		}
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

		public int RotateAboutAlphaBeta(double alpha, double beta, int x0, int y0, int z0, ref int x, ref int y)
		{
			int z;
			x = Convert.ToInt32(Math.Cos(alpha) * x0 + Math.Sin(alpha) * Math.Sin(-beta) * y0 + Math.Sin(alpha) * Math.Cos(-beta) * z0);
			y = Convert.ToInt32(Math.Cos(-beta) * y0 - Math.Sin(-beta) * z0);
			z = Convert.ToInt32(-Math.Sin(alpha) * x0 + Math.Cos(alpha) * Math.Sin(-beta) * y0 + Math.Cos(alpha) * Math.Cos(-beta) * z0);
			return z;
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, int Width, int Height)
		{
			int x1, y1, z1, x2, y2, z2;
			double newx0 = 0, newy0 = 0, newz0, newx1 = 0, newy1 = 0, newz1, newx2 = 0, newy2 = 0, newz2;
			x1 = x0;
			y1 = y0;
			z1 = z0 + H;
			double alpha, beta;
			alpha = Math.PI / 4;
			beta = Math.PI / 4;
			x2 = Convert.ToInt32(H * Math.Sin(alpha) * Math.Cos(beta));
			y2 = Convert.ToInt32(H * Math.Sin(beta));
			z2 = Convert.ToInt32(H * Math.Cos(alpha) * Math.Cos(beta));
			newz0 = RotateObject(Pitch, Yaw, Roll, x0, y0, z0, ref newx0, ref newy0);
			newz1 = RotateObject(Pitch, Yaw, Roll, x1, y1, z1, ref newx1, ref newy1);
			newz2 = RotateObject(Pitch, Yaw, Roll, x2, y2, z2, ref newx2, ref newy2);
			Pen MyPen1 = new Pen(Color.Blue, 1);
			Pen MyPen2 = new Pen(Color.Red, 1);
			Point Point0 = new Point(Convert.ToInt32(newx0), Convert.ToInt32(newy0));
			Point Point1 = new Point(Convert.ToInt32(newx1), Convert.ToInt32(newy1));
			Point Point2 = new Point(Convert.ToInt32(newx2), Convert.ToInt32(newy2));
			graphic.DrawLine(MyPen1, Point0, Point1);
			graphic.DrawLine(MyPen2, Point0, Point2);
			int ListCount;
			ListCount = MyList.Count - 1;
			int i;
			Pen MyPen = new Pen(Color.Green, 1);
			Pen MyPen3 = new Pen(Color.Brown, 1);
			for (i = 0; i <= ListCount; i++)
			{
				int x, y, z; 
				double newx = 0, newy = 0, newz;
				x = Convert.ToInt32(MyList[i].x);
				y = Convert.ToInt32(MyList[i].y);
				z = Convert.ToInt32(MyList[i].z);
				int myx = 0, myy = 0, myz;
				double newmyx = 0, newmyy = 0, newmyz;
				myz = RotateAboutAlphaBeta(alpha, beta, x, y, z, ref myx, ref myy);
				newmyz = RotateObject(Pitch, Yaw, Roll, myx, myy, myz, ref newmyx, ref newmyy);
				newz = RotateObject(Pitch, Yaw, Roll, x, y, z, ref newx, ref newy);
				Rectangle MyBox1 = new Rectangle(Convert.ToInt32(newx), Convert.ToInt32(newy), 1, 1);
				Rectangle MyBox2 = new Rectangle(Convert.ToInt32(newmyx), Convert.ToInt32(newmyy), 1, 1);
				graphic.DrawEllipse(MyPen, MyBox1);
				graphic.DrawEllipse(MyPen3, MyBox2);
			}

			int xstart, ystart;
			xstart = Convert.ToInt32(Width / (double)2);
			ystart = Convert.ToInt32(Height / (double)2);
			Matrix MyMatrix = new Matrix();
			MyMatrix.Translate(xstart, ystart);
			graphic.Transform = MyMatrix;
		}
	}
}
