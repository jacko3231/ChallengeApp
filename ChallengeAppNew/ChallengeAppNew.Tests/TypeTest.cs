namespace ChallengeAppNew.Tests
{
    internal class TypeTest
    {
        [Test]
        public void TEST()
        {
          
            var employee1 = GetEmployee("Jacek");
            var employee2 = GetEmployee("Jacek");         
            
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        
        [Test]
        public void TEST2()
        {
            int number1 = 10;
            int number2 = 15;

           Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TEST3()
        {
            float number1 = 9837473f;
            float number2 = 8748473f;

            Assert.AreNotEqual(number1, number2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
