using FunctionalProgramming;
using System.Linq;
namespace Cotr_of_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();


            var FemaleWithFnameStartWithS = employees.Filter
                (e => e.FirstName.ToLowerInvariant().StartsWith("s") && e.Gender == "female");
            FemaleWithFnameStartWithS.Print("start with s");

            var FemaleWithFnameStartWithS2 = employees.Where
                (e => e.FirstName.ToLowerInvariant().StartsWith("s") && e.Gender == "female");
            FemaleWithFnameStartWithS2.Print("start with s");
            Console.WriteLine("Hello, World!");
        }
    }
}
