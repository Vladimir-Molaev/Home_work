/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/

Console.Write("Введите два числа m и n: ");
string[] s = Console.ReadLine().Split();
int m = int.Parse(s[0]);
int n = int.Parse(s[1]);
double[,] array = new double[m, n];

void GeneratingInArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++ )
        {
            array[i, j] = Math.Round((rnd.Next(1, 100) + rnd.NextDouble()), 2);
        }
    }
}

void PrintArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

GeneratingInArray(m, n);
PrintArray(m, n);