using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.BusinessObject.Model
{
    public class Project
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public Counts Counts { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Project project &&
                   Title == project.Title &&
                   Code == project.Code &&
                   Counts.Equals(project.Counts);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Code, Counts);
        }
    }
}
