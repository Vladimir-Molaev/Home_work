/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.

m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/

Console.Write("Введите два числа m и n: ");
string[] s = Console.ReadLine().Split();    // считываем строку, парсим и присваевыем значения 
int m = int.Parse(s[0]);                    // переменным m и n
int n = int.Parse(s[1]);
double[,] array = new double[m, n];

void GeneratingInArray(int m, int n)                        // генерируем массив
{
    Random rnd = new Random();  //
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++ )
        {
            double the_whole_part = rnd.Next(1, 100);       // генерируем целую часть
            double the_fraction_part;                       // <-- переменная для дробной части
            while (true)                                    // цикл нужен для проверки дробной части на ноль
            {                                               // если дробн. часть равна нулю, генерируем заново
                the_fraction_part = rnd.NextDouble();
                if (the_fraction_part > 0)
                {
                    break;
                }            
            }
            array[i, j] = Math.Round((the_whole_part + the_fraction_part), 2);
        }
    }
}

void PrintArray(int m, int n)   // печать массива на экран
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