/* 
Задача 3. Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3.3 7.76 22 2 78.67] -> 76.67
*/


int N = 5; //new Random().Next();
double [] array = new double[N];
double min;
double max;
int count = 0;

void FuncGenerationAnArray(int N) // генерируем одномерный массив вещественных чисел
{
    for (int i = 0; i < N; i++)
    {
        Random rnd = new Random();
        array[i] = Math.Round(rnd.NextDouble()*(100 - 1 ) + 1, 2);
        Console.WriteLine(array[i]);
    }
}

void PrintArray()   // здесь мы просто печаем массив, чтобы посмотреть на него
{
    foreach (double item in array)
    {
        Console.WriteLine(item);
    }

}

double FindMaxValueInElements() // поиск максимального значения в массиве
{
    max = array[0];

    for (int i = 0; i < N; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMinValueInElements() // поиск минимального значения в массиве
{
    min = array[0];

    for (int i = 0; i < N; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

FuncGenerationAnArray(N);
PrintArray();
Console.WriteLine("max - min = " + (FindMaxValueInElements()-FindMinValueInElements()));