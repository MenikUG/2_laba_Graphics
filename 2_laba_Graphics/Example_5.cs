using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_5
	{
		Double[] x0 = new double[3];
		Double[] y0 = new double[3];
		Double[] z0 = new double[3];

		Double[] x1 = new double[3];
		Double[] y1 = new double[3];
		Double[] z1 = new double[3];

		PointF[] points = new PointF[3];

		public Example_5()
		{   // Задаем координаты вершин треугольника
			x0[0] = 200;
			y0[0] = 100;
			x0[1] = 300;
			y0[1] = 300;
			x0[2] = 400;
			y0[2] = 100;
		}

		public double RotateObject(double Angle, double Pitch, double Yaw, double Roll, double x, double y, double z, double x0, double y0, double z0, double[] newX, double[] newY, int i)
		{
			double temp;
			temp = 1.0 - Math.Cos(Angle);
			newX[i] = x0 + (x - x0) * (Pitch * temp * Pitch + Math.Cos(Angle)) + (y - y0) * (Yaw * temp * Pitch - Math.Sin(Angle) * Roll) + (z - z0) * (Roll * temp * Pitch + Math.Sin(Angle) * Yaw);
			newY[i] = y0 + (x - x0) * (Pitch * temp * Yaw + Math.Sin(Angle) * Roll) + (y - y0) * (Yaw * temp * Yaw + Math.Cos(Angle)) + (z - z0) * (Roll * temp * Yaw - Math.Sin(Angle) * Pitch);
			return z0 + (x - x0) * (Pitch * temp * Roll - Math.Sin(Angle) * Yaw) + (y - y0) * (Yaw * temp * Roll + Math.Sin(Angle) * Pitch) + (z - z0) * (Roll * temp * Roll + Math.Cos(Angle));
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, double Angle, int Width, int Xoffset, int Yoffset, int Zoffset)
		{
			z1[0] = RotateObject(Angle, Pitch, Yaw, Roll, x0[0], y0[0], z0[0], Xoffset, Yoffset, Zoffset, x1, y1, 0);
			z1[1] = RotateObject(Angle, Pitch, Yaw, Roll, x0[1], y0[1], z0[1], Xoffset, Yoffset, Zoffset, x1, y1, 1);
			z1[2] = RotateObject(Angle, Pitch, Yaw, Roll, x0[2], y0[2], z0[2], Xoffset, Yoffset, Zoffset, x1, y1, 2);

			points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
			points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
			points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

			double L;
			L = 5 * Width;
			PointF[] points1 = new PointF[2];
			points1[0] = new PointF(0, 0);
			points1[1] = new PointF(Convert.ToInt32(L * Math.Cos(Pitch)), Convert.ToInt32(L * Math.Cos(Yaw)));

			graphic.DrawLines(new Pen(Color.Black, 2), points1);
			graphic.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(Xoffset, Yoffset, 7, 7));
			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);
		}
	}
}
