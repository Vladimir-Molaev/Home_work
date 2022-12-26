/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
Random rnd = new Random();
int m = rnd.Next(1,11);
int n = rnd.Next(1,11);
double[,] array = new double[m, n];

void GeneratingInArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++ )
        {
            array[i, j] = rnd.Next(1, 100);
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

