/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет
*/
Console.Write("Введите позицию в двухмерном массиве: ");
string[] s = Console.ReadLine().Split();                    // ввод позиции в массиве
int m = int.Parse(s[0]);
int n = int.Parse(s[1]);

Random rnd = new Random();                                  // генерируем начальные размеры массива
int i = rnd.Next(1, 10);                                    // ограничил величинами 9х9
int j = rnd.Next(1, 10);
int [,] array = new int[i, j];

void GeneratingInArray(int row, int column)                 // генерируем массив
{
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++ )
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
}

void PrintArray(int row, int column)                           // печатаем на экран
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

void CheckingTheElement(int m, int n)                           // проверяем введенную позицию на наличие в массиве
{
    if (m >= i || n >= j)
    {
        Console.WriteLine($"array[{m},{n}] - такой позиции не в массиве");
    }
    else
    {
        Console.WriteLine($"array[{m},{n}] = {array[m, n]}");
    }
}

GeneratingInArray(i, j);
PrintArray(i, j);
CheckingTheElement(m, n);