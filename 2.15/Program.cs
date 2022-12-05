int a = 0;

while (a < 1 || a > 7)
{
    Console.Write("Введите ччисло от 1 до 7: ");
    int.TryParse(Console.ReadLine()!, out a);
}
if (a > 5)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");