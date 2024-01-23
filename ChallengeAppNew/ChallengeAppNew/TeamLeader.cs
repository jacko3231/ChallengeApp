
namespace ChallengeAppNew
{
    public class TeamLeader : IEmployee
    {
        private List<float> scores = new List<float>();
        public TeamLeader(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                throw new Exception("Invalid score data");
            }
        }
        
        public void AddScore(string score)
        {
          switch(score)
            {
                case "6":
                    this.AddScore(100);
                    break;
                case "-6" or "6-":
                    this.AddScore(95);
                    break;
                case "+5" or "5+":
                    this.AddScore(90);
                    break;
                case "5":
                    this.AddScore(85);
                    break;
                case "-5" or "5-":
                    this.AddScore(80);
                    break;
                case "+4" or "4+":
                    this.AddScore(75);
                    break;
                case "4":
                    this.AddScore(70);
                    break;
                case "-4" or "4-":
                    this.AddScore(65);
                    break;
                case "+3" or "3+":
                    this.AddScore(60);
                    break;
                case "3":
                    this.AddScore(55);
                    break;
                case "-3" or "3-":
                    this.AddScore(50);
                    break;
                case "+2" or "2+":
                    this.AddScore(45);
                    break;
                case "2":
                    this.AddScore(35);
                    break;
                case "-2" or "2-":
                    this.AddScore(30);
                    break;
                case "1":
                    this.AddScore(20);
                    break;
                default:
                    throw new Exception("Wrong Letter/Wrong Value");
            }
        }

        public void AddScore(int score)
        {
            float scoreToInt = (int)score;
            this.AddScore(scoreToInt);
        }

        public void AddScore(char score)
        {
           string value = score.ToString();
            this.AddScore(value);
        }

        public void AddScore(double score)
        {
            float scoreToFloat = (float)score;
            this.AddScore(scoreToFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}


