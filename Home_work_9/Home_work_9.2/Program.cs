/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Random rnd = new Random();
int M = rnd.Next(11);
Console.WriteLine("M = " + M);
int N = rnd.Next(11, 100);
Console.WriteLine("N = " + N);
int count = M;
int summ  = M;
int RecursionFunction(int m)
{
    if (count == N)
    {
        return summ;
    }
    else
    {
        count++;
        summ += count;
        return RecursionFunction(count);
    }
}
Console.WriteLine(RecursionFunction(M));