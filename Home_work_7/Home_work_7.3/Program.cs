/*
Задача 3. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами 
(если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.

Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ]
*/

Random rnd = new Random();                           // генерируем начальные размеры массива
int i = rnd.Next(10, 35);                            // ограничил макс. размерами 35х35 для более удобного восприятия на экране
int j = rnd.Next(10, 35);
int [,] array = new int[i, j];
double[] arithmetic_mean = new double[j];

void GeneratingInArray(int row, int column)                 // генерируем массив
{
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++ )
        {
            array[i, j] = rnd.Next(100, 1000);
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

void ArithmeticMeanInColumn(int row, int column)    //Находим среднее арифметическое палиндромов в столбцах
{
    for (int j = 0; j < column; j++)
    {
        double avarage = 0;
        int count = 0;
        for (int i = 0; i < row; i++) // определяем палиндром. Если остаток от деления числа на 10
        {                             // равен делению числа на 100, н-р: 505 % 10 и 505 / 100, равны,
            if (array[i, j] % 10 == array[i, j] / 100)  // значит, палиндром
            {
                count++;
                avarage += array[i, j];
            }
        }
        if (count == 0)
        {
            arithmetic_mean[j] = 0;
        }
        else
        {
            arithmetic_mean[j] = avarage/count;
        }
    }
}

GeneratingInArray(i, j);
PrintArray(i, j);
ArithmeticMeanInColumn(i, j);

foreach (double item in arithmetic_mean)    // выводим массив среднеарифметических значений
{
    Console.Write(Math.Round(item, 2) + " ");
}