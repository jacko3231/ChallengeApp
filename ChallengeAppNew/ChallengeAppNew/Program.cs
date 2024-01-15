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

var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithFor(); 

Console.WriteLine();
Console.WriteLine("Pętla Foreach:");
Console.WriteLine();
Console.WriteLine($"Min number: {statistics.Min}");
Console.WriteLine($"Max number: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine();
Console.WriteLine("Pętla Do While:");
Console.WriteLine();
Console.WriteLine($"Min number: {statistics2.Min}");
Console.WriteLine($"Max number: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine();
Console.WriteLine("Pętla While:");
Console.WriteLine();
Console.WriteLine($"Min number: {statistics3.Min}");
Console.WriteLine($"Max number: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine();
Console.WriteLine("Pętla For: ");
Console.WriteLine();
Console.WriteLine($"Min number: {statistics4.Min}");
Console.WriteLine($"Max number: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Average:N2}");

