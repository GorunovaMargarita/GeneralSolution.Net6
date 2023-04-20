using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Therapist : Doctor
    {
        public Therapist(string name, int workExperince) : base(name, workExperince)
        {
        }
        public override void Treat()
        {
            base.Treat();
            Console.Write("\tCommon\n");
        }
    }
}
