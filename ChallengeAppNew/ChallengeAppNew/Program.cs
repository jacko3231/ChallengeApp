using ChallengeAppNew;

Console.WriteLine("Witamy w programie XYZ");
Console.WriteLine("=======================\n");
Console.WriteLine("Podaj imię i nazwisko pracownika:");
Console.WriteLine("-------------------------");
string fullName =Console.ReadLine();
Console.WriteLine("-------------------------");

Employee employee = new Employee(fullName);

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
        employee.AddScore(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception Catched: {exception.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Employee: {fullName}\n-------------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");