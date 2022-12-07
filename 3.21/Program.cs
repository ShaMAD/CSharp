/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53 */

int[] coorsA, coorsB;
double way;

int[] GetCoors(string name)
{
    int[] coors = new int[3];
    string names = "xyz";
    bool bParse = false;
    for (int i = 0; i <= 2; i++)
    {
        do
        {
            Console.Write($"Введите координаты точки {name}{names[i]}: ");
            bParse = int.TryParse(Console.ReadLine()!, out coors[i]);
        } while (bParse == false);
    }
    return coors;
}

double GetWay(int[] a, int[] b)
{
    return Math.Round(Math.Sqrt(Math.Pow(b[0] - a[0], 2) +
        Math.Pow(b[1] - a[1], 2) +
        Math.Pow(b[2] - a[2], 2)), 2);
}

coorsA = GetCoors("A");
coorsB = GetCoors("B");

way = GetWay(coorsA, coorsB);

Console.WriteLine($"Расстояние между точками A ({coorsA[0]},{coorsA[1]},{coorsA[2]}) и B ({coorsB[0]},{coorsB[1]},{coorsB[2]}) равно {way} метрам.");