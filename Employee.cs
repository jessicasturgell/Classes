using System;

namespace Classes
{
    public class Employee
    {
        // First name (string)
        // Last name (string)
        // Title (string)
        // Start date (DateTime)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}