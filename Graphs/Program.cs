using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphByList graph = new GraphByList(new Student("Гарри Поттер", 4.6));
            Node n1 = graph.AddNode(new Student("Гермиона Грейнджер", 4.5));
            Node n2 = graph.AddNode(new Student("Рон Уизли", 4.3), n1);
            Node n3 = graph.AddNode(new Student("Том Реддл", 4.0), n1);
            Node n4 = graph.AddNode(new Student("Драко Малфой", 3.9), n2);

            graph.AddEdge(n2, n3);
            graph.AddEdge(n3, n4);
            graph.AddEdge(n1, n4);

            graph.Width();

            Console.WriteLine();

            double overallAverage = graph.AccountGrades();
            Console.WriteLine($"Средняя успеваемость всех студентов: {overallAverage:F2}");
            Student mostSociable = graph.FindMostSociable();
            Console.WriteLine($"Самый общительный студент: {mostSociable.FullName}");

            graph.Depht();
        }
    }
}