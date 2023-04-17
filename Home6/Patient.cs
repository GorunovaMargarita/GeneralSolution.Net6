using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Home6.Enums;

namespace Home6
{
    public class Patient
    {
        public string Name { get; set; }
        public Sex Sex { get;set; }
        public IlnessType IlnessType { get; set; }
        
        public Patient(string name, Sex sex, IlnessType ilnessType)
        {
            Name = name;
            Sex = sex;
            IlnessType = ilnessType;
        }
    }
}
