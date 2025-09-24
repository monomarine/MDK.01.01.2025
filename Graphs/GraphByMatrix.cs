using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
	internal class GraphByMatrix
	{
		private int size;
		private int[,] adjacency;
		private bool[] vector;

		public GraphByMatrix(int[,] adj)
		{
			if (adj == null) throw new ArgumentNullException();
			if (adj.GetLength(0) == adj.GetLength(1))
			{
				size = adj.GetLength(0);
				adjacency = adj;
				vector = new bool[size];
			}
		}

		public void Depth(int vertex)
		{
			vector[vertex] = true;
			//Console.WriteLine(vertex);
			for (int i = 0; i < size; i++)
			{
				Console.Write(adjacency[vertex, i]);
				if (adjacency[vertex, i] != 0 && !vector[i])
				{
					Console.WriteLine();
					Depth(i);
				}
			}
		}
	}
}
