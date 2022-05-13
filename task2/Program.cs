// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2) Console.Write($"{number1} является квадратом {number2}");
if (number2 == number1 * number1) Console.Write($"{number2} является квадратом {number1}");
else 
{
    Console.Write("Число не является квадратом другого");
}