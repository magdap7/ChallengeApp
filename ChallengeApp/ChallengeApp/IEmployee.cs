
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get;}
        string Surname { get;}

        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(double grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();

    }
}
