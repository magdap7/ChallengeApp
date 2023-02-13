

using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> scores;
        private readonly char sex;
        //private const string logo;

        public String firstName { get; private set; }
        public String lastName { get; private set; }
        public int age { get; private set; }

        //konstruktory
        public Employee()
        {
            this.scores = new List<float>();
        }
        public Employee(String lastName)
        {
            this.lastName = lastName;
            this.scores = new List<float>();
        }
        public Employee(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.scores = new List<float>();
        }
        public Employee(String firstName, String lastName, char sex, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
            this.scores = new List<float>();
        }

        //propercje
        public float getMax { get { return this.scores.Max(); } }
        public float getMin { get { return this.scores.Min(); } }

        //metody
        public void AddGrade(float grade)
        {//po kursowemu, wygodniej do parsowania
            if (grade >= 0 && grade <= 100)//walidacja wartości dodawanych punktów
                this.scores.Add(grade);
            else //rzuć wyjątkiem
                //Console.WriteLine($"{grade}? Wartość oceny ma się zawierać pomiędzy 0 i 100.");
                throw new Exception("Invalid grade value");
        }
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(short grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result1))//walidacja formatu punktów
                this.AddGrade(result1);
            else if (char.TryParse(grade, out char result2))
                this.AddGrade(result2);
            else
                //Console.WriteLine($"{grade}? Oczekiwano liczby lub pojedynczego znaku.");
                throw new Exception("Wrong grade format");
        }
        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A' or 'a':
                    this.scores.Add(100);
                    break;
                case 'B' or 'b':
                    this.scores.Add(80);
                    break;
                case 'C' or 'c':
                    this.scores.Add(60);
                    break;
                case 'D' or 'd':
                    this.scores.Add(40);
                    break;
                case 'E' or 'e':
                    this.scores.Add(20);
                    break;
                case 'F' or 'f':
                    this.scores.Add(0);
                    break;
                default:
                    //Console.WriteLine("Nieprawidłowy format oceny literowej. Ma być od A do F");
                    throw new Exception("Wrong grade letter");
                    //break;
            }
        }
        public void AddGrades(float[] points)
        {//po mojemu - myslalam, że wygodniej do wprowadzania
            for (int i = 0; i < points.Length; i++)
                this.AddGrade(points[i]);
        }
        public void AddGrades(String[] points)
        {//po mojemu - myslalam, że wygodniej do wprowadzania
            for (int i = 0; i < points.Length; i++)
                this.AddGrade(points[i]);
        }

        public float GetSumOfScores()
        {//można propercją
            return this.scores.Sum();
        }
        public float GetAverageScore()
        {//nie można propercją
            return this.scores.Sum()/this.scores.Count;
        }

        //to samo liczone na piechote na kursie
        public Statistics GetStatistics()
        {//with foreach
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            foreach (var score in this.scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;
            switch(statistics.Average)
            {
                case var a when  a > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when  a > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a > 20:
                    statistics.AverageLetter = 'D';
                    break;
                case var a when  a > 0:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }


            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            float score;
            for (int index=0;index<this.scores.Count; index++)
            {
                score = this.scores[index];
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            var index = 0;
            float score;
            while (index < this.scores.Count)//do
            {
                score = this.scores[index];
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
                index++;
            };
            statistics.Average /= this.scores.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            if(this.scores.Count==0)
                return statistics;//puste po new
            var index = 0;
            float score;
            do
            {
                score = this.scores[index];
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
                index++;
            }
            while (index < this.scores.Count);
            statistics.Average /= this.scores.Count;
            return statistics;
        }

    }  
}
