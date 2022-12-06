/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */
Console.Write("Введите число: "); string n = Console.ReadLine()!;

if (check_polindrom(n))
    Console.WriteLine($"{n} полиндром");
else
    Console.WriteLine($"{n} не полиндром");


bool check_polindrom(string num)
{
    int len = num.Length;

    for (int i = 0; i < len / 2; ++i) if (num[i] != num[len - i - 1]) return false;
    return true;
}