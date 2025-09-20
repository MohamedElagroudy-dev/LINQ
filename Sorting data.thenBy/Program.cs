using LINQTut05.Shared;
namespace Sorting_data.thenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var sortbyname = employees.OrderBy(x => x.Name).ThenBy(x => x.Salary);
            sortbyname.Print("name then salary");
            var sortbyname2 = employees.OrderBy(x => x.Salary).ThenBy(x => x.Name);
            sortbyname2.Print("salary then name");
        }
    }
}
