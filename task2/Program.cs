﻿// Напишите программу, которая на вход принимае целое число N,
// а на выходе показывает все целые числа в промежутке от -N до N.
// Пример
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;
if (num > 0)
{
    while (count <= num)
    {
        Console.Write(count + " ");
        count++; // count = count + 1; // count += 1;
    }
}
else
{
  Console.Write("Ошибка ввода!");  
}