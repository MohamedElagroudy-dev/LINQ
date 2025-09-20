

using FunctionalProgramming02;

namespace Data_Partitioning.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Repository.LoadEmployees();
            emp.Print(" ");
            var q1 = emp.Skip(10);
            q1.Print("Skip first 10");

            var q2 = emp.SkipWhile(x => x.Email != "Bender.Wanda@example.com");
            q2.Print("214400");
            
            var q3 = emp.SkipLast(10);
            q3.Print("last skip");
        }
    }
}
