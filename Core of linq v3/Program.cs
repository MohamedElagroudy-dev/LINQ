using System.Linq;
using FunctionalProgramming;
namespace Core_of_linq_v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbersUsingExtensionWhere =
                numbers.Where(x => x % 2 == 0);

            var evenNumbersUsingEnumerableWhereMethod =
                Enumerable.Where(numbers, x => x % 2 == 0);

            var evenNumbersUsingQurySyntax =
                from n in numbers
                where n % 2 == 0
                select n;

            evenNumbersUsingExtensionWhere.Print("Even number");
            evenNumbersUsingEnumerableWhereMethod.Print("Even number");
            evenNumbersUsingQurySyntax.Print("Even number");
        }
    }
}
