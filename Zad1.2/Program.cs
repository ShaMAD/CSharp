int a,b;

Console.Write ("Введите число 1: "); int.TryParse(Console.ReadLine()!, out a);
Console.Write ("Введите число 2: "); int.TryParse(Console.ReadLine()!, out b);

if (a < b) a = b;

Console.WriteLine($"max {a}");