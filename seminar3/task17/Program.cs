// Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату точки по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y");
int y = Convert.ToInt32(Console.ReadLine());
// что бы избежать дублирование кода нужно:
// int ReadNumber(string message);
// {
//    Console.WriteLine(message);
//    return Convert.ToInt32(Console.ReadLine());
// }
// int x = ReadNumber("Введите координату точки по Х");
// int y = ReadNumber("Введите координату точки по Y");
if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

