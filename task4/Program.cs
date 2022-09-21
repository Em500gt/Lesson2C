using static System.Console;
Clear();

//Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно
// 7 и 23.
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int result1 = number % 7;
int result2 = number % 23;
if (result1 == 0 && result2 == 0)
{
    WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    WriteLine($"Число {number} не кратно.\nПри 7: {result1}\nПри 23: {result2}");
}