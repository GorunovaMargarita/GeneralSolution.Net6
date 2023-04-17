using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Dentist : Doctor
    {
        bool Orthodontist {  get; set; }
        public Dentist(string name, int workExperince, bool orthodontist) : base(name, workExperince)
        {
            Orthodontist = orthodontist;
        }
        public override void Treat()
        {
            base.Treat();
            Console.Write("\tTeeth\n");
        }
    }
}
