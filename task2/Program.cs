using static System.Console;
Clear();
Write("Введите трёхзначное число: ");
int number = int.Parse(ReadLine());
int a0 = number / 100;
int a2 = number % 10;
int result = a0 * 10 + a2;
WriteLine(result);