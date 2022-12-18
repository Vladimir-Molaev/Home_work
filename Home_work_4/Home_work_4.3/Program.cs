/*
Задача 3. **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
(каждый эл-т массива – сгенерирован случайно)

[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/

int[] interesting_numbers = new int[10];
int number;
int i = 0;

int FindInterestingNumber(int number)       // Объявляем функцию FindInterestingNumber
{
    int var_temp = number;
    string s = Convert.ToString(number);    // опреляем количество разрядов в числе
    int lenght = s.Length;                  //
    int [] array = new int [lenght];        // и создаем массив для сохранения значений разрядов числа
    int summa = 0;                          // переменные summa и composition для хранения суммы и 
    int composition = 1;                    // произведения разрядов числа
    int result = 0;
    
    for (int i = 0; i < lenght; i++)        // разбиваем число на разряды и записываем в массив
    {
        array[i] = var_temp % 10;
        var_temp /= 10;
    }

    foreach (int item in array)             // складываем и переумножаем разряды между собой
    {
        summa += item;
        composition *= item;
    }
   
    if (composition % summa == 0)           // проверяем условие задачи
    {
        result = number;
    }
    else
    {
        result = 0;
    }
    return result;
}

while (i < 10)                              // в цикле заполняем массив с "интересными" числами
{
    number = new Random().Next(10, 1001);
    FindInterestingNumber(number);
    if (FindInterestingNumber(number) != 0)
    {
        interesting_numbers[i] = FindInterestingNumber(number);
        i++;
    }
}

for (int item = 0; item < 10; item++)       // выводим массив на экран
{
    Console.WriteLine($"array[{item}] = {interesting_numbers[item]}");
}