// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти ");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.Write($"В {number} четверти диапазон координат X<0 и Y>0");
if (number == 2) Console.Write($"Во {number} четверти диапазон координат X>0 и Y>0");
if (number == 3) Console.Write($"В {number} четверти диапазон координат X>0 и Y<0");
if (number == 4) Console.Write($"В {number} четверти диапазон координат X<0 и Y<0");