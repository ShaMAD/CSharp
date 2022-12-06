/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

bool bParse = false;
int num = 0;

do
{
    Console.Write("Введите число: ");
    bParse = int.TryParse(Console.ReadLine()!, out num);
} while (bParse == false);

System.Console.Write($"Таблица кубов для числа {num}: ");

for (int i = 1; i <= num; i++)
{
    System.Console.Write(Math.Pow(i, 3));
    if (i != num) System.Console.Write(", ");
}