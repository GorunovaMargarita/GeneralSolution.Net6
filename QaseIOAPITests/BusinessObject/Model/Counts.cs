using System.Text;

namespace QaseIOAPITests.BusinessObject.Model
{
    public class Counts
    {
        public int Cases { get; set; }
        public int Suites { get; set; }
        public int Milestones { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Counts counts &&
                   Cases == counts.Cases &&
                   Suites == counts.Suites &&
                   Milestones == counts.Milestones;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Cases, Suites, Milestones);
        }
    }
}