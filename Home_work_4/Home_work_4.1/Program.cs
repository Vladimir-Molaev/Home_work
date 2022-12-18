/*
Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите два положительных числа: ");

string[] s = Console.ReadLine().Split();

int number_a = int.Parse(s[0]); 
int number_b = int.Parse(s[1]);
int result = number_a;

if (number_b < 0) // проверка на отрицательное число
{
    Console.WriteLine("Вы ввели отрицательное число. Введите положительное натуральное число");
} 
else
{
    if (number_b == 0) // Если степень равен нулю, то ответ равен единице
    {
        result = 1;
    }
    else if(number_b == 1) // степень равна единице
    {
        result = number_a;
    }
    else // возведение в степень.
    {
        for (int i = 1; i < number_b; i++)
        {
            result *= number_a;
        }
    }   


Console.WriteLine($"Результатом возведения числа {number_a} в степень {number_b} является число {result}");
}