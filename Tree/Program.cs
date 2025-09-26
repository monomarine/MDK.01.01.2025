namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.AddNode(new People("Кирш Арина Андреевна", new DateTime(2007, 1, 22)));
            tree.AddNode(new People("Юсупова Айгерина Амангельдыевна", new DateTime(2007, 11, 19)));
            tree.AddNode(new People("Ларкин Кирлл Викторович", new DateTime(2007, 4, 4)));
            tree.AddNode(new People("Шамсутдинов Рафаил Ренатович", new DateTime(2005, 10, 31)));


            var people = tree.TreeTravelsal();

            Console.WriteLine("Все людишки на блюдечке:\n");
            foreach (var person in people)
                Console.WriteLine(person);

            double midleAge = tree.MiddleAge();
            Console.WriteLine($"\nСредний возраст: {midleAge:F1} лет");


            Console.ReadKey();
        }
    }
}
