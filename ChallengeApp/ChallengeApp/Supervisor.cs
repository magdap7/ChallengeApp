
namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> scores;// => new List<float>();
        public string Name => "Magda";
        public string Surname => throw new NotImplementedException();

        public Supervisor()
        {
            this.scores = new List<float>();
        }
        public void AddGrade(string grade)
        {
            //szuka ocen szkolnych, 2,-4, 5+, etc.
            int totalGrade = 0;
            char signL = grade.Last();
            char signF = grade.First();

            if (signF == '+' || signL == '+')
                totalGrade = totalGrade + 5;
            if (signF == '-' || signL == '-')
                totalGrade = totalGrade - 5;
            if (signL == '-' || signL == '+')
                grade = grade.Substring(0, grade.Length - 1);//obcinamy znak z tyłu, bo potrzebna liczba
            if (int.TryParse(grade, out int result))
            {
                result = Math.Abs(result);//minus już uwzględniony
                if (result > 0 && result < 7)
                    this.scores.Add(totalGrade + (result - 1) * 20);
                else
                    throw new Exception("Invalid school grade format");
            }
            else
            {
                if (char.TryParse(grade, out char result1))
                    this.AddGrade(result1);
                else if (float.TryParse(grade, out float result2))
                    this.AddGrade(result2);
                else
                    throw new Exception("Invalid grade");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
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
                    throw new Exception("Wrong grade letter");
                    //break;
            }
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)//walidacja wartości dodawanych punktów
                this.scores.Add(grade);
            else
                throw new Exception("Invalid grade value");
        }
        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }
        public Statistics GetStatistics()
        {
            //throw new NotImplementedException();
            var statistics = new Statistics();
            if(this.scores.Count == 0)
            {
                throw new Exception("Empty score list");
                return statistics;
            }
            statistics.Min = this.scores.Min();
            statistics.Max = this.scores.Max();
            statistics.Average = this.scores.Average();

            switch (statistics.Average)
            {
                case var a when a > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a > 20:
                    statistics.AverageLetter = 'D';
                    break;
                case var a when a > 0:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }
            return statistics;
        }
    }
}
