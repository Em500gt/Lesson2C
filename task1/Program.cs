﻿using static System.Console;

Clear();
Write("Введите число: ");
int number = new Random().Next(10, 99 + 1);
WriteLine(number);
int a0 = number % 10;
int a1 = number / 10;
if(a0 > a1)
{
    WriteLine($"Максимальная цифра = {a0}");
}
else
{
    WriteLine($"Максимальная цифра = {a1}");
}