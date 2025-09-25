using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphByList graph = new GraphByList(new Student("Иванов Иван", 4.0));
            Node n1 = graph.AddNode(new Student("Александров Александр", 5.0));
            Node n2 = graph.AddNode(new Student("Егоров Егор", 4.3), n1);
            Node n3 = graph.AddNode(new Student("Евгеньев Евгений", 3.4), n1);

            graph.AddEdge(n2, n3);
            graph.AddEdge(n1, n3);

            Console.WriteLine();

            double overallAverage = graph.AccountGrades();
            Console.WriteLine($"Средняя успеваемость: {overallAverage:F2}");
            Student mostSociable = graph.FindMostSociable();
            Console.WriteLine($"Самый общительный: {mostSociable.FullName}");

        }
    }
}
