using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	class Example_9
	{
		Double[,] m = new double[3, 3];

		public List <Vertex> VertexList = new List<Vertex>();
		public List <Side> SideList = new List<Side>();
		public Example_9()
		{
			VertexList.Add(new Vertex(0, 0, 0));
			VertexList.Add(new Vertex(100, 0, 0));
			VertexList.Add(new Vertex(100, 0, 100));
			VertexList.Add(new Vertex(0, 0, 100));
			VertexList.Add(new Vertex(0, 100, 0));
			VertexList.Add(new Vertex(100, 100, 0));
			VertexList.Add(new Vertex(100, 100, 100));
			VertexList.Add(new Vertex(0, 100, 100));
			SideList.Add(new Side(VertexList[0], VertexList[1], VertexList[2], VertexList[3]));
			SideList.Add(new Side(VertexList[4], VertexList[5], VertexList[6], VertexList[7]));
			SideList.Add(new Side(VertexList[6], VertexList[5], VertexList[1], VertexList[2]));
			SideList.Add(new Side(VertexList[7], VertexList[4], VertexList[0], VertexList[3]));
			SideList.Add(new Side(VertexList[0], VertexList[4], VertexList[5], VertexList[1]));
			SideList.Add(new Side(VertexList[7], VertexList[6], VertexList[2], VertexList[3]));
		}

		public double RotateObject(double Pitch, double Yaw, double Roll, double x, double y, double z, ref double NewX, ref double NewY)
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
			double NewZ;
			NewX = m[0, 0] * x + m[1, 0] * y + m[2, 0] * z;
			NewY = m[0, 1] * x + m[1, 1] * y + m[2, 1] * z;
			NewZ = m[0, 2] * x + m[1, 2] * y + m[2, 2] * z;
			return NewZ;
		}

		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll, int Width, int Height)
		{
			int ArraySize;
			ArraySize = 8;
			double[] NewX = new double[ArraySize + 1], NewY = new double[ArraySize + 1], NewZ = new double[ArraySize + 1];
			int i;

			Matrix myMatrix = new Matrix();
			myMatrix.Translate(Width / (float)2, Height / (float)2, MatrixOrder.Append);
			graphic.Transform = myMatrix;
			for (i = 0; i <= ArraySize - 1; i++)
			{
				NewZ[i] = RotateObject(Pitch, Yaw, Roll, VertexList[i].x, VertexList[i].y, VertexList[i].z, ref NewX[i], ref NewY[i]);
				Rectangle MyBox = new Rectangle(Convert.ToInt32(NewX[i]), Convert.ToInt32(NewY[i]), 10, 10);
				graphic.DrawEllipse(new Pen(Color.Red, 2), MyBox);
				graphic.FillEllipse(new SolidBrush(Color.Blue), MyBox);
			}
		}
	}
}
