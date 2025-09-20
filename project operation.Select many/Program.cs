
using FunctionalProgramming02;
using System;
using System.Linq;

namespace LINQTut04.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };

            var res = sentences.SelectMany(x => x.Split(' '));
            foreach (var word in res)
                Console.WriteLine(word);
        }

        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees();

            var skills = employees.SelectMany(x => x.Skills).Distinct(); //use to return array//if an opject has many values

            var result01 = (from employee in employees
                            from skill in employee.Skills
                            select skill).Distinct();

            foreach (var skill in result01)
                Console.WriteLine(skill);

        }
    }
}