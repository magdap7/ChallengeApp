namespace ChallengeApp.Tests
{
    public class Tests
    {
 

        [Test]
        public void Test1_SumOfPoints()
        {

            //arrange
            var emp = new Employee("Mag", "Pej", 47);
            emp.addMarks(new int[2] { 3,7 });//excepted 10
            emp.addMarks(new int[3] { 1, 6,-4 }); //result 3 instead of 11

            //act
            var res = emp.getSumOfScores();

            //assert
            //Assert.AreEqual(21, res); 
            Assert.AreEqual(13, res); 
        }
    }
}