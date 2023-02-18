

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average { get; private set; }

        public char AverageLetter 
        { 
            get 
            { 
                switch (this.Average)
                { 
                    case var avg when avg >=80:
                        return 'A';
                    case var avg when avg >= 60:
                        return 'B';
                    case var avg when avg >= 40:
                        return 'C';
                    case var avg when avg >= 20:
                        return 'D';
                    case var avg when avg >= 0:
                        return 'E';
                    default:
                        return 'F';
                }
            } 
        }

        private List<float> grades;
        public Statistics(List <float> grades)
        {
            this.grades = grades;
        }
        public void CountStatistics()
        {
            if (this.grades.Count == 0)
            {
                throw new Exception("Empty grades list");
            }
            else
            {//count
                this.Min = this.grades.Min();
                this.Max = this.grades.Max();
                this.Sum = this.grades.Sum();
                this.Count = this.grades.Count();
                this.Average = this.grades.Average();
            }
        }
    }
}
