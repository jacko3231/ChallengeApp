using System.Diagnostics;

namespace ChallengeAppNew
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private const string fileName = "scores.txt";
        public EmployeeInFile(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }

        public override void AddScore(float score)
        {
            using (var writer = File.AppendText(fileName))

                if (score >= 0 && score <= 100)
                {
                    writer.WriteLine(score);
                    if (ScoreAdded != null)
                    {
                        ScoreAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invalid score data: Please put number from 0 to 100!!!");
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

        private List<float> ReadScoresFromFileToList(string file)
        {
            List<float> result = new List<float>();
            if (File.Exists(file))
            {
                using (var reader = File.OpenText(file))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float value))
                        {
                            result.Add(value);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("There is no File!");
            }
            return result;
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            List <float> scores = ReadScoresFromFileToList(fileName);


            foreach (var score in scores)
            {
                statistics.AddScore(score);
            }

            return statistics;
        }
    }
}
