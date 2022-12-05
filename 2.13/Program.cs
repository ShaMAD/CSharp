/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int a = 0;
Console.Write("Введите число: "); int.TryParse(Console.ReadLine()!, out a);

while (a > 999) a = a / 10;

if (a < 99)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(a % 10);
