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
        private int mathMark;
        private int physicalEducationMark;
        private int biologyMark;
        private int reward;
        public int MathMark
        {
            get { return mathMark; }
            set
            {
                if (value < Constants.minMark)
                {
                    mathMark = Constants.minMark;
                }
                else if (value > Constants.maxMark)
                {
                    mathMark = Constants.maxMark;
                }
                else
                {
                    mathMark = value;
                }
            }
        }
        public int PhysicalEducationMark
        {
            get { return physicalEducationMark; }
            set
            {
                if (value < Constants.minMark)
                {
                    physicalEducationMark = Constants.minMark;
                }
                else if (value > Constants.maxMark)
                {
                    physicalEducationMark = Constants.maxMark;
                }
                else
                {
                    physicalEducationMark = value;
                }
            }
        }
        public int BiologyMark
        {
            get { return biologyMark; }
            set
            {
                if (value < Constants.minMark)
                {
                    biologyMark = Constants.minMark;
                }
                else if (value > Constants.maxMark)
                {
                    biologyMark = Constants.maxMark;
                }
                else
                {
                    biologyMark = value;
                }
            }
        }
        public int Reward 
        { 
            get { return  reward; }
            set 
            {
                if (value < Constants.minReward)
                {
                    reward = Constants.minReward;
                }
                else if (value > Constants.maxReward)
                {
                    reward = Constants.maxReward;
                }
                else
                {
                    reward = value;
                }
            }
        }
        public Student(string id, string name, int age, string group)
        {
            Id = id;
            Name = name;
            Age = age;
            Group = group;
        }
    }
}
