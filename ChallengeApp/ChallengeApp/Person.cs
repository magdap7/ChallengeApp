
namespace ChallengeApp
{
    public abstract class Person //: System.Object
    {
        //private const string nick;
        //private readonly char sex;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        protected char Gender;
        protected int Age;
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = 'X';
            this.Age = 0;
        }
    }
}
