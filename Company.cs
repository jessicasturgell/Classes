// Expand on the Company class code by
// Adding an Employees property (Its type should be List<Employee>)
// Setting the value of Employees in the constructor as a new List<Employee> (News Flash: Declaring a property gives it an initial vlaue of null). This will allow you to add newly created employees to the Employees list in the final step below.

using System;

namespace Classes
{
    public class Company
    {
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }


        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
         public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }
    }
}