using static System.Formats.Asn1.AsnWriter;

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
            if (score >= 0 && score <= 100)
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
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddScore(int score)
        {
            float scoreToInt = (int)score;
            this.AddScore(scoreToInt);
        }

        public void AddScore(double score)
        {
            float scoreToFloat = (float)score;
            this.AddScore(scoreToFloat);
        }

        public void AddScore(long score)
        {
            float scoreToLong = (long)score;
            this.AddScore(scoreToLong);
        }
        //Pętla Foreach
        public Statistics GetStatistics()
        {
            var statictics = new Statistics();
            statictics.Average = 0;
            statictics.Max = float.MinValue;
            statictics.Min = float.MaxValue;

            foreach (var score in this.scores)
            {
                statictics.Max = Math.Max(statictics.Max, score);
                statictics.Min = Math.Min(statictics.Min, score);
                statictics.Average += score;
            }
            statictics.Average /= this.scores.Count;

            return statictics;
        }

        //Pętla For
        public Statistics GetStatisticsWithFor()
        {
            var statictics = new Statistics();
            statictics.Average = 0;
            statictics.Max = float.MinValue;
            statictics.Min = float.MaxValue;
            var index = 0;
            index = scores.Count;
            index++;

            for (index = 0; index < scores.Count; index++)
            {
                statictics.Max = Math.Max(statictics.Max, this.scores[index]);
                statictics.Min = Math.Min(statictics.Min, this.scores[index]);
                statictics.Average += this.scores[index];
                index++;
            }

            statictics.Average /= this.scores.Count;

            return statictics;
        }

        //Pętla Do While
        public Statistics GetStatisticsWithDoWhile()
        {
            var statictics = new Statistics();
            statictics.Average = 0;
            statictics.Max = float.MinValue;
            statictics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statictics.Max = Math.Max(statictics.Max, this.scores[index]);
                statictics.Min = Math.Min(statictics.Min, this.scores[index]);
                statictics.Average += this.scores[index];
                index++;

            } while (index < this.scores.Count);
                        
            statictics.Average /= this.scores.Count;

            return statictics;
        }

        //Pętla While
        public Statistics GetStatisticsWithWhile()
        {
            var statictics = new Statistics();
            statictics.Average = 0;
            statictics.Max = float.MinValue;
            statictics.Min = float.MaxValue;
            var index = 0;

            while(index < this.scores.Count)
            {
                statictics.Max = Math.Max(statictics.Max, this.scores.Count);
                statictics.Min = Math.Min(statictics.Min, this.scores.Count);
                statictics.Average += this.scores.Count;
                index++;
            }
   
            statictics.Average /= this.scores.Count;

            return statictics;
        }
    }
}

