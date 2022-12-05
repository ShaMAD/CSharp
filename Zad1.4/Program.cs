//int a, b, c;
int[] array = new int[3]; //Make array length 3
int max = 0;

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: "); int.TryParse(Console.ReadLine()!, out arr[i]);
    }
}

FillArray(array);

// Find max
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
}

Console.WriteLine($"Максимум по for: {max}");

// Easy way
Array.Sort(array);
Console.WriteLine($"Максимум по sort: {array[array.Length - 1]}");


