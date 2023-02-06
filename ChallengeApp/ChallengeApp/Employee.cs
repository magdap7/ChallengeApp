

namespace ChallengeApp
{
    class Employee
    {
        //private String firstName, lastName;
        //private int age;
        private List<int> scores;


        public String firstName { get; private set; }
        public String lastName { get; private set; }
        public int age { get; private set; }

        //public int result { get { return this.scores.Sum(); } };

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
        public int getMaxScore()
        {
            return this.scores.Max();
        }
        public int getSumOfScores()
        {
            return this.scores.Sum();
        }


    }
}
