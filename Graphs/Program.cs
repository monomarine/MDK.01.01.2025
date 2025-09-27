using Graphs;
using System.Collections.Concurrent;

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

            //GraphByList graph = new GraphByList("Москва");
            //Node n1 = graph.AddNode("Санкт-Петербург");
            //Node n2 = graph.AddNode("Оренбург", n1);
            //Node n3 = graph.AddNode("Омск", n1);

            //graph.AddEdge(n2, n3);

            //Node n4 = graph.AddNode("Уфа", n2);
            //graph.AddEdge(n4, n3);
            //graph.AddEdge(n4, n3);

            //graph.Width();

            //Console.WriteLine();

            //graph.Depht();

            //Формирование графа
            GraphByList graph = new GraphByList(new Student("Вадим Абдулов", 5f));
            Node n1 = graph.AddNode(new Student("Егор Буглаков", 3f));
            Node n2 = graph.AddNode(new Student("Тимофей пОпов", 2f), n1);
            Node n3 = graph.AddNode(new Student("Влад Ярцев", 6f), n1);


            Node n4 = graph.AddNode(new Student("Влад Абрамов", 3f), n2);

            Node n9 = graph.AddNode(new Student("Миша Йоу", 3f), n4);
            Node n5 = graph.AddNode(new Student("Таня Попова", 3f), n4);
            Node n6 = graph.AddNode(new Student("Алена", 3f), n4);
            Node n7 = graph.AddNode(new Student("Геннадий Сергеев", 3f), n4);
            Node n8 = graph.AddNode(new Student("Темочка Головчик", 3f), n4);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n4, null);

            Console.WriteLine("граф по ширине");
            graph.Width();
            Console.WriteLine();

            Console.WriteLine("граф по глубине");
            graph.Depht();
            Console.WriteLine();

            Console.WriteLine("средняя успеваемость всех студентов");
            Console.WriteLine(graph.CalculateAveragePerformance());
            Console.WriteLine();

            Console.WriteLine($"самый общительный студент: {graph.FindMostCommunicativeStudent().Value.Name}");




        }
    }
}