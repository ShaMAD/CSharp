/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int a = 0;

Console.Write("Введите число: "); int.TryParse(Console.ReadLine()!, out a);
for (int i = 2; i <= a; i = i + 2)
{
    if (i > 2) Console.Write(", ");
    Console.Write(i);
}