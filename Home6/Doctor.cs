using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Doctor
    {
        public string Name { get; set; }
        public int WorkExperince { get; set; }

        public Doctor(string name, int workExperince)
        {
            Name = name;
            WorkExperince = workExperince;
        }

        public virtual void Treat()
        {
            Console.Write("Treat");
        }
    }
}
