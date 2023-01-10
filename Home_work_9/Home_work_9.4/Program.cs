﻿/* Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int size_of_array_1 = rnd.Next(4, 10);
        int size_of_array_2 = rnd.Next(4, 10);
        Console.WriteLine($"Создаем квадратный массив размером {size_of_array_1}x{size_of_array_2}");
        int[,] array = new int[size_of_array_1, size_of_array_2];
        int i = 0, j = 0, count = 1, row = 1;

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    Console.Write(array[i, j].ToString("D3") + " "); 
                }
                Console.WriteLine();
            }
        }
        array[i, j] = count;
        count++;

        void StepForward(int y, int x)
        {
            array[i, j] = count;
            count++;
        }


        while (count < array.GetLength(0) * array.GetLength(1)+1) // первое условие
        {
            
            if (j+1 < array.GetLength(1) && array[i, j+1] == 0 && i < row)
            {
                j++;                
                StepForward(i, j);            
                continue;
            }

            if (i+1 < array.GetLength(0) && array[i+1, j] == 0)
            {
                i++;            
                StepForward(i, j);
                continue;
            }

            if (j-1 >= 0 && array[i, j-1] == 0)
            {
                j--;
                StepForward(i, j-1);
                continue;
            }

            if (i-1 > 0 && array[i-1, j] == 0 )
            {
                i--;                
                StepForward(i-1, j);
                if (array[i-1, j] !=0 )
                {
                    row++; // эта строка необходима для того, чтобы первое условие не выполнялось раньше времени
                }
                continue;
            }
        }
        PrintArray(array);
    }
}