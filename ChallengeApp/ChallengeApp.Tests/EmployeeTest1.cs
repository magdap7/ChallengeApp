namespace ChallengeApp.Tests
{
    public class Tests
    {
 

        [Test]
        public void Test_EployeeStatistics()
        {
            //mam pomys³ na test, który porówna, czy taki sam wynik da liczenie statystyk dla pracownika 
            //metod¹ na piechotê z kursu i gotowymi metodami wbudowanymi z klasy List

            //arrange
            var employee = new Employee("Mag", "Pej");
            employee.addMarks(new float[5] { 1.0f, 3.2f, 4.5f, 3.8f, 7.2f });
            var statistics = employee.getStatistics();

            //act
            //metoda 1
            var min1 = employee.getMin;
            var max1 = employee.getMax;
            var ave1 = employee.getAverageScore();
            //metoda 2
            var min2 = statistics.Min;
            var max2 = statistics.Max;
            var ave2 = statistics.Average;

            //assert
            Assert.AreEqual(min1, min2); 
            Assert.AreEqual(max1, max2); 
            Assert.AreEqual(ave1, ave2); 

        }
    }
}