using ChallengeAppNew;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników: ");
Console.WriteLine("=======================\n");

TeamLeader teamLeader = new TeamLeader("Marek", "Kowalski", 'M');

while (true)
{
    Console.WriteLine("Podaj liczbę: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        teamLeader.AddScore(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception Catched: {exception.Message}");
    }
}
var statistics = teamLeader.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");






