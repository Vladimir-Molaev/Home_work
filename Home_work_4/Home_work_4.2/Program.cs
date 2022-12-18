/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
452 -> 6
82 -> 2
9012 -> 3
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int temp_var = number;
int sum_of_divisors = 0;

while(true) // считаем количество разрядов в числе
{
    temp_var /= 10;
    count++;
    if (temp_var == 0)
    {
        break;
    }
    
}

int [] array = new int [count];
temp_var = number;

for (int i = 0; i < count; i++)
{
    if (temp_var > 0)                           // если temp_var больше нуля, значит, в числе еще есть разряды
    {
        array[i] = temp_var % 10;               // записываем каждый разряд числа в массив
        if (array[i] != 0)                      // избегаем деления на ноль
        {
            if (number % array[i] == 0)         // сразу же проверяем, является ли разряд делителем числа number
            {
                sum_of_divisors += array[i];    // Если является, то прибавляем к сумме делителей
            }
        }
        temp_var /= 10;
    }
}

Console.WriteLine($"Сумма делителей числа {number} равна {sum_of_divisors}");