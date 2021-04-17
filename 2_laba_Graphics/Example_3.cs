using System;
using System.Drawing;

namespace _2_laba_Graphics
{
    class Example_3
    {
        Double[] x0 = new double[3];
        Double[] y0 = new double[3];
        Double[] z0 = new double[3];

        Double[] x1 = new double[3];
        Double[] y1 = new double[3];
        Double[] z1 = new double[3];

        PointF[] points = new PointF[3];
        Double[,] m = new double[3, 3];
        public Example_3()
		{   // Задаем координаты вершин треугольника
			x0[0] = 500;
            y0[0] = 400;
            x0[1] = 600;
            y0[1] = 600;
            x0[2] = 700;
            y0[2] = 400;
        }

        public double RotateObject(double Pitch, double Yaw, double Roll, double x, double y, double z, double[] newX, double[] newY, int i)
        {
            m[0, 0] = Math.Cos(Yaw) * Math.Cos(Roll);
            m[0, 1] = -Math.Cos(Yaw) * Math.Sin(Roll);
            m[0, 2] = -Math.Sin(Yaw);
            m[1, 0] = Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Roll) * Math.Cos(Pitch);
            m[1, 1] = -Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Cos(Roll) * Math.Cos(Pitch);
            m[1, 2] = Math.Cos(Yaw);
            m[2, 0] = -Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Pitch) * Math.Sin(Roll);
            m[2, 1] = Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Sin(Pitch) * Math.Cos(Roll);
            m[2, 2] = Math.Cos(Yaw) * Math.Cos(Pitch);

            newX[i] = m[0, 0] * x + m[1, 0] * y + m[2, 0] * z;
            newY[i] = m[0, 1] * x + m[1, 1] * y + m[2, 1] * z;
            return m[0, 2] * x + m[1, 2] * y + m[2, 2] * z; ;
        }

        public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll)
        {
            z1[0] = RotateObject(Pitch, Yaw, Roll, x0[0], y0[0], z0[0], x1, y1, 0);
            z1[1] = RotateObject(Pitch, Yaw, Roll, x0[1], y0[1], z0[1], x1, y1, 1);
            z1[2] = RotateObject(Pitch, Yaw, Roll, x0[2], y0[2], z0[2], x1, y1, 2);

            points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
            points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
            points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

            graphic.DrawPolygon(new Pen(Color.Red, 2), points);
            graphic.FillPolygon(new SolidBrush(Color.Blue), points);
        }
    }
}
