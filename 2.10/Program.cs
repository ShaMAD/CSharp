int a = 0;
while (a < 99)
{
    Console.Write("Введите трехзначное число: "); int.TryParse(Console.ReadLine()!, out a);
    if (a < 99) Console.WriteLine("Число не трехзначное!");
}

Console.WriteLine((a / 10) % 10);
