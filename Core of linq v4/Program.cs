using FunctionalProgramming;

namespace Core_of_linq_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var empMale = employees.Where(x => x.Gender == "male");

            var empSalary = from emp in employees
                            where emp.Salary > 300_300
                            select emp;

            var empMaleInHRDepartment = empMale.Where(f => f.Department == "HR");

            

            empMale.Print("male");
            empMaleInHRDepartment.Print("emp Male In HR Department");

        }
    }
}
