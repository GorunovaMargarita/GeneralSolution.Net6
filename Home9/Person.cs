using Home9;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class Person
    {
        public string Name { get; set; }
        private int age;
        private int salary;
        public int Age 
        {
            get { return age; }
            set 
            { 
                if(value < 18)
                {
                    throw new AgeException("Person is yanger than 18.");
                }
                else
                {
                    age = value;
                }
            } 
        }
        public int Salary 
        { 
            get { return salary; }
            set
            {
                if (value < 100)
                {
                    throw new SalaryException("Salary is smaller than 100.");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Person(string name, int age, int salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, salary: {Salary}";
        }
    }
}
