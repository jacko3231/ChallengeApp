﻿using static System.Formats.Asn1.AsnWriter;

namespace ChallengeAppNew
{
    public class Employee
    {
        private List<float> scores = new List<float>();
        public Employee(string fullName)
        {
            this.Name = fullName;
            
        }
       
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
            else if (char.TryParse(score, out char resultChar))
            {
                this.AddScore(resultChar);
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

        public void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.scores.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.scores.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.scores.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.scores.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.scores.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
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

            switch(statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    statistics.AverageLetter = 'a';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    statistics.AverageLetter = 'b';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    statistics.AverageLetter = 'c';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    statistics.AverageLetter = 'd';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }       
    }
}


