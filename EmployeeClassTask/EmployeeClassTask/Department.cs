using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassTask
{
    internal class Department
    {
        Employee[] employees = new Employee[] { };

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }

        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].Name}" + " " +
                                  $"{employees[i].Surname}" + " " +
                                  $"{employees[i].Age}," + " " +
                                  $"{employees[i].DepartmentName}" + " " +
                                  $"{employees[i].Salary}");
            }
        }


        public Employee[] GetAllEmployees()
        {
            return employees;
        }

        public void GetAllEmployeesBySalary(double minSalary, double maxSalary)
        {
            if (employees.Length > 0)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Salary > minSalary && employees[i].Salary < maxSalary)
                    {
                        Console.WriteLine($"{employees[i].Name}" + " " +
                                      $"{employees[i].Surname}" + " " +
                                      $"{employees[i].Age}," + " " +
                                      $"{employees[i].DepartmentName}" + " " +
                                      $"{employees[i].Salary}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Isci yoxdur!");
            }
        }
    }
}
