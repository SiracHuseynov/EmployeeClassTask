using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            Department department = new Department();
            do
            {
                string minSalary;
                string maxSalary;

                double minSalaryResult;
                double maxSalaryResult;

                string strAge;
                byte resultAge;

                string strSalary;
                double resultSalary;
                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Bütün iscilere bax");
                Console.WriteLine("3.Maas aralıgına gore iscileri axtaris et");
                Console.WriteLine("0.Proqramı bitir");


                Console.Write("Secim edin: ");
                answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.WriteLine("Isci adini daxil edin: ");

                    string name = Console.ReadLine();

                    Console.WriteLine("Isci soyadini daxil edin: ");
                    string surname = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Iscinin yasini daxil edin: ");
                        strAge = Console.ReadLine();
                    }
                    while (!byte.TryParse(strAge, out resultAge));

                    Console.WriteLine("Iscinin department adini daxil edin: ");
                    string departmentName = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Iscinin maasini daxil edin: ");
                        strSalary = Console.ReadLine();
                    }
                    while (!double.TryParse(strSalary, out resultSalary));

                    Employee employee = new Employee(name, surname, resultAge, departmentName, resultSalary);
                    department.AddEmployee(employee);

                }
                else if (answer == "2")
                {
                    if (department.GetAllEmployees().Length == 0)
                    {
                        Console.WriteLine("Isci yoxdur!");
                    }
                    else
                    {
                        department.ShowEmployeeInfo();
                    }
                }
                else if (answer == "3")
                {
                    do
                    {
                        Console.WriteLine("Minimum Salary daxil edin: ");
                        minSalary = Console.ReadLine();
                    }
                    while (!double.TryParse(minSalary, out minSalaryResult));

                    do
                    {
                        Console.WriteLine("Maximum Salary daxil edin: ");
                        maxSalary = Console.ReadLine();
                    }
                    while (!double.TryParse(maxSalary, out maxSalaryResult));

                    department.GetAllEmployeesBySalary(minSalaryResult, maxSalaryResult);
                }


            }
            while (answer != "0");
        }
    }
}
