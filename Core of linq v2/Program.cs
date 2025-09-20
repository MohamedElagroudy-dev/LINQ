using System.Linq;
namespace Core_of_linq_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);
            evenNumbers = numbers.Where(x => x >= 8);

            numbers.Add(18);
            numbers.Add(19);
            numbers.Add(20);
            numbers.Add(21);
            numbers.Add(22);

            foreach (var number in evenNumbers) // every thing before foreach will be concerned
            {
                Console.Write(number + " ");
            }

        }
    }
}
