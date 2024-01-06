namespace ChallengeAppNew
{
    public class Employee
    {
        private List<float> scores = new List<float>();
      
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }      
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddScore(float number)
        {
            this.scores.Add(number);
        }
        public Statistics GetStatictics()
        {
            var statictics = new Statistics();
            statictics.Average = 0;
            statictics.Max = float.MinValue;
            statictics.Min = float.MaxValue;

            foreach(var score in this.scores)
            {
                statictics.Max = Math.Max(statictics.Max, score);
                statictics.Min = Math.Min(statictics.Min, score);
                statictics.Average += score;
            }

            statictics.Average /= this.scores.Count;

            return statictics;
        }
    }
}

