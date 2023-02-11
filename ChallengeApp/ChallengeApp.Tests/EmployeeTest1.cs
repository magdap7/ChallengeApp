namespace ChallengeApp.Tests
{
    public class Tests
    {
 

        [Test]
        public void Test_EployeeStatistics()
        {

            //arrange
            var employee = new Employee("Mag", "Pej");
            employee.AddGrade(20);
            employee.AddGrade('B');//80
            employee.AddGrade('D');//40
            var statistics = employee.GetStatistics();

            //act
            //dane oczekiwane
            var min1 = 20;
            var max1 = 80;
            var ave1 = 46;
            var let1 = 'C';
            //dane sprawdzane
            var min2 = statistics.Min;
            var max2 = statistics.Max;
            var ave2 = Math.Floor(statistics.Average);
            var let2 = statistics.AverageLetter;
            //assert
            Assert.AreEqual(min1, min2); 
            Assert.AreEqual(max1, max2); 
            Assert.AreEqual(ave1, ave2);
            Assert.AreEqual(let1, let2);

        }
    }
}