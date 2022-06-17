using System;
using System.Globalization;
using System.Collections.Generic;

namespace Section6_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a program to read an integer N and then the data(id, name and salary) of
            //N employees.There should be no repetition of id.
            //Then make an increase of X percent in the salary of a particular employee.
            //To do this, the program must read an id and the value X. If the id does not exist, display a message and
            //message and abort the operation. At the end, show the updated list of employees,
            //according to the examples.
            //Remember to apply the encapsulation technique to not allow the salary to be changed freely.
            //be changed freely.A salary can only be increased based on a given
            //given percentage raise operation.

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int employeeQty = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeeQty; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee promoEmp = employees.Find(x => x.Id == searchId);
            if (promoEmp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                promoEmp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employee:");
            foreach (Employee emp in employees)
                Console.WriteLine(emp);

            //another way of resolving - searching for the id twice
            //if (employees.Exists(x => x.Id == searchId))
            //{
            //    Console.Write("Enter the percentage: ");
            //    double raisePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    employees.Find(x => x.Id == searchId).IncreaseSalary(raisePercentage);
            //}
            //else
            //{
            //    Console.WriteLine("This id doesn't exist!");
            //}
        }
    }
}
