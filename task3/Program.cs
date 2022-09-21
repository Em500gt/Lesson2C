using static System.Console;
Clear();

Write("Введите число 1: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите число 2: ");
int number2 = int.Parse(ReadLine()!);
int result = number1 % number2; 
if(result == 0)
{
    WriteLine("Числа кратны");
}
else
{
    WriteLine($"Числа не кратны, остаток: {result}");
}