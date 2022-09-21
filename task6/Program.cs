// Необходимо развернуть трёхзначное число наоборот, не используя String
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int a0 = number / 100;
int a1 = number / 10 % 10;
int a2 = number % 10;

//WriteLine($"{a2}{a1}{a0}");

int result = a2 * 100 + a1 * 10 + a0;
WriteLine(result);