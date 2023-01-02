/*
Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Random rnd = new Random();
int N = rnd.Next(10);
Console.WriteLine("N = " + N);
int RecursionFunction(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        Console.Write(n + ", ");
        return RecursionFunction(n - 1);
    }
}
Console.WriteLine(RecursionFunction(N));