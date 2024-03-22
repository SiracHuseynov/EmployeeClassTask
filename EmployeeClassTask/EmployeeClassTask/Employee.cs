using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassTask
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;
        public Employee(string name, string surname, byte age, string departmentName, double salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.DepartmentName = departmentName;
            this.Salary = salary;
        }
    }
}
