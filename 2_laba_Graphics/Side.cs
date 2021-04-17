using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_Graphics
{
	public class Side
	{
		public Vertex x1;
		public Vertex x2;
		public Vertex x3;
		public Vertex x4;
		public Side(Vertex x1, Vertex x2, Vertex x3, Vertex x4)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.x3 = x3;
			this.x4 = x4;
		}
	}
}
