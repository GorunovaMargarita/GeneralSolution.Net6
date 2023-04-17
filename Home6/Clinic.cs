using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Clinic
    {
        public string Name { get; set; }
        public Therapist[] Therapist { get; set; }
        public Ophthalmologist[] Ophthalmologist { get; set; }
        public Dentist[] Dentist { get; set; }
        public Clinic(string name, Therapist[] therapist, Ophthalmologist[] ophthalmologist, Dentist[] dentist)
        {
            Name = name;
            Therapist = therapist;
            Ophthalmologist = ophthalmologist;
            Dentist = dentist;
        }
        /// <summary>
        /// Choose Doctor for Patient and Treat
        /// </summary>
        /// <param name="patient"></param>
        public void SendPatientToDoctor(Patient patient)
        {
            Console.WriteLine($"\nPatient {patient.Name}: ");
            switch (patient.IlnessType) 
            {
                case Enums.IlnessType.Eyes:
                    Ophthalmologist.First().Treat();
                    break;
                case Enums.IlnessType.Teeth:
                    Dentist.First().Treat();
                    break;
                case Enums.IlnessType.Other:
                    Therapist.First().Treat();
                    break;
            }
        }
    }
}
