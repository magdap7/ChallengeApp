//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> Scores;
        
        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
            this.Scores = new List<float>();
        }

        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(string grade)
        {
            if (int.TryParse(grade, out int resultInt))
                this.AddGrade(resultInt);
            else if (float.TryParse(grade, out float resultFloat))
                this.AddGrade(resultFloat);
            else if (double.TryParse(grade, out double resultDouble))
                this.AddGrade(resultDouble);
            else if (char.TryParse(grade, out char resultChar))
                this.AddGrade(resultChar);
            else
                throw new Exception("Wrong grade format");
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.Scores.Add(100);
                    break;
                case 'B' or 'b':
                    this.Scores.Add(80);
                    break;
                case 'C' or 'c':
                    this.Scores.Add(60);
                    break;
                case 'D' or 'd':
                    this.Scores.Add(40);
                    break;
                case 'E' or 'e':
                    this.Scores.Add(20);
                    break;
                case 'F' or 'f':
                    this.Scores.Add(0);
                    break;
                default:
                    throw new Exception("Wrong grade letter");
                    //break;
            }
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Scores.Add(grade);
                if(this.GradeAdded != null) 
                {
                    this.GradeAdded(this, new EventArgs());
                }
            }
            else
                throw new Exception("Invalid grade value");
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (this.Scores.Count == 0)
            {
                throw new Exception("Empty score list");
                return statistics;
            }
            statistics.Min = this.Scores.Min();
            statistics.Max = this.Scores.Max();
            statistics.Average = this.Scores.Average();
            statistics.AverageLetter = 'X';//niepotrzebne
            return statistics;
        }
        
    }
}
