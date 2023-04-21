using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Manager : Employee, ISolvable, ICookable, IManagable
    {
        public ManagerType ManagerType { get; set; }
        public Manager(string firstName, string lastName, DateOnly hireDate,ManagerType managerType) : base(firstName, lastName, hireDate)
        {
            ManagerType = managerType;
        }

        public void Cooking()
        {
            Console.WriteLine("Manager is cooking.");
        }

        public void ManagingPeople()
        {
            Console.WriteLine("Manager is managing people.");
        }

        public void SolveProblem()
        {
            Console.WriteLine("Manager is solving problem.");
        }

        public override void DoWork()
        {
            Cooking();
            ManagingPeople();
            SolveProblem();
        }
        public override string ToString()
        {
            return String.Concat($"Position:{ManagerType} {nameof(Manager)}, ", $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(HireDate)}: {HireDate}.");
        }
    }
}
