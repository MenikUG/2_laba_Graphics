using System;
using System.Drawing;

namespace _2_laba_Graphics
{
	class Example_8
	{
		Double[] x0 = new double[3];
		Double[] y0 = new double[3];
		Double[] z0 = new double[3];

		Double[] x1 = new double[3];
		Double[] y1 = new double[3];
		Double[] z1 = new double[3];

		PointF[] points = new PointF[3];

		public Example_8()
		{
			x0[0] = 200;
			y0[0] = 100;
			x0[1] = 300;
			y0[1] = 300;
			x0[2] = 400;
			y0[2] = 100;
		}

		public double RotateObject(double Angle, double Xoffset, double Yoffset, double Zoffset, double Pitch, double Yaw, double Roll, double x, double y, double z, double[] newX, double[] newY, int i)
		{
			double L = Math.Pow(Pitch, 2) + Math.Pow(Yaw, 2) + Math.Pow(Roll, 2);
			double SqrL = Math.Sqrt(L);
			double Lu = Math.Pow(Yaw, 2) + Math.Pow(Roll, 2);
			double Lv = Math.Pow(Pitch, 2) + Math.Pow(Roll, 2);
			double Lw = Math.Pow(Pitch, 2) + Math.Pow(Yaw, 2);
			newX[i] = (Xoffset * Lu + Pitch * (-Yoffset * Yaw - Zoffset * Roll + Pitch * x + Yaw * y
			+ Roll * z) + ((x - Xoffset) * Lu + Pitch * (Yoffset * Yaw + Zoffset * Roll - Yaw * y
			- Roll * z) + Lu * x) * Math.Cos(Angle) + SqrL * (-Zoffset * Yaw + Yoffset * Roll - Roll * y + Yaw * z) * Math.Sin(Angle)) / L;
			newY[i] = (Yoffset * Lv + Yaw * (-Xoffset * Pitch - Zoffset * Roll + Pitch * x + Yaw * y + Roll * z) + ((y - Yoffset) * Lv + Yaw * (Xoffset * Pitch + Zoffset * Roll - Pitch * x - Roll * z) + Lv * y) * Math.Cos(Angle) + SqrL * (-Zoffset * Pitch - Xoffset * Roll + Roll * x - Pitch * z) * Math.Sin(Angle)) / L;
			return (Zoffset * Lw + Roll * (-Xoffset * Pitch - Yoffset * Yaw + Pitch * x + Yaw * y + Roll * z) + ((z - Zoffset) * Lw + Roll * (Xoffset * Pitch + Yoffset * Yaw - Pitch * x - Yaw * y)
			+ Lw * z) * Math.Cos(Angle) + SqrL * (-Yoffset * Pitch + Xoffset * Yaw - Yaw * x + Pitch * y) * Math.Sin(Angle)) / L;
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, double Angle, int Xoffset, int Yoffset, int Zoffset)
		{
			z1[0] = RotateObject(Angle, Xoffset, Yoffset, Zoffset, Pitch, Yaw, Roll, x0[0], y0[0], z0[0], x1, y1, 0);
			z1[1] = RotateObject(Angle, Xoffset, Yoffset, Zoffset, Pitch, Yaw, Roll, x0[1], y0[1], z0[1], x1, y1, 1);
			z1[2] = RotateObject(Angle, Xoffset, Yoffset, Zoffset, Pitch, Yaw, Roll, x0[2], y0[2], z0[2], x1, y1, 2);

			points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
			points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
			points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

			PointF[] points1 = new PointF[2];
			points1[0] = new PointF(Convert.ToInt32(Xoffset), Convert.ToInt32(Yoffset));
			points1[1] = new PointF(Convert.ToInt32(Pitch), Convert.ToInt32(Yaw));

			graphic.DrawLines(new Pen(Color.Black, 2), points1);
			graphic.DrawPolygon(new Pen(Color.Red, 2), points);
			graphic.FillPolygon(new SolidBrush(Color.Blue), points);

		}
	}
}
