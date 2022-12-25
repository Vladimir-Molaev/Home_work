/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


// y = 5 * x + 2    y = 5 * -0.5 + 2 = -0.5 
//     k2      b2   k1      b1  k2      b2        k1 - k2 = b2-b1  
// y = 9 * x + 4    5 * x + 2 = 9 * x + 4         5*x-9*x = 4 - 2       -4 * x = 2      x = 2/-4=-0.5
 
Console.Write("Введите значения b1, k1, b2, k2: ");
string[] s = Console.ReadLine().Split();            // Парсим введенную строку со значениями
int b1 = int.Parse(s[0]);                           //
int k1 = int.Parse(s[1]);                           //
int b2 = int.Parse(s[2]);                           //
int k2 = int.Parse(s[3]);                           //

double k = (k1 - k2);
Console.WriteLine("k = " + k);
double b = b2 - b1;
Console.WriteLine("b = " + b);
double x = Convert.ToDouble(b/k);
double y = k1*x + b1;

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);

