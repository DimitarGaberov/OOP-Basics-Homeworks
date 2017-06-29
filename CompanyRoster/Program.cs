using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < lines; i++)
            {
                var employeeInfo = Console.ReadLine().Split(' ').ToArray();
                var name = employeeInfo[0];
                var salary = double.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];
                if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].IndexOf("@") != -1)
                    {
                        var email = employeeInfo[4];
                        employees.Add(new Employee(name, salary, position, department, email));
                    }
                    else
                    {
                        var age = int.Parse(employeeInfo[4]);
                        employees.Add(new Employee(name, salary, position, department, age));
                    }
                }
                else if (employeeInfo.Length == 6)
                {
                    var email = employeeInfo[4];
                    var age = int.Parse(employeeInfo[5]);
                    employees.Add(new Employee(name, salary, position, department, email, age));
                }
                else
                {
                    employees.Add(new Employee(name, salary, position, department));
                }
            }

            Dictionary<string, double> result = new Dictionary<string, double>();

            for (int i = 0; i < employees.Count; i++)
            {
                if (result.ContainsKey(employees[i].department))
                {
                    result[employees[i].department] += employees[i].salary;
                }
                else
                {
                    result.Add(employees[i].department, employees[i].salary);
                }
            }

            var max = result.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine($"Highest Average Salary: {max}");
            foreach (var employee in employees.Where(e => e.department == max).OrderByDescending(e => e.salary))
            {
                Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
            }
        }
    }
}
