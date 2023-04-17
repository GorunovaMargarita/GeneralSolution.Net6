using Home5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class StudentsDataGenerator
    {
        private static string[] someNames = new string[] { "Иван", "Олег", "Анна", "Денис", "Дарья", "Елена", "Максим", "Алексей", "Фёдор", "Мирон", "Наталья", "Николай", "Александр", "Марина" };
        public static Student[] GenerateStudentsArray(int count, string groupName)
        {
            Random random = new Random();
            Student[] studentsArray = new Student[count];
            for (int i = 0; i < count; i++)
            {
                studentsArray[i] = new Student(System.Guid.NewGuid().ToString(), someNames[random.Next(0, someNames.Length)], random.Next(18, 22), groupName);
            }
            return studentsArray;
        }
        public static void SetRandomMark(Student[] studentsArray)
        {
            Random random = new Random();
            foreach (Student student in studentsArray)
            {
                student.MathMark = random.Next(Constants.minMark, Constants.maxMark);
                student.BiologyMark = random.Next(Constants.minMark, Constants.maxMark);
                student.PhysicalEducationMark = random.Next(Constants.minMark, Constants.maxMark);
            }
        }
    }
}
