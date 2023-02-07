

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores;

        public String firstName { get; private set; }
        public String lastName { get; private set; }
        public int age { get; private set; }

        //public int result { get { return this.scores.Sum(); } };

        public Employee(String lastName)
        {
            this.lastName = lastName;
        }
        public Employee(String firstName, String lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.scores = new List<int>();
        }
        public void addMarks(int[] points)
        {
            for(int i=0;i<points.Length;i++)
                this.scores.Add(points[i]);
        }

        public int getSumOfScores()
        {
            return this.scores.Sum();
        }

    }
}
