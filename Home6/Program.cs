using System;


namespace Home6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Therapist therapist = new Therapist("Ivanov F.F.", 2);
            Ophthalmologist ophthalmologist = new Ophthalmologist("Petrov A.A.", 5, true);
            Dentist dentist = new Dentist("Chaschtryan E.R.", 15, false);

            Patient patient1 = new Patient("Nevsky A.N.", Enums.Sex.man, Enums.IlnessType.Teeth);
            Patient patient2 = new Patient("Rodnaya G.A.", Enums.Sex.woman, Enums.IlnessType.Other);
            Patient patient3 = new Patient("Remizov I.A.", Enums.Sex.man, Enums.IlnessType.Eyes);

            Clinic clinic = new Clinic("22Sentury", new Therapist[] { therapist }, new Ophthalmologist[] { ophthalmologist }, new Dentist[] { dentist });

            clinic.SendPatientToDoctor(patient1);
            clinic.SendPatientToDoctor(patient2);
            clinic.SendPatientToDoctor(patient3);
        }
    }
}
