using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_18
	{
		public List<Vertex> GList = new List<Vertex>();

		public Example_18()
		{

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

		public ArrayList GetClippedCone(int Length, int RBig, int RSmall, int m)
		{
			ArrayList MyList = new ArrayList();
			double i, j;
			int ZMin, ZMax;
			ZMin = 0;
			ZMax = Length;
			for (i = ZMin; i <= ZMax; i += m)
			{
				int XMin, XMax;
				int SmallR;
				SmallR = Convert.ToInt32((RBig - i * (RBig - RSmall) / Length));
				XMin = -SmallR;
				XMax = SmallR;
				for (j = XMin; j <= XMax; j += m)
				{
					int YMin, YMax, x, z;
					x = Convert.ToInt32(j);
					z = Convert.ToInt32(i);
					YMin = Convert.ToInt32(-Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x), 2)));
					YMax = Convert.ToInt32(Math.Sqrt(Math.Pow(SmallR, 2) - Math.Pow((x), 2)));
					MyList.Add(new Vertex(j, YMin, i));
					MyList.Add(new Vertex(j, YMax, i));
				}
			}

			return MyList;
		}
		public void FillClippedCone()
		{
			int Segments_Count;
			Segments_Count = 3;
			int[] x = new int[Segments_Count + 1], y = new int[Segments_Count + 1], z = new int[Segments_Count + 1];
			double[] alpha = new double[Segments_Count + 1], beta = new double[Segments_Count + 1], Length = new double[Segments_Count + 1];
			int[] RBig = new int[Segments_Count + 1], RSmall = new int[Segments_Count + 1];
			int m;
			m = 5;
			RBig[0] = 60;
			RSmall[0] = 50;
			RBig[1] = 50;
			RSmall[1] = 40;
			RBig[2] = 40;
			RSmall[2] = 30;
			double factor;
			factor = Math.PI / 180;
			alpha[0] = factor * 15;
			beta[0] = factor * 25;
			alpha[1] = factor * 30;
			beta[1] = factor * 45;
			alpha[2] = factor * 15;
			beta[2] = factor * 30;
			Length[0] = 200;
			Length[1] = 150;
			Length[2] = 100;
			x[0] = 0;
			y[0] = 0;
			z[0] = 0;
			int i, j;
			for (i = 1; i <= Segments_Count; i++)
			{
				x[i] = x[i - 1] + System.Convert.ToInt32(Length[i - 1] * Math.Cos(beta[i - 1]) * Math.Sin(alpha[i - 1]));
				y[i] = y[i - 1] + System.Convert.ToInt32(Length[i - 1] * Math.Sin(beta[i - 1]));
				z[i] = z[i - 1] + System.Convert.ToInt32(Length[i - 1] * Math.Cos(beta[i - 1]) * Math.Cos(alpha[i - 1]));
				ArrayList MyList = new ArrayList();
				MyList = GetClippedCone(Convert.ToInt32(Length[i - 1]), RBig[i - 1], RSmall[i - 1], m);
				int MyListCount;
				MyListCount = MyList.Count - 1;
				for (j = 0; j <= MyListCount; j++)
				{
					int x1 = 0, y1 = 0, z1 = 0, newx = 0, newy = 0, newz;
					int p = 0;
					foreach (Vertex vert in MyList)
					{
						if (p == j)
						{
							x1 = Convert.ToInt32(vert.x);
							y1 = Convert.ToInt32(vert.y);
							z1 = Convert.ToInt32(vert.z);
						}
						p++;
					}
					newz = RotateAboutAlphaBeta(alpha[i - 1], beta[i - 1], x1, y1, z1, ref newx, ref newy);
					int nx, ny, nz;
					nx = newx + x[i - 1];
					ny = newy + y[i - 1];
					nz = newz + z[i - 1];
					GList.Add(new Vertex(nx, ny, nz));
				}
			}
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, int Width, int Height)
		{
			int GListCount;
			GListCount = GList.Count - 1;
			int i;
			Pen MyPen = new Pen(Color.Red, 1);
			for (i = 0; i <= GListCount; i++)
			{
				int x = 0, y = 0, z = 0;
				double newx = 0, newy = 0, newz;
				int p = 0;
				foreach (Vertex vert in GList)
				{
					if (p == i)
					{
						x = Convert.ToInt32(vert.x);
						y = Convert.ToInt32(vert.y);
						z = Convert.ToInt32(vert.z);
					}
					p++;
				}
				newz = RotateObject(Pitch, Yaw, Roll, x, y, z, ref newx, ref newy);
				Rectangle MyBox = new Rectangle(Convert.ToInt32(newx), Convert.ToInt32(newy), 1, 1);
				graphic.DrawEllipse(MyPen, MyBox);
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
