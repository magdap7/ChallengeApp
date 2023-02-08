

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> scores;

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
        public Employee(String firstName, String lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.scores = new List<float>();
        }

        //propercje
        public float getMax { get { return this.scores.Max(); } }
        public float getMin { get { return this.scores.Min(); } }

        //metody
        public void addMarks(float[] points)
        {
            for(int i=0;i<points.Length;i++)
                this.scores.Add(points[i]);
        }
        public float getSumOfScores()
        {//można propercją
            return this.scores.Sum();
        }
        public float getAverageScore()
        {//można propercją
            return this.scores.Sum()/this.scores.Count;
        }

        //to samo liczone na piechote na kursie
        public Statistics getStatistics()
        {
            var statistics = new Statistics();
            //statystyki
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach(var score in this.scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;
            return statistics;
        }


    }
}
