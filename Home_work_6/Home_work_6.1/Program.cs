/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3
*/

Console.Write("Введите количество цифр: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите {M} чисел: ");
string[] s = Console.ReadLine().Split();
int count = 0;

for (int i = 0; i <M; i++)
{
    if (int.Parse(s[i]) > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительный введенных чисел --> {count}");