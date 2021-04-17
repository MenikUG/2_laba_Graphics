using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2_laba_Graphics
{
	public class Example_11
	{
		List<Side> Side_List = new List<Side>();
		Double[,] m = new double[3, 3];

		public Example_11()
		{
			Side_List.Add(new Side(new Vertex(300, 300, 300), new Vertex(400, 300, 300), new Vertex(400, 300, 400), new Vertex(300, 300, 400)));
			Side_List.Add(new Side(new Vertex(300, 300, 400), new Vertex(300, 400, 400), new Vertex(400, 400, 400), new Vertex(400, 300, 400)));
			Side_List.Add(new Side(new Vertex(300, 300, 400), new Vertex(300, 400, 400), new Vertex(300, 400, 300), new Vertex(300, 300, 300)));
			Side_List.Add(new Side(new Vertex(300, 300, 300), new Vertex(300, 400, 300), new Vertex(400, 400, 300), new Vertex(400, 300, 300)));
			Side_List.Add(new Side(new Vertex(400, 300, 300), new Vertex(400, 300, 400), new Vertex(400, 400, 400), new Vertex(400, 400, 300)));
			Side_List.Add(new Side(new Vertex(300, 400, 400), new Vertex(300, 400, 300), new Vertex(400, 400, 300), new Vertex(400, 400, 400)));
		}
		public Vertex RotateVertex(double Pitch, double Yaw, double Roll, Vertex MyVertex)
		{
			int x, y, z;
			int NewX, NewY, NewZ;
			x = Convert.ToInt32(MyVertex.x);
			y = Convert.ToInt32(MyVertex.y);
			z = Convert.ToInt32(MyVertex.z);
			m[0, 0] = Math.Cos(Yaw) * Math.Cos(Roll);
			m[0, 1] = -Math.Cos(Yaw) * Math.Sin(Roll);
			m[0, 2] = -Math.Sin(Yaw);
			m[1, 0] = Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Roll) * Math.Cos(Pitch);
			m[1, 1] = -Math.Sin(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Cos(Roll) * Math.Cos(Pitch);
			m[1, 2] = Math.Cos(Yaw);
			m[2, 0] = -Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Cos(Roll) + Math.Sin(Pitch) * Math.Sin(Roll);
			m[2, 1] = Math.Cos(Pitch) * Math.Sin(Yaw) * Math.Sin(Roll) + Math.Sin(Pitch) * Math.Cos(Roll);
			m[2, 2] = Math.Cos(Yaw) * Math.Cos(Pitch);
			NewX = System.Convert.ToInt32(m[0, 0] * x + m[1, 0] * y + m[2, 0] * z);
			NewY = System.Convert.ToInt32(m[0, 1] * x + m[1, 1] * y + m[2, 1] * z);
			NewZ = System.Convert.ToInt32(m[0, 2] * x + m[1, 2] * y + m[2, 2] * z);
			Vertex NewVertex = new Vertex(NewX, NewY, NewZ);
			return NewVertex;
		}

		public Side RotateSide(double Pitch, double Yaw, double Roll, Side MySide)
		{
			Vertex x1, x2, x3, x4;
			x1 = MySide.x1;
			x2 = MySide.x2;
			x3 = MySide.x3;
			x4 = MySide.x4;
			Vertex NewX1, NewX2, NewX3, NewX4;
			NewX1 = RotateVertex(Pitch, Yaw, Roll, x1);
			NewX2 = RotateVertex(Pitch, Yaw, Roll, x2);
			NewX3 = RotateVertex(Pitch, Yaw, Roll, x3);
			NewX4 = RotateVertex(Pitch, Yaw, Roll, x4);
			Side NewSide = new Side(NewX1, NewX2, NewX3, NewX4);
			return NewSide;
		}
		public void DrawShape(Graphics graphic, double Pitch, double Yaw, double Roll)
		{
			int Side_Count;
			Side_Count = Side_List.Count;
			List<NewSide> New_Side_List = new List<NewSide>();
			int i;
			SolidBrush[] MyBrush = new[] { new SolidBrush(Color.Blue), new SolidBrush(Color.Red), new SolidBrush(Color.Black), new SolidBrush(Color.Purple), new SolidBrush(Color.Orchid), new SolidBrush(Color.Green) };
			Side[] x = new Side[Side_Count + 1], newx = new Side[Side_Count + 1];
			for (i = 0; i <= Side_Count - 1; i++)
			{
				x[i] = Side_List[i];
				int a, b, c;
				a = Convert.ToInt32((Side_List[i].x1.x + Side_List[i].x2.x + Side_List[i].x3.x + Side_List[i].x4.x) / (double)4);
				b = Convert.ToInt32((Side_List[i].x1.y + Side_List[i].x2.y + Side_List[i].x3.y + Side_List[i].x4.y) / (double)4);
				c = Convert.ToInt32((Side_List[i].x1.z + Side_List[i].x2.z + Side_List[i].x3.z + Side_List[i].x4.z) / (double)4);
				Vertex V = new Vertex(a, b, c);
				Vertex NewV;
				NewV = RotateVertex(Pitch, Yaw, Roll, V);
				int z;
				z = Convert.ToInt32(NewV.z);
				newx[i] = RotateSide(Pitch, Yaw, Roll, x[i]);
				New_Side_List.Add(new NewSide(newx[i], z));
			}

			New_Side_List.Sort(new VertexComparer());
			for (i = 0; i <= Side_Count - 1; i++)
			{
				PointF[] curvePoints = new[] { new PointF(Convert.ToSingle(New_Side_List[i].x.x1.x), Convert.ToSingle(New_Side_List[i].x.x1.y)), new PointF(Convert.ToSingle(New_Side_List[i].x.x2.x), Convert.ToSingle(New_Side_List[i].x.x2.y)), new PointF(Convert.ToSingle(New_Side_List[i].x.x3.x), Convert.ToSingle(New_Side_List[i].x.x3.y)), new PointF(Convert.ToSingle(New_Side_List[i].x.x4.x), Convert.ToSingle(New_Side_List[i].x.x4.y)) };
				FillMode newFillMode = FillMode.Winding;
				graphic.FillPolygon(MyBrush[i], curvePoints, newFillMode);
			}

			int XStart, YStart;
			XStart = Convert.ToInt32(688 / (double)2);
			YStart = Convert.ToInt32(387 / (double)2);
			Matrix MyMatrix = new Matrix();
			MyMatrix.Translate(XStart, YStart);
			graphic.Transform = MyMatrix;
		}
	}
}
