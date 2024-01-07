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
        public void AddScore(float score)
        {
            if(score >= 0 && score <= 100)
            {
              this.scores.Add(score);
            }
            else
            {
                Console.WriteLine("Invalid score data");
            }       
        }
        public void AddScore(string score)
        {
            if(float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void Addscore(int score)
        {
            float scoreToInt = (int)score;
            this.AddScore(scoreToInt);
        }   
        public void Addscore(double score)
        {
            float scoreToFloat = (float)score;
            this.AddScore(scoreToFloat);
        }
        public void Addscore(long score)
        {
            float scoreToLong = (long)score;
            this.AddScore(scoreToLong);
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

