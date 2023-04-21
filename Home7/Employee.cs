using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly HireDate { get; set; }
        public Employee(string firstName, string lastName, DateOnly hireDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }
        public abstract void DoWork();
        public string EmployeeToString()
        {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(HireDate)}: {HireDate}.";
        }
    }
}
