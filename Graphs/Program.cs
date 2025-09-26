using Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Danil = new("Danil", "3pc1");
            Student Nikita = new("Nikita", "3pc1");
            Student Misha = new("Misha", "4pc1");
            Student Oleg = new("Oleg", "2pc1");
            Student Vlad = new("Roma", "3vb1");

            Danil.AddMark("Math", 2, 4, 5, 4);
            Nikita.AddMark("PE", 4, 4, 3, 5, 4);
            Misha.AddMark("Math", 5, 5, 5, 5, 4);
            Oleg.AddMark("Japaneese", 3, 4, 3, 5, 4 , 2, 4);
            Vlad.AddMark("Math", 5, 4, 4, 3, 5, 4);
            Danil.AddMark("Spanish", 5, 2, 5, 4);

            GraphByList graph = new GraphByList(Danil);
            Node n1 = graph.AddNode(Nikita);
            Node n2 = graph.AddNode(Misha, n1);
            Node n3 = graph.AddNode(Oleg, n1);
            Node n4 = graph.AddNode(Vlad, n3);

            graph.AddEdge(n2, null);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n4, n3);
            
            graph.Width();
            Console.WriteLine();
            graph.Depht();

            Console.WriteLine();
            Console.WriteLine("Student average marks: " + Math.Round(Student.GetAverage(), 3));
            Console.WriteLine("The most popular student: " + graph.GetPopularStudent());
        }
    }
}
