using FunctionalProgramming02;
using System.Linq;

namespace project_operation.Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            //RunExample02();
            RunExample03();

        }
        static void RunExample01()
        {
            List<string> list = new() { "i", "love", "asp.net", "core" };
            var result = list.Select(x => x.ToUpper());

            foreach (var item in result)
                Console.WriteLine(item);
        }
        static void RunExample02()
        {
            List<int> list = new() { 1, 2, 3, 4, 5, 6, 7 };

            var res1 = list.Select(x => x * x);
            var res2 = from x in list
                       select x * x;

            foreach (var item in res1)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in res2)
                Console.Write(item + " ");
        }
        static void RunExample03()
        {
            var employees = Repository.LoadEmployees();

            var res = employees.Select(x =>
            {
                return new EmployeeDto
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    TotalSkills = x.Skills.Count()
                };
            });
            foreach (var n in res)
                Console.WriteLine(n);
        }
    }
}
