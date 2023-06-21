using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.BusinessObject.Model
{
    public class AllProjectResponse
    {
        public int Total { get; set; }
        public int Filtered { get; set; }
        public int Count { get; set; }
        public ICollection<Project> Entities { get; set; }
    }
}
