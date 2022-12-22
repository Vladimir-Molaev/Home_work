/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите число от 1 до 10: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;

void FuncGenerationAnArray(int n) // генерируем одномерный массив
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 10);
 
    }
}

int GetNumberEvenNumbersInArray() // находим четные элементы
{
    for (int i = 0; i < N; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

void PrintArray()   // здесь мы просто печаем массив, чтобы посмотреть на него
{
    foreach (int item in array)
    {
        Console.WriteLine(item);
    }

}

FuncGenerationAnArray(N);
PrintArray();
Console.WriteLine("Количество четных элементов --> " + GetNumberEvenNumbersInArray());