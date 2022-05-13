// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели ");
int namber = int.Parse(Console.ReadLine());

// Первый вариант решения
//if (namber == 1) Console.WriteLine("Рабочий день-понедельник");
//if (namber == 2) Console.WriteLine("Рабочий день-вторник");
//if (namber == 3) Console.WriteLine("Рабочий день-среда");
//if (namber == 4) Console.WriteLine("Рабочий день-четверг");
//if (namber == 5) Console.WriteLine("Рабочий день-пятница");
//if (namber == 6) Console.WriteLine("День недели выходной-суббота");
//if (namber == 7) Console.WriteLine("День недели выходной-воскресенье ");
//else if (namber > 7) Console.WriteLine("Число не обозначает день недели");

// Второй вариант решения
if (namber > 1 && namber < 6) Console.WriteLine($"{namber} рабочий день недели");
if (namber == 6 || namber == 7) Console.WriteLine($"{namber} день недели выходной");
else if (namber > 7) Console.WriteLine($"{namber} не обозначает день недели");