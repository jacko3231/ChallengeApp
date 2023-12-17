namespace ChallengeAppNew.Tests
{
    public class Tests
    {
        [Test]
        public void WhenTwoNumbersAreAdded_ShouldReturnSum()
        {
           int number1 = 10;
           int number2 = 15;

           int result = number1 + number2;
           
           Assert.AreEqual(25, result);
        }
        [Test]
        public void WhenEmployeeCollectsFiveSetOfPoints_ShouldReturnSum()
        {
            Employee employee = new Employee("Jacek", "Zybaczyñski", 33);
            employee.AddScore(12);
            employee.AddScore(3);
            employee.AddScore(4);
            employee.AddScore(9);
            employee.AddScore(1);

            int result = employee.Result;
           
            Assert.AreEqual(29, result);
        }
        [Test]
        public void WhenEmployeeCollectsFiveSetOfPoints_ShouldReturnCorrectResult()
        {
            Employee employee = new Employee("Jacek", "Zybaczyñski", 33);
            employee.AddScore(12);
            employee.AddScore(-3);
            employee.AddScore(-4);
            employee.AddScore(1);
            employee.AddScore(-1);

            int result = employee.Result;

            Assert.AreEqual(5, result);
        }
    }
}