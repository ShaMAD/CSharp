int a = 0;

Console.Write("Введмте число: "); int.TryParse(Console.ReadLine()!, out a);
for (int i = 2; i <= a; i = i + 2)
{
    if (i > 2) Console.Write(", ");
    Console.Write(i);
}