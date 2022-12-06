/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
 */

bool bParse = false;
int num = 0;

do
{
    Console.Write("Введите число: ");
    bParse = int.TryParse(Console.ReadLine()!, out num);
} while (bParse == false);

if (check_polindrom(num.ToString()))
    Console.WriteLine($"Число {num} полиндром");
else
    Console.WriteLine($"Число {num} не полиндром");

bool check_polindrom(string num)
{
    int len = num.Length;

    for (int i = 0; i < len / 2; ++i) if (num[i] != num[len - i - 1]) return false;
    return true;
}