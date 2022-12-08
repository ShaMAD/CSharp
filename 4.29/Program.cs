/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

int[] arr = new int[8];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 51);
    }

}

FillArray();

foreach (var item in arr)
{
    System.Console.Write($"{item} ");
}