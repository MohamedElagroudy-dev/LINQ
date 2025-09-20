namespace Sorting_data.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

            var reveredOrder = fruits.Reverse();

            // fruits.Reverse(); // do nothing
            //fruits.Print("Employees in reverse order");

            Console.ReadKey();
        }
    }
}
