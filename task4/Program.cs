// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите цифру, в пространстве которого будем находить расстояние между точками, 2 или 3 ");
int space = int.Parse(Console.ReadLine());
if (space == 2)
{
    Console.WriteLine("Введите координаты х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты х2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y2 ");
    int y2 = int.Parse(Console.ReadLine());
    //По теореме Пифагора
    double result = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
    Console.WriteLine($"Расстояние между двумя точками на плоскости равно: {result}.");
}

if (space == 3)
{
    Console.WriteLine("Введите координаты х1 ");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты z1 ");
    int z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты х2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y2 ");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты z2 ");
    int z2 = int.Parse(Console.ReadLine());
 
    double result = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)) + ((z1 - z2) * (z1 - z2)));
    Console.WriteLine($"Расстояние между двумя точками в пространстве равно: {result}.");
}
else 
{
    Console.WriteLine("Введено неверное число ");
}