using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var name = input[0];
            var salary = decimal.Parse(input[1]);
            var position = input[2];
            var department = input[3];

            var employee = new Employee(name, salary, position, department);

            if (input.Length == 5)
            {
                var ageOrEmail = input[4];

                if (ageOrEmail.Contains("@"))
                {
                    employee.Email = ageOrEmail;
                }
                else
                {
                    employee.Age = int.Parse(ageOrEmail);
                }                
            }

            if (input.Length == 6)
            {
                employee.Email = input[4];
                employee.Age = int.Parse(input[5]);                
            }

            employees.Add(employee);
        }
        
        var highestDepartment = employees.GroupBy(e => e.Department).OrderByDescending(e => e.Average(x => x.Salary)).Take(1).ToList();

        if (highestDepartment.Any())
        {
            foreach (var department in highestDepartment)
            {
                Console.WriteLine($"Highest Average Salary: {department.Key}");

                foreach (var employee in department.OrderByDescending(e => e.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
                }
            }
        }

               
    }
}

