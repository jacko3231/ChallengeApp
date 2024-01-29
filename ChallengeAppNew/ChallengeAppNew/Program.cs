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

Console.WriteLine($"average: {statistics.Average:n2}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"min: {statistics.Min}");




