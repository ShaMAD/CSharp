/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

int numA = 0, numB = 0;

int GetNum(string name)
{
    int result = 0;
    Console.Write($"Введите число {name}: ");
    string input = Console.ReadLine()!;
    try
    {
        result = Int32.Parse(input);
    }
    catch (FormatException)
    {
        Console.WriteLine($"Ошибка ввода, '{input}' не число!");
        System.Environment.Exit(0);
    }
    return result;
}
numA = GetNum("A");
numB = GetNum("B");

Console.WriteLine($"Число {numA} в степени {numB} = {Math.Pow(numA, numB)}");