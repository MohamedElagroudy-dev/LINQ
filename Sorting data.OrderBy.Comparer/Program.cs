using LINQTut05.Shared;

namespace Sorting_data.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> emps = Repository.LoadEmployees();
            //IOrderedEnumerable<Employee> sortedEmps = 
            //    emps.OrderBy(e => e.EmployeeNo);

            IOrderedEnumerable<Employee> sortedEmps =
             emps.OrderBy(e => e, new EmployeeComparer());
            sortedEmps.Print("sorted employees");
            Console.ReadKey();
        }
    }
}
