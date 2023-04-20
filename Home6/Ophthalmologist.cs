using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Ophthalmologist : Doctor
    {
        bool ChooseGlases {  get; set; }
        public Ophthalmologist(string name, int workExperince, bool chooseGlases) : base(name, workExperince)
        {
            ChooseGlases = chooseGlases;
        }
        public override void Treat()
        {
            base.Treat();
            Console.Write("\tEyes\n");
        }
    }
}
