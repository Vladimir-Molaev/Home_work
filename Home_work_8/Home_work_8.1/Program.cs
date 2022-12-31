/* 
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Random rnd = new Random();
int row = rnd.Next(2, 10);
int column = rnd.Next(2, 10);

int[,] array = new int[row, column];

void Swap(ref int a, ref int b) // Меняем местами два числа
{
    if (a < b)
    {
        int var_temp = b;
        b =  a;
        a = var_temp;
    }

}

void PrintArray(int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GeneratingInArray(int row, int column) // Генеррируем массив
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(100);
        }
    }
}

void SortringAnArray(int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < (column+1)/2; j++)
        {
            for (int k = 0; k < column - 1; k++)
            {
                Swap(ref array[i, k], ref array[i, k + 1]);
            }
        }
    }
}

GeneratingInArray(row, column);
PrintArray(row, column);
Console.WriteLine(String.Join(" ", array));
SortringAnArray(row, column);
Console.WriteLine("Вывод отсортированного массива: ");
PrintArray(row, column);