using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] a = { { 0,0,0,0},
                         { 0,0,1,0},
                         { 1,0,0,0},
                         { 1,0,1,0}
                        };

            GraphByMatrix graph = new GraphByMatrix(a);
            graph.Depth(0);*/

            GraphByList graph = new GraphByList(new Student("Шамсутдинов Рафаэлка", 4.5));
            Node n1 = graph.AddNode(new Student("Ю Джун Хек", 4.2));
            Node n2 = graph.AddNode(new Student("Султан Сулейман", 4.8), n1);
            Node n3 = graph.AddNode(new Student("Паучиха Алла", 3.9), n1);          
            Node n4 = graph.AddNode(new Student("Крид Егор", 4.6), n2);

            // graph.AddEdge(n4, n3);
            //graph.AddEdge(n2, n3);
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
