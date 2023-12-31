namespace ChallengeAppNew.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CompareAndCheckingStatisticsAreEqualOrNotEqual()
        {
            var employee = new Employee("Jacek", "Zybaczynski");
            employee.AddScore(4);
            employee.AddScore(7);
            employee.AddScore(9);
            employee.AddScore(2);
            employee.AddScore(3);
            employee.AddScore(5);

            var statistics = employee.GetStatictics();

            Assert.AreEqual(5,statistics.Average);
            Assert.AreEqual(9, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
        }
    }
}