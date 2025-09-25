using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cоздание корневого студента
            GraphByList graph = new GraphByList(new Student("Иван", 4.2));

            // добавление остальных
            Node n1 = graph.AddNode(new Student("Мария", 4.8));
            Node n2 = graph.AddNode(new Student("Пётр", 3.9), n1);
            Node n3 = graph.AddNode(new Student("Анна", 4.5));

            // доп связи дружбв
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n3);

            // средняя успеваемость
            Console.WriteLine($"Средняя успеваемость: {graph.AverageGPA():F2}");

            // самый общительный студент
            Node mostSocial = graph.MostSocialStudent();
            Console.WriteLine($"Самый общительный студент: {mostSocial.Value.Name} (друзей: {mostSocial.Neighbors.Count})");
        }
    }
}
