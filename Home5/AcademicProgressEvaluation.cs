using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class AcademicProgressEvaluation
    {
        /// <summary>
        /// Get and display student with best mark on subject from group
        /// </summary>
        /// <param name="students">group of students, array</param>
        /// <param name="subject">Math or Biology or PhysicalEducation</param>
        /// <returns>student with best mark on subject from group</returns>
        public Student GetStudentWithBestMark(Student[] students, string subject)
        {
            Student studentWithBestMark = students[0];
            int bestMark = Constants.maxMark;
            if(String.Equals(subject,"Math",StringComparison.InvariantCultureIgnoreCase))
            {
                for (int i = 1; i < students.Length; i++)
                {
                    if (students[i].MathMark > studentWithBestMark.MathMark)
                    {
                        studentWithBestMark = students[i];
                        bestMark = studentWithBestMark.MathMark;
                    }
                }
            }
            else if (String.Equals(subject, "Biology", StringComparison.InvariantCultureIgnoreCase))
            {
                for (int i = 1; i < students.Length; i++)
                {
                    if (students[i].BiologyMark > studentWithBestMark.BiologyMark)
                    {
                        studentWithBestMark = students[i];
                        bestMark = studentWithBestMark.BiologyMark;
                    }
                }
            }
            else if (String.Equals(subject, "PhysicalEducation", StringComparison.InvariantCultureIgnoreCase))
            {
                for (int i = 1; i < students.Length; i++)
                {
                    if (students[i].PhysicalEducationMark > studentWithBestMark.PhysicalEducationMark)
                    {
                        studentWithBestMark = students[i];
                        bestMark = studentWithBestMark.PhysicalEducationMark;
                    }
                }
            }
            Console.WriteLine($"Student {studentWithBestMark.Name} from {studentWithBestMark.Group} has the best mark on {subject}: {bestMark}");
            return studentWithBestMark;
        }
        /// <summary>
        /// Display average mark students from group on Math
        /// </summary>
        /// <param name="students">group of students, array</param>
        public void DisplayAverageMathMark(Student[] students)
        {
            Console.WriteLine($"{students.First().Group}, average mark math: {CountAveragMathMark(students)}");
        }
        /// <summary>
        /// Display average mark students from group on Biology
        /// </summary>
        /// <param name="students">group of students, array</param>
        public void DisplayAverageBiologyMark(Student[] students)
        {
            Console.WriteLine($"{students.First().Group}, average mark biology: {CountAverageBiologyMark(students)}");
        }
        /// <summary>
        /// Display average mark students from group on PhysicalEducation
        /// </summary>
        /// <param name="students">group of students, array</param>
        public void DisplayAveragePhysicalEducationMark(Student[] students)
        {
            Console.WriteLine($"{students.First().Group}, average mark physicalEducation: {CountAveragePhysicalEducationMark(students)}");
        }
        public void DisplayAverageMarkByGroup(Student[] students)
        {
            Console.WriteLine($"Average mark of {students.First().Group} - Math, PhysicalEducation, Biology - {Math.Round(GetAverageMarkByGroup(students),2)}");
        }
        /// <summary>
        /// Display students from array of groups with max Reward
        /// </summary>
        /// <param name="groupList">array of students group</param>
        public void DisplayStudentsWithMaxReward(List<Student[]> groupList)
        {
            List<Student> unionGroup = new List<Student>();
            foreach(Student[] group in groupList) 
            {
                unionGroup.AddRange(group);
            }

            List<int> reward = new List<int>();
            foreach(Student student in unionGroup)
            {
                reward.Add(student.Reward);
            }

            int maxReward = reward.Max();

            foreach(Student student in unionGroup)
            {
                if(student.Reward == maxReward)
                {
                    Console.WriteLine($"Student {student.Name} from group {student.Group} has a best reward {student.Reward} rub.");
                }
            }
        }
        /// <summary>
        /// Return average mark studentd by Math, Biology and PhysicalEducation
        /// </summary>
        /// <param name="students">group of students, array</param>
        /// <returns>group of students, array</returns>
        public double GetAverageMarkByGroup(Student[] students)
        {
            return (CountAveragMathMark(students) + CountAveragePhysicalEducationMark(students) + CountAveragePhysicalEducationMark(students)) / 3;
        }
        /// <summary>
        /// Get group with best average mark by Math, Biology and PhysicalEducation and Set every student reward
        /// </summary>
        /// <param name="groupList"></param>
        public void SetRewardToStudentsInGroupWithBestAverageMark(List<Student[]> groupList)
        {
            Random random = new Random();

            List<double> averageMarks = new List<double>();
            foreach (Student[] group in groupList)
            {
                averageMarks.Add(GetAverageMarkByGroup(group));
            }

            double maxAverage = averageMarks.Max();

            int reward = new Random().Next(0, Constants.maxReward);

            foreach (Student[] group in groupList)
            {
                if (GetAverageMarkByGroup(group) == maxAverage)
                {
                    foreach (Student student in group)
                    {
                        student.Reward = reward;
                    }
                }
            }
        }
        /// <summary>
        /// Get average mark by PhysicalEducation in student group
        /// </summary>
        /// <param name="students"></param>
        /// <returns>average mark by PhysicalEducation in student group</returns>
        private static double CountAveragePhysicalEducationMark(Student[] students)
        {
            double result = 0;
            foreach (Student student in students)
            {
                result += student.PhysicalEducationMark;
            }
            result /= students.Length;
            return result;
        }
        /// <summary>
        /// Get average mark by Biology in student group
        /// </summary>
        /// <param name="students"></param>
        /// <returns>average mark by Biology in student group</returns>
        private static double CountAverageBiologyMark(Student[] students)
        {
            double result = 0;
            foreach (Student student in students)
            {
                result += student.BiologyMark;
            }
            result /= students.Length;
            return result;
        }
        /// <summary>
        /// Get average mark by Math in student group
        /// </summary>
        /// <param name="students"></param>
        /// <returns>average mark by Math in student group</returns>
        private static double CountAveragMathMark(Student[] students)
        {
            double result = 0;
            foreach (Student student in students)
            {
                result += student.MathMark;
            }
            result /= students.Length;
            return result;
        }
    }
}
