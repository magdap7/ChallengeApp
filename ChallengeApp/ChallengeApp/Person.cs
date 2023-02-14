
namespace ChallengeApp
{
    public abstract class Person //: System.Object
    {
        //private const string nick;
        //private readonly char sex;
        public String Name { get; private set; }
        public String Surname { get; private set; }
        protected char Gender;
        protected int Age;
        public Person(String name, String surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = 'X';
            this.Age = 0;
        }
    }
}
