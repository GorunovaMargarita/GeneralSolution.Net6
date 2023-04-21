using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Cook : Employee, ICookable, ICleanable
    {
        public CookType CookType { get; set; }
        public Cook(string firstName, string lastName, DateOnly hireDate, CookType cookType) : base(firstName, lastName, hireDate)
        {
            CookType = cookType;
        }

        public void Clean()
        {
            Console.WriteLine("Cook is cleaning.");
        }

        public void Cooking()
        {
            Console.WriteLine("Cook is cooking.");
        }

        public override void DoWork()
        {
            Cooking();
            Clean();
        }
        public override string ToString()
        {
            return String.Concat($"Position:{CookType}, ", $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(HireDate)}: {HireDate}.");
        }
    }
}
