/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите число от 1 до 10: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int summ = 0;

void FuncGenerationAnArray(int N) // генерируем одномерный массив
{
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 11);
 
    }
}

int GetSumOfOddElements() // находим нечетные элементы и складываем их значения
{
    for (int i = 0; i < N; i++)
    {
        if (i % 2 != 0)
        {
            summ+=array[i];
        }
    }

    return summ;
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

Console.WriteLine("Сумма нечетных элементов массива равна " + GetSumOfOddElements());
