// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,10
//A (7,-5); B (1,-1) -> 7,21
//АВ = корень квадратный ((xb - xa)2 + (yb - ya)2)

Console.WriteLine("Введите координаты по оси х первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси х второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты по оси у второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt(Math.Pow (x2 - x1 , 2) + Math.Pow (y2 - y1 , 2));

Console.WriteLine(c);
