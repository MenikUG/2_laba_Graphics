using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_4
	{
		Double[] x0 = new double[3];
		Double[] y0 = new double[3];
		Double[] z0 = new double[3];

		Double[] x1 = new double[3];
		Double[] y1 = new double[3];
		Double[] z1 = new double[3];

		PointF[] points = new PointF[3];
		public Example_4()
		{   // Задаем координаты вершин треугольника
			x0[0] = 200;
			y0[0] = 100;
			x0[1] = 300;
			y0[1] = 300;
			x0[2] = 400;
			y0[2] = 100;
		}

		public double RotateObject(double Pitch, double Yaw, double Roll, double a, double x, double y, double z, double[] newX, double[] newY, int i)
		{
			double Temp;
			Temp = 1.0 - Math.Cos(a);
			newX[i] = x * (Pitch * Temp * Pitch + Math.Cos(a)) + y * (Yaw * Temp * Pitch - Math.Sin(a) * Roll) + z * (Roll * Temp * Pitch + Math.Sin(a) * Yaw);
			newY[i] = x * (Pitch * Temp * Yaw + Math.Sin(a) * Roll) + y * (Yaw * Temp * Yaw + Math.Cos(a)) + z * (Roll * Temp * Yaw - Math.Sin(a) * Pitch);
			return x * (Pitch * Temp * Roll - Math.Sin(a) * Yaw) + y * (Yaw * Temp * Roll + Math.Sin(a) * Pitch) + z * (Roll * Temp * Roll + Math.Cos(a));
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, double Angle, int Width)
		{
			z1[0] = RotateObject(Pitch, Yaw, Roll, Angle, x0[0], y0[0], z0[0], x1, y1, 0);
			z1[1] = RotateObject(Pitch, Yaw, Roll, Angle, x0[1], y0[1], z0[1], x1, y1, 1);
			z1[2] = RotateObject(Pitch, Yaw, Roll, Angle, x0[2], y0[2], z0[2], x1, y1, 2);

			points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
			points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
			points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

			double L = 5 * Width;

			PointF[] points1 = new PointF[2];
			points1[0] = new PointF(0,0);
			points1[1] = new PointF(Convert.ToInt32(L * Math.Cos(Pitch)), Convert.ToInt32(L * Math.Cos(Yaw)));

			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);
			graphic.DrawLines(new Pen(Color.Black, 2), points1);
		}
	}
}
