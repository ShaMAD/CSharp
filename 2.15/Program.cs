/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

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