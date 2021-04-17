using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_2
	{
		Double[] x0 = new double[3];
		Double[] y0 = new double[3];
		Double[] z0 = new double[3];

		Double[] x1 = new double[3];
		Double[] y1 = new double[3];
		Double[] z1 = new double[3];

		Double[] x2 = new double[3];
		Double[] y2 = new double[3];
		Double[] z2 = new double[3];

		Double[] x3 = new double[3];
		Double[] y3 = new double[3];
		Double[] z3 = new double[3];

		int x00, y00, z00;
		PointF[] points = new PointF[3];

		public Example_2()
		{   // Задаем координаты вершин треугольника
			x0[0] = 200;
			y0[0] = 100;
			x0[1] = 300;
			y0[1] = 300;
			x0[2] = 400;
			y0[2] = 100;
		}

		public Double RotatePitch(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x;
			newY[i] = y00 + (y - y00) * Math.Cos(alpha) + (z00 - z) * Math.Sin(alpha);
			return z00 + (y - y00) * Math.Sin(alpha) + (z - z00) * Math.Cos(alpha);
		}

		public Double RotateYaw(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x00 + (x - x00) * Math.Cos(alpha) + (z - z00) * Math.Sin(alpha);
			newY[i] = y;
			return z00 + (x00 - x) * Math.Sin(alpha) + (z - z00) * Math.Cos(alpha);
		}

		public Double RotateRoll(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x00 + (x - x00) * Math.Cos(alpha) + (y00 - y) * Math.Sin(alpha);
			newY[i] = y00 + (x - x00) * Math.Sin(alpha) + (y - y00) * Math.Cos(alpha);
			return z;
		}

		public void DrawShape(Graphics graphic, int Axis, double factX, double factY, double factZ, int Xoffset, int Yoffset, int Zoffset)
		{
			x00 = Xoffset;
			y00 = Yoffset;
			z00 = Zoffset;

			for (Axis = 0; Axis < 3; Axis++)
			{
				if (Axis == 0)
				{
					z1[0] = this.RotatePitch(x0[0], y0[0], z0[0], factX, 0, x1, y1);
					z1[1] = this.RotatePitch(x0[1], y0[1], z0[1], factX, 1, x1, y1);
					z1[2] = this.RotatePitch(x0[2], y0[2], z0[2], factX, 2, x1, y1);
				}
				else if (Axis == 1)
				{
					z2[0] = this.RotateYaw(x1[0], y1[0], z1[0], factY, 0, x2, y2);
					z2[1] = this.RotateYaw(x1[1], y1[1], z1[1], factY, 1, x2, y2);
					z2[2] = this.RotateYaw(x1[2], y1[2], z1[2], factY, 2, x2, y2);
				}
				else if (Axis == 2)
				{
					z3[0] = this.RotateRoll(x2[0], y2[0], z2[0], factZ, 0, x3, y3);
					z3[1] = this.RotateRoll(x2[1], y2[1], z2[1], factZ, 1, x3, y3);
					z3[2] = this.RotateRoll(x2[2], y2[2], z2[2], factZ, 2, x3, y3);
				}
			}

			points[0] = new PointF(Convert.ToSingle(x3[0]), Convert.ToSingle(y3[0]));
			points[1] = new PointF(Convert.ToSingle(x3[1]), Convert.ToSingle(y3[1]));
			points[2] = new PointF(Convert.ToSingle(x3[2]), Convert.ToSingle(y3[2]));

			graphic.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(x00, y00, 7, 7));
			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);
		}
	}
}
