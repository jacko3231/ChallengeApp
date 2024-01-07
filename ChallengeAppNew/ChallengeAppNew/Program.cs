using ChallengeAppNew;

Employee employee = new Employee("Jacek", "Zybaczyński");
employee.AddScore("1");
employee.AddScore(5);
employee.AddScore(700);
employee.AddScore("Jacek");
employee.AddScore(8);
employee.AddScore(8);
employee.AddScore(54);
employee.AddScore(1);
employee.AddScore("80");
var statistics = employee.GetStatictics();

Console.WriteLine($"Min number: {statistics.Min}");
Console.WriteLine($"Max number: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

