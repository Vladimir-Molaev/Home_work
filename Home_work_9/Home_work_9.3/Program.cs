/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?)
*/
Console.Write("Функция Аккермана, введите m и n: ");
string[] s = Console.ReadLine().Split();
int m = int.Parse(s[0]);
int n = int.Parse(s[1]);

double AckermanFunction (double m, double n)
{
    if (m == 0)
    {
        return n+1;
    }

    else if (m > 0 && n == 0) 
    {
        return (AckermanFunction(m-1, 1));
    }
    else
    {
        return (AckermanFunction(m-1, AckermanFunction(m, n-1)));
    }
}
Console.WriteLine($"A({m}, {n}) = " + AckermanFunction(m, n));