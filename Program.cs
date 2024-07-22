using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Big Bird Box Store", new DateTime(1999, 2, 10));

            // Create three employees
            Employee employee1 = new Employee("Eunice", "Quitzon", "Manager", new DateTime(2022, 5, 10));
            Employee employee2 = new Employee("Leonel", "Pollich", "Cashier", new DateTime(2021, 3, 15));
            Employee employee3 = new Employee("Dena", "Gibson", "Janitor", new DateTime(2023, 1, 20));

            // Assign the employees to the company
            myCompany.Employees.Add(employee1);
            myCompany.Employees.Add(employee2);
            myCompany.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Console.WriteLine($"{myCompany.Name} Staff List \n");
            foreach (Employee employee in myCompany.Employees)
            {
                Console.WriteLine($"     Name: {employee.FirstName} {employee.LastName}");
                Console.WriteLine($"     Job Title: {employee.Title}");
                Console.WriteLine($"     Start Date: {employee.StartDate.ToShortDateString()} \n");
            }
        }
    }
}