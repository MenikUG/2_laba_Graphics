using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_6
	{
		Double[] x0 = new double[3];
		Double[] y0 = new double[3];
		Double[] z0 = new double[3];

		Double[] x1 = new double[3];
		Double[] y1 = new double[3];
		Double[] z1 = new double[3];

		PointF[] points = new PointF[3];

		public Example_6()
		{   // Задаем координаты вершин треугольника
			x0[0] = 600;
			y0[0] = 500;
			x0[1] = 700;
			y0[1] = 700;
			x0[2] = 800;
			y0[2] = 500;
		}

		public double RotateObject(double Angle, double Pitch, double Yaw, double Roll, double x, double y, double z, double[] newX, double[] newY, int i)
		{
			double a, b, c, d, e;
			a = Pitch * x + Yaw * y + Roll * z;
			b = Math.Pow(Pitch, 2) + Math.Pow(Yaw, 2) + Math.Pow(Roll, 2);
			c = Math.Sqrt(b);
			d = Math.Cos(Angle);
			e = Math.Sin(Angle);
			newX[i] = (Pitch * a + (x * (Math.Pow(Yaw, 2) + Math.Pow(Roll, 2) - Pitch * (Yaw * y + Roll * z)) * d + c * (-Roll * y + Yaw * z) * e)) / b;
			newY[i] = (Yaw * a + (y * (Math.Pow(Pitch, 2) + Math.Pow(Roll, 2) - Yaw * (Pitch * x + Roll * z)) * d + c * (Roll * x - Pitch * z) * e)) / b;
			return (Roll * a + (z * (Math.Pow(Pitch, 2) + Math.Pow(Yaw, 2) - Roll * (Pitch * x + Yaw * y)) * d + c * (-Yaw * x + Pitch * y) * e)) / b;
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, double Angle)
		{
			z1[0] = RotateObject(Angle, Pitch, Yaw, Roll, x0[0], y0[0], z0[0], x1, y1, 0);
			z1[1] = RotateObject(Angle, Pitch, Yaw, Roll, x0[1], y0[1], z0[1], x1, y1, 1);
			z1[2] = RotateObject(Angle, Pitch, Yaw, Roll, x0[2], y0[2], z0[2], x1, y1, 2);

			points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
			points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
			points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

			PointF[] points1 = new PointF[2];
			points1[0] = new PointF(0, 0);
			points1[1] = new PointF(Convert.ToInt32(Pitch * (180 / Math.PI)), Convert.ToInt32(Yaw * (180 / Math.PI)));

			graphic.DrawLines(new Pen(Color.Red, 2), points1);
			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);
		}
	}
}
