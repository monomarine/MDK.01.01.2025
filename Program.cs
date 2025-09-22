namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StackOnArray stack = new StackOnArray();
                stack.Push("Москва");
                stack.Push("Екатеринбург");
                stack.Push("Оренбург");
                stack.Push("Самара");

                stack.Push("Орск");

                Console.WriteLine("последний элемент: " + stack.Peek());

                //Console.WriteLine(stack.Pop()) ;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }






        }
    }
}
