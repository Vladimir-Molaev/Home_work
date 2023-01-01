/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
*/

Random rnd = new Random();
int m = rnd.Next(2, 10);
int[,] array_1 = new int[m, m];
int[,] array_2 = new int[m, m];

int[,] productOfArrays = new int[m, m];

void GeneratingInArray(ref int[,] array) // Генеррируем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
}

void TheProductOfRowByColumn(int row_prod, int column_prod)
{
    for (int i = 0; i < array_1.GetLength(1); i++)
    {
        productOfArrays[row_prod, column_prod] += array_1[row_prod, i] * array_2[i, column_prod];
    }
}

void PrintArray(ref int[,] array) // Выводим массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

GeneratingInArray(ref array_1);
GeneratingInArray(ref array_2);
Console.WriteLine("Вывод первого массива:");
PrintArray(ref array_1);
Console.WriteLine("Вывод второго массива:");
PrintArray(ref array_2);

for (int i = 0; i < array_1.GetLength(1); i++)
{
    for (int j = 0; j < array_1.GetLength(0); j++)
    {
        TheProductOfRowByColumn(i, j);
    }
}

Console.WriteLine("Вывод итогового массива:");
PrintArray(ref productOfArrays);