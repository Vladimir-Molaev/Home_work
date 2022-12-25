/*
Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.

1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/

int N = new Random().Next(1, 10);
int[] array = new int [N];

void NewArrayGenerator(int N)   // Генерируем массив
{
    //int rnd = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int N)  // Печать массива на экран для ознакомления
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
}

int TheProductOfPairs() // Умножение пар массива
{
    int summ = 0;
    for (int i = 0; i < (array.Length)/2; i++)          // цикл считает до половины длины массива
    {
        summ += array[i]*array[array.Length - 1 - i];   //первый элемент умножаем с последним и складываем с summ
    }                                                   // второй с предпоследним и т.д.
    return summ;
}
NewArrayGenerator(N);
PrintArray(N);
Console.WriteLine($"Сумма произведения пар массива равна " + TheProductOfPairs());