using FunctionalProgramming02;

namespace Data_Partitioning.Tack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Repository.LoadEmployees();
            
            var q1 = emp.Take(10);
            q1.Print("tack first 10");

            var q2 = emp.TakeWhile(x => x.Email != "Bender.Wanda@example.com");
            q2.Print("214400");

            var q3 = emp.TakeLast(10);
            q3.Print("tack skip");
        }
    }
}
