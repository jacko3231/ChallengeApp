using ChallengeAppNew;

Employee employee = new Employee("Jacek", "Zybaczyński");
employee.AddScore(9);
employee.AddScore(5);
employee.AddScore(1);
var statistics = employee.GetStatictics();

Console.WriteLine($"Min number: {statistics.Min}");
Console.WriteLine($"Max number: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");

