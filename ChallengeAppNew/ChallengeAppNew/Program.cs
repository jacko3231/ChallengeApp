using ChallengeAppNew;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników: ");
Console.WriteLine("=======================\n");

var employee = new EmployeeInMemory("Jacek", "Zybaczynski", 'M');
employee.ScoreAdded += EmployeeScoreAdded;

void EmployeeScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę: ");
}

while (true)
{
    Console.WriteLine("podaj liczbę: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "q")
    {
        break;
    }
    try
    {
        employee.AddScore(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"exception catched: {exception.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:n2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");




