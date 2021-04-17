using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_Graphics
{
	public class VertexComparer : IComparer<NewSide>
	{
		public int Compare(NewSide o1, NewSide o2)
		{
			NewSide z1, z2;

			try
			{
				z1 = (NewSide)o1;
				z2 = (NewSide)o2;
			}
			catch (Exception e)
			{
				throw (e);
			}

			if (z1.z < z2.z) return 1;	// В данном случае производится сортировка по убыванию, в противном(случае);
			if (z1.z > z2.z) return -1;	// В данном случае производится сортировка по убыванию, в(противном);
			else return 0;
		}
	}
}
