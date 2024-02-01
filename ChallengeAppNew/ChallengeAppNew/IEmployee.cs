using static ChallengeAppNew.EmployeeBase;

namespace ChallengeAppNew
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        char Sex { get; }

        void AddScore(float score);

        void AddScore(string score);

        void AddScore(int score);

        void AddScore(char score);

        void AddScore(double score);

        event ScoreAddedDelegate ScoreAdded;

        Statistics GetStatistics();
    }
}
