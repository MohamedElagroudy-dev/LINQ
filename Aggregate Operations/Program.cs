using Shared;

namespace Aggregate_Operations
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            RunMethod1();
        }

        private static void RunMethod1()
        {
            var names = new[] { "ali", "baha", "mohamed", "fathey" };

            //var outbut = String.Join(", ", names);
            //Console.WriteLine(outbut);

            var commaSeparatedNames = names.Aggregate((a, b) =>
            {
                Console.WriteLine($"a = {a}, b = {b}");
                return $"{a}, {b}";
            });
            Console.WriteLine(commaSeparatedNames);
        }
        private static void RunMethod02()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            //var total = 0;
            //foreach (var n in numbers)
            //    total += n;

            var total = numbers.Aggregate(2, (a, b) => a + b);

            Console.WriteLine($"Total: {total}");
        }
        private static void RunMethod03()
        {
            var quiz = QuestionBank.All;

            var longestQuestionTitle = quiz[0];

            Console.WriteLine($"{longestQuestionTitle}");
            Console.WriteLine("-----");
            longestQuestionTitle =
                quiz.Aggregate(longestQuestionTitle,
                                (longest, next) => longest.Title.Length < next.Title.Length ? next : longest,
                                x => x);
            Console.WriteLine($"{longestQuestionTitle}");
        }
    }
}
