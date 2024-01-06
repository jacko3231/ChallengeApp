namespace ChallengeAppNew.Tests
{
    internal class TypeTest
    {
        [Test]
        public void CheckingThatTwoEmployeesAreEqualOrNot()
        {
          
            Employee employee1 = GetEmployee("Jacek","Zybaczynski");
            Employee employee2 = GetEmployee("Jacek","Zbaczynski");         
            
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreNotEqual(employee1.Surname, employee2.Surname);
        }
        [Test]
        public void CheckingThatTwoEmployeesAreEqual()
        {

            Employee employee1 = GetEmployee("Jacek", "Zybaczynski");
            Employee employee2 = GetEmployee("Jacek", "Zybaczynski");

            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void CheckingThatTwoNumbersAreEqual()
        {
            int number1 = 10;
            int number2 = 15;

           Assert.AreNotEqual(number1, number2);
        }
        
        [Test]
        public void CheckingThatTwoNumbersAreEqualOrNot()
        {
            float number1 = 9837473f;
            float number2 = 8748473f;

            Assert.AreNotEqual(number1, number2);
        }     
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}

