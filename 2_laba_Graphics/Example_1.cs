using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_1
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

		PointF[] points = new PointF[3];

		public Example_1()
		{   // Задаем координаты вершин треугольника
			x0[0] = 500;
			x0[1] = 600;
			x0[2] = 700;

			y0[0] = 400;
			y0[1] = 600;
			y0[2] = 500;

			z0[0] = 0;
			z0[1] = 0;
			z0[2] = 0;
		}

		public Double RotatePitch(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x;
			newY[i] = y * Math.Cos(alpha) - z * Math.Sin(alpha);
			return y * Math.Sin(alpha) + z * Math.Cos(alpha);
		}

		public Double RotateYaw(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x * Math.Cos(alpha) + z * Math.Sin(alpha);
			newY[i] = y;
			return -x * Math.Sin(alpha) + z * Math.Cos(alpha);
		}

		public Double RotateRoll(double x, double y, double z, double alpha, int i, double[] newX, double[] newY)
		{
			newX[i] = x * Math.Cos(alpha) - y * Math.Sin(alpha);
			newY[i] = x * Math.Sin(alpha) + y * Math.Cos(alpha);
			return z;
		}

		public void DrawShape(Graphics graphic, int Axis, double factX, double factY, double factZ)
		{
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

			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);
		}
	}
}
