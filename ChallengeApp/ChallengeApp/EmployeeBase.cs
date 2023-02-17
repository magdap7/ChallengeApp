﻿
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name {get; private set;}
        public string Surname { get; private set; }

        public EmployeeBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract void AddGrade(string grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();

        public virtual Statistics GetStatistics1()
        {
            return GetStatistics();
        }
    }
}
