//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";//C:\Users\magda\OneDrive\Dokumenty\oQrs

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
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
                    this.AddGrade(100);
                    break;
                case 'B' or 'b':
                    this.AddGrade(80);
                    break;
                case 'C' or 'c':
                    this.AddGrade(60);
                    break;
                case 'D' or 'd':
                    this.AddGrade(40);
                    break;
                case 'E' or 'e':
                    this.AddGrade(20);
                    break;
                case 'F' or 'f':
                    this.AddGrade(0);
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
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if(this.GradeAdded !=null)
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
            var result=new Statistics();
            var listOfGrades= new List<float>();//pomocnicza lista tymczasowa
            if (File.Exists(fileName)) 
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {//var number = float.Parse(line);
                        if (float.TryParse(line, out float number))
                            if (number >= 0 && number <= 100)
                                listOfGrades.Add(number);
                            else
                                throw new Exception($"Grade {number} from file {fileName} is not valid.");
                        else
                            throw new Exception("Invalid grade in file");
                        line = reader.ReadLine();
                    }
                }
                result.Min = listOfGrades.Min();
                result.Max = listOfGrades.Max();
                result.Average = listOfGrades.Average();
            }
            else
            {
                throw new Exception($"File {fileName} dosn't exist.");
            }
            
            return result;
        }
    }
}
