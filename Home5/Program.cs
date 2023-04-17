using Home6;
using System;
using System.Text.RegularExpressions;


namespace Home5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AcademicProgressEvaluation academicProgressEvaluation = new AcademicProgressEvaluation();

            Random random = new Random();

            //Допустим есть 3 группы (Group1, Group2, Group3). Создайте 3 массива студентов по 5 в каждой группе.
            Student[] Group1 = StudentsDataGenerator.GenerateStudentsArray(5, nameof(Group1));
            Student[] Group2 = StudentsDataGenerator.GenerateStudentsArray(5, nameof(Group2));
            Student[] Group3 = StudentsDataGenerator.GenerateStudentsArray(5, nameof(Group3));

            List<Student> bestStudents = new List<Student>();

            List<Student[]> groupList = new List<Student[]>
            {
                Group1,
                Group2,
                Group3
            };

            //Оценки по дисциплинам задайте с использованием Random
            foreach (Student[] group in groupList)
            {
                StudentsDataGenerator.SetRandomMark(group);
            }

            /*Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике. Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них. (ex: Anton, Math mark: 10)
              Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Физкультуре. Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
              Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Биологии. Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.*/

            foreach (Student[] group in groupList)
            {
                bestStudents.Add(academicProgressEvaluation.GetStudentWithBestMark(group, "Math"));
                bestStudents.Add(academicProgressEvaluation.GetStudentWithBestMark(group, "Biology"));
                bestStudents.Add(academicProgressEvaluation.GetStudentWithBestMark(group, "PhysicalEducation"));
            }

            //Установите каждому из лучших студентов выше - денежное вознаграждение в рублях - reward (rand: 0 - 100) (предусмотрите, чтобы нельзя было установить значение reward < 1 рубля)
            foreach(Student student in bestStudents)
            {
                student.Reward = random.Next(0, Constants.maxReward);
            }

            //Создайте методы подсчета и вывода среднего балла группы студентов по каждой из дисциплин и вывода этой информации в консоль (разные методы) (ex: Group1, avarage mark math: 8.3)
            foreach (Student[] group in groupList)
            {
                academicProgressEvaluation.DisplayAverageMathMark(group);
                academicProgressEvaluation.DisplayAverageBiologyMark(group);
                academicProgressEvaluation.DisplayAveragePhysicalEducationMark(group);
            }

            //Создайте метод расчета среднего балла группы студентов по всем 3 дисциплинам (средняя оценка группы по каждой дисциплине / количество дисциплин) и выведите эту информацию в консоль. 
            //(Average mark of Group1 - Math, PhysicalEducation, Biology - 8.3)
            foreach (Student[] group in groupList)
            {
                academicProgressEvaluation.DisplayAverageMarkByGroup(group);
            }

            //Добавьте каждому студенту из группы с наибольшим средним баллом по всем дисциплинам произвольный reward.
            academicProgressEvaluation.SetRewardToStudentsInGroupWithBestAverageMark(groupList);

            //Выведите на экран студента с наибольшим reward. Если таких студентов несколько - выведите их всех.
            academicProgressEvaluation.DisplayStudentsWithMaxReward(groupList);
        }
    }
}
