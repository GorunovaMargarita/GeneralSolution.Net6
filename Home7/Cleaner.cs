using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Cleaner : Employee, ICleanable
    {
        public Cleaner(string firstName, string lastName, DateOnly hireDate) : base(firstName, lastName, hireDate)
        {
        }

        public void Clean()
        {
            Console.WriteLine("Cleaner is cleaning.");
        }

        public override void DoWork()
        {
            Clean();
        }
        public override string ToString()
        {
            return String.Concat($"Position: {nameof(Cleaner)}, ", $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(HireDate)}: {HireDate}.");
        }
    }
}
