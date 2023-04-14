using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class Student
    {
        public string Id;
        public string Name;
        public int Age;
        public string Group;
        public int MathMark;
        public int PhysicalEducationMark;
        public int BiologyMark;
        public int Reward;

        private static string[] someNames = new string[] { "Иван", "Олег", "Анна", "Денис", "Дарья", "Елена", "Максим", "Алексей", "Фёдор", "Мирон", "Наталья", "Николай", "Александр", "Марина" };

        public Student(string id, string name, int age, string group)
        {
            Id = id;
            Name = name;
            Age = age;
            Group = group;
        }
        public void SetMathMark(int mark)
        {
            if (mark < Constants.minMark)
            {
                MathMark = Constants.minMark;
            }
            else if (mark > Constants.maxMark)
            {
                MathMark = Constants.maxMark;
            }
            else
            {
                MathMark = mark;
            }
        }
        public void SetPhysicalEducationMark(int mark)
        {
            if (mark < Constants.minMark)
            {
                PhysicalEducationMark = Constants.minMark;
            }
            else if (mark > Constants.maxMark)
            {
                PhysicalEducationMark = Constants.maxMark;
            }
            else
            {
                PhysicalEducationMark = mark;
            }
        }
        public void SetBiologyMark(int mark)
        {
            if (mark < Constants.minMark)
            {
                BiologyMark = Constants.minMark;
            }
            else if (mark > Constants.maxMark)
            {
                BiologyMark = Constants.maxMark;
            }
            else
            {
                BiologyMark = mark;
            }
        }
        public void SetReward(int reward)
        {
            if (reward < Constants.minReward)
            {
                Reward = Constants.minReward;
            }
            else if (reward > Constants.maxReward)
            {
                Reward = Constants.maxReward;
            }
            else
            {
                Reward = reward;
            }
        }
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
                student.SetMathMark(random.Next(Constants.minMark, Constants.maxMark));
                student.SetBiologyMark(random.Next(Constants.minMark, Constants.maxMark));
                student.SetPhysicalEducationMark(random.Next(Constants.minMark, Constants.maxMark));
            }
        }
    }
}
