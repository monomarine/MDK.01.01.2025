using Graphs;

namespace Graph
{
    public static class Program
    {
        public static void Main(string[] args)
        {
			int[,] a = { { 0,0,0,0},
						 { 0,0,1,0},
						 { 1,0,0,0},
						 { 1,0,1,0}
						};

			GraphByMatrix graph = new GraphByMatrix(a);
			graph.Depth(1);
		}
    }
}
