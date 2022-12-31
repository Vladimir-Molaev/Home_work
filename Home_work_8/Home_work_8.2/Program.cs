/*
Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Random rnd = new Random();
int row = rnd.Next(2, 10);
int column = rnd.Next(2, 10);
int[,] array = new int[row, column];
int [] array_of_summs = new int [row]; // массив суммы элементов строк массива array

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

void PrintArray(int row, int column) // Выводим массив на экран
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

void GetSummInRow(int number_of_row) // получаем сумму элементов в строке массива
{
    int summ = 0;
    for (int j = 0; j < column; j++)
    {
        summ+=array[number_of_row, j];
    }
    array_of_summs[number_of_row] = summ;
}

GeneratingInArray(row, column);
PrintArray(row, column);

for (int j = 0; j < row; j++) // перебираем строки и считаем сумму элементов
{
    GetSummInRow(j);
}

Console.WriteLine(string.Join(" ", array_of_summs)); // Вывод массива на экран

int max = array_of_summs[0];
int count = 0;
for (int i = 1; i < row; i++)
{ 
    if (array_of_summs[i] < max)
    {
        max = array_of_summs[i];
        count = i;
    }
}

Console.WriteLine($"Cтрока с наименьшей суммой элементов --> {count+1}");