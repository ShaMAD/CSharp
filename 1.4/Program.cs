/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int[] array = new int[3]; //Make array length 3


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: "); int.TryParse(Console.ReadLine()!, out arr[i]);
    }
}

FillArray(array);

// Easy way
Array.Sort(array);
Console.WriteLine($"Максимум по sort: {array[array.Length - 1]}");

// Find max
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
}

Console.WriteLine($"Максимум по for: {max}");




