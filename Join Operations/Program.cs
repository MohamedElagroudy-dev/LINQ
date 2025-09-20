using LINQTut09.Shared;
using System.Runtime.Intrinsics.Arm;

namespace Join_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunJoin();
            //RunQueryJoin();
            //RunGroupJoinQuerySyntax();
            RunGroupJoin();

        }

        private static void RunQueryJoin()
        {
            var employees = Repo.LoadEmployees();
            var departments = Repo.LoadDepartment();

            var res = from emp in employees
                      join dept in departments
                      on emp.DepartmentId equals dept.Id
                      select new EmployeeDto { FullName = emp.FullName, Department = dept.Name };

            foreach (var item in res)
                Console.WriteLine($"{item.FullName} [{item.Department}]");
        }

        private static void RunJoin()
        {
            var employees = Repo.LoadEmployees();
            var departments = Repo.LoadDepartment();

            var res = employees.Join(departments,
                emp => emp.DepartmentId,
                dep => dep.Id,
                (emp, dep) => new EmployeeDto { FullName = emp.FullName, Department = dep.Name }
                );

            foreach (var item in res)
                Console.WriteLine($"{item.FullName} [{item.Department}]");
        }

        private static void RunGroupJoin()
        {
            var employees = Repo.LoadEmployees();
            var departments = Repo.LoadDepartment();
            var empGroups = from dept in departments
                            join emp in employees
                            on dept.Id equals emp.DepartmentId into empGroup
                            select empGroup;


            foreach (var group in empGroups)
            {
                Console.WriteLine("--------------------------------");
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.FullName}");
                }
            }
        }
        private static void RunGroupJoinQuerySyntax()
        {
            var employees = Repo.LoadEmployees();
            var departments = Repo.LoadDepartment();
            var query = departments.GroupJoin
                (employees,
                  dept => dept.Id,
                  emp => emp.DepartmentId,
                  (dept, emps) => new
                  {
                      Department = dept.Name,
                      Employees = emps
                  });

            foreach (var group in query)
            {
                Console.WriteLine();
                Console.WriteLine($"********************** {group.Department} ***********************");
                Console.WriteLine();
                foreach (var item in group.Employees)
                {
                    Console.WriteLine($"{item.FullName}");
                }
            }
        }
    }
}
