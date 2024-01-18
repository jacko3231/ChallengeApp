namespace ChallengeAppNew.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckingIfStatisticsLettersforEmployeeAreEqualWithNumbers()
        {
            Employee employee = new Employee("Jacek Zybaczynski");
            employee.AddScore('a');
            employee.AddScore('A');
            employee.AddScore('B');
            employee.AddScore('B');
            employee.AddScore('c');
            employee.AddScore('C');
            employee.AddScore('d');
            employee.AddScore('D');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(70.00, statistics.Average);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(40, statistics.Min);
        }

        [Test]
        public void CheckingAverageOfStatisticsByAverageLetter()
        {
            Employee employee = new Employee("Jacek Zybaczynski");
            employee.AddScore(100);
            employee.AddScore(40);
            employee.AddScore(80);
            employee.AddScore(60);
            employee.AddScore(70);
            employee.AddScore(99);
            employee.AddScore(71);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);           
        }
    }
}