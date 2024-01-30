namespace ChallengeAppNew
{
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);

        public override event ScoreAddedDelegate ScoreAdded;

        private List<float> scores = new List<float>();
        public EmployeeInMemory(string name, string surname, char sex) 
            : base(name, surname, sex)
        {
          
        }  

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
               
                if(ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid score data");
            }
        }

        public override void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(score, out char resultChar))
            {
                this.AddScore(resultChar);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddScore(int score)
        {
            float scoreToInt = (int)score;
            this.AddScore(scoreToInt);
        }

        public override void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.AddScore(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddScore(double score)
        {
            float scoreToFloat = (float)score;
            this.AddScore(scoreToFloat);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();   
            
            foreach (var score in this.scores) 
            { 
              statistics.AddScore(score);
            }

            return statistics;
        }
    }
}

