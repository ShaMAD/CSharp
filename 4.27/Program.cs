/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

bool bParse = false;
int num = 0, sum = 0;

do
{
    Console.Write("Введите число: ");
    bParse = int.TryParse(Console.ReadLine()!, out num);
} while (bParse == false);

Console.Write($"Сумма цифр для числа int {num}: ");
int numMath = num;

while (numMath > 0)
{
    sum = sum + numMath % 10;
    numMath = numMath / 10;
}
Console.WriteLine(sum);

sum = 0;
string numstr = num.ToString();
Console.Write($"Сумма цифр для числа srting {num}: ");

for (int i = 0; i <= numstr.Length - 1; i++)
    sum = sum + int.Parse(numstr[i].ToString());
Console.WriteLine(sum);

