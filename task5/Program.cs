using static System.Console;
Clear();
//Напишите программу, которая принимает на вход 
//два числа и проверяет, является ли одно число 
//квадратом другого.

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);
if(number1 < number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
if(number1 == number2*number2)
{
    WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    WriteLine($"Число {number2} не является квадратом {number1}");
}