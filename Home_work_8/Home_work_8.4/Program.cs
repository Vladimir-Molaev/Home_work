/*
Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
Например,
11 22 78
12 47 96
25 87 88
*/
Random rnd = new Random();
int row = rnd.Next(2, 10);
int column = rnd.Next(2, 10);
int[,] array = new int[row, column];

void GeneratingInArray(ref int[,] array) // Генеррируем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(100);
        }
    }
}

int CheckingUniqueness(int element_of_array, ref int[,] array) // проверка элемента на уникальность
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (element_of_array == array[i, j])
            {
                count++;
            }
        }
    }
    return count;
}


void AgainGeneratingInArray(ref int[,] array) // Генерируем массив c уникальными значениями
{
    int count;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count = CheckingUniqueness(array[i, j], ref array);
            if (count > 1)
            {
                array[i, j] = rnd.Next(100);
                j--;
            }
        }
        
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

GeneratingInArray(ref array);
Console.WriteLine("Вывод первоночально созданного массива: ");
PrintArray(ref array);
AgainGeneratingInArray(ref array);
Console.WriteLine("Вывод массива c уникальными элементами: ");
PrintArray(ref array);